using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class KhoaForm : Form
    {
        public KhoaForm()
        {
            InitializeComponent();
            
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        private void KhoaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DSKhoa();
            //tat cac textbox Khoa
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
            txtDiaChi.Enabled = false;
            txtPhone.Enabled = false;
            //Mo button Them
            btnThem.Enabled = true;
            // Tang do dai hien thi dgv
            for (int i = 0; i < 4; i++)
                dataGridView1.Columns[i].Width = 180;
        }
        Boolean adKhoa=false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            // hien cac textbox Khoa
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;
            txtDiaChi.Enabled = true;
            txtPhone.Enabled = true;
            txtMaKhoa.Focus();
            adKhoa = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adKhoa)
            {
                try
                {
                    if (txtMaKhoa.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã khoa");
                        txtMaKhoa.Focus(); return;
                    }
                    if (txtTenKhoa.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên khoa");
                        txtTenKhoa.Focus();
                        return;
                    }
                    if (txtDiaChi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập địa chỉ");
                        txtDiaChi.Focus();
                        return;
                    }
                    if (txtPhone.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập số điện thoại");
                        txtPhone.Focus();
                        return;
                    }
                    db.ThemKhoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChi.Text, txtPhone.Text);
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mo cac button chinh sua 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Khoa
                    txtMaKhoa.Enabled = false;
                    txtTenKhoa.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtPhone.Enabled = false;
                    KhoaForm_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã khoa bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.SuaKhoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChi.Text, txtPhone.Text);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //Mo button them xoa sua
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Khoa
                    txtMaKhoa.Enabled = false;
                    txtTenKhoa.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtPhone.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                KhoaForm_Load(sender, e);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa khoa này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                db.XoaKhoa(txtMaKhoa.Text);
                KhoaForm_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //An hien cac button
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            //an hien textbox Khoa
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = true;
            txtDiaChi.Enabled = true;
            txtPhone.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtMaKhoa.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenKhoa.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();;
            txtDiaChi.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Khoas.Where(x => x.TenKhoa.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.Columns["MaKhoa"].HeaderText = "Mã Khoa";
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhoa");

            dataGridView1.Columns["TenKhoa"].HeaderText = "Tên Khoa";
            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "TenKhoa");

            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");

            dataGridView1.Columns["DienThoai"].HeaderText = "Số điện thoại";
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", dataGridView1.DataSource, "DienThoai");
        }
    }
}