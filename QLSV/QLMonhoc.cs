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
    public partial class QLMonhoc : Form
    {
        public QLMonhoc()
        {
            InitializeComponent();
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        private void Monhoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Show_DSMonhoc();
            //tat cac textbox Khoa
            txtMaMonhoc.Enabled = false;
            txtTenMonhoc.Enabled = false;
            txtTinChi.Enabled = false;
            //Mo button Them
            btnThem.Enabled = true;
            // Tang do dai hien thi dgv
            for (int i = 0; i < 4; i++)
                dataGridView1.Columns[i].Width = 180;
        }
        bool adKhoa;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            // hien cac textbox Khoa
            txtMaMonhoc.Enabled = true;
            txtTenMonhoc.Enabled = true;
            txtTinChi.Enabled = true;
            txtMaMonhoc.Focus();
            bool adKhoa = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adKhoa)
            {
                try
                {
                    if (txtMaMonhoc.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã môn học");
                        txtMaMonhoc.Focus();
                    }
                    if (txtTenMonhoc.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên môn học");
                        txtTenMonhoc.Focus();
                    }
                    if (txtTinChi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tín chỉ");
                        txtTinChi.Focus();
                    }
                    db.ThemMonHoc(txtMaMonhoc.Text, txtTenMonhoc.Text, Convert.ToInt32(txtTinChi.Text));
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mo cac button chinh sua 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Khoa
                    txtMaMonhoc.Enabled = false;
                    txtTenMonhoc.Enabled = false;
                    txtTinChi.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Mã môn học bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.SuaThongTinMonHoc(txtMaMonhoc.Text, txtTenMonhoc.Text, Convert.ToInt32(txtTinChi.Text));
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //Mo button them xoa sua
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Khoa
                    txtMaMonhoc.Enabled = false;
                    txtTenMonhoc.Enabled = false;
                    txtTinChi.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Monhoc_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa môn học này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                db.XoaMonHoc(txtMaMonhoc.Text);
                Monhoc_Load(sender, e);
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
            txtMaMonhoc.Enabled = false;
            txtTenMonhoc.Enabled = true;
            txtTinChi.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtMaMonhoc.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenMonhoc.Text = dataGridView1.Rows[r].Cells[1].Value.ToString(); ;
            txtTinChi.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.MonHocs.Where(x => x.TenMH.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.Columns["MaMH"].HeaderText = "Mã môn học";
            txtMaMonhoc.DataBindings.Clear();
            txtMaMonhoc.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");

            dataGridView1.Columns["TenMH"].HeaderText = "Tên môn học";
            txtTenMonhoc.DataBindings.Clear();
            txtTenMonhoc.DataBindings.Add("Text", dataGridView1.DataSource, "TenMH");

            dataGridView1.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
            txtTinChi.DataBindings.Clear();
            txtTinChi.DataBindings.Add("Text", dataGridView1.DataSource, "SoTinChi");
        }
    }
}
