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
    public partial class LopForm : Form
    {
        public LopForm()
        {
            InitializeComponent();

        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        private void LopForm_Load(object sender, EventArgs e)
        {
            //tat cac textbox Lop
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            cbMaKhoa.Enabled = false;
            cbHeDT.Enabled = false;
            cbKhoahoc.Enabled = false;
            //Mo button Them
            btnThem.Enabled = true;
            //Load cbKhoa
            cbMaKhoa.DisplayMember = "TenKhoa";
            cbMaKhoa.ValueMember = "MaKhoa";
            //cbMaKhoa.DataSource = db.Show_DSKhoa();
            cbMaKhoa.Enabled = false;
            //Load cbHeDT
            cbHeDT.DisplayMember = "TenHeDT";
            cbHeDT.ValueMember = "MaHeDT";
            //cbHeDT.DataSource = db.Show_DSHeDT();
            cbHeDT.Enabled = false;
            //Load cbKhoahoc
            cbKhoahoc.DisplayMember = "TenKhoaHoc";
            cbKhoahoc.ValueMember = "MaKhoaHoc";
            //cbKhoahoc.DataSource = db.Show_DSKhoahoc();
            cbKhoahoc.Enabled = false;
            // Tang do dai hien thi dgv
            dataGridView1.DataSource = db.Show_DSlop();
            for (int i = 0; i < 5; i++)
                dataGridView1.Columns[i].Width = 140;
        }
        Boolean adKhoa;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            // hien cac textbox Lop
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            cbMaKhoa.Enabled = true;
            cbHeDT.Enabled = true;
            cbKhoahoc.Enabled = true;
            txtMaLop.Focus();
            adKhoa = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adKhoa)
            {
                try
                {
                    if (txtMaLop.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã lớp");
                        txtMaLop.Focus();
                        return;
                    }
                    if (txtTenLop.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên lớp");
                        txtTenLop.Focus();
                        return;
                    }
                    if (cbMaKhoa.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn mã khoa");
                        cbMaKhoa.Focus();
                        return;
                    }
                    if (cbHeDT.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn hệ đào tạo");
                        cbHeDT.Focus();
                        return;
                    }
                    if (cbKhoahoc.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn khóa học");
                        cbKhoahoc.Focus();
                        return;
                    }
                    db.ThemLop(txtMaLop.Text, txtTenLop.Text, cbMaKhoa.Text, cbHeDT.Text, cbKhoahoc.Text);
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mo cac button chinh sua 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Lop
                    txtMaLop.Enabled = false;
                    txtTenLop.Enabled = false;
                    cbMaKhoa.Enabled = false;
                    cbHeDT.Enabled = false;
                    cbKhoahoc.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Mã lớp bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.SuaThongTinLop(txtMaLop.Text, txtTenLop.Text, cbMaKhoa.Text, cbHeDT.Text, cbKhoahoc.Text);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //Mo button them xoa sua
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Khoa
                    txtMaLop.Enabled = false;
                    txtTenLop.Enabled = false;
                    cbMaKhoa.Enabled = false;
                    cbHeDT.Enabled = false;
                    cbKhoahoc.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LopForm_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                db.XoaLop(txtMaLop.Text);
                LopForm_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //An hien cac button
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            //an hien textbox Lop
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = true;
            cbMaKhoa.Enabled = true;
            cbHeDT.Enabled = true;
            cbKhoahoc.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtMaLop.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenLop.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            cbMaKhoa.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            cbHeDT.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            cbKhoahoc.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Lops.Where(x => x.TenLop.Contains(txtTimkiem.Text)).ToList();
            dataGridView1.Columns["MaLop"].HeaderText = "Mã lớp";
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MaLop");

            dataGridView1.Columns["TenLop"].HeaderText = "Tên lớp";
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dataGridView1.DataSource, "TenLop");

            dataGridView1.Columns["MaKhoa"].HeaderText = "Mã khoa";
            cbMaKhoa.DataBindings.Clear();
            cbMaKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhoa");

            dataGridView1.Columns["MaHeDT"].HeaderText = "Mã hệ đào tạo";
            cbHeDT.DataBindings.Clear();
            cbHeDT.DataBindings.Add("Text", dataGridView1.DataSource, "MaHeDT");

            dataGridView1.Columns["MaKhoaHoc"].HeaderText = "Mã khóa học";
            cbHeDT.DataBindings.Clear();
            cbHeDT.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhoaHoc");
        }
    }
}
