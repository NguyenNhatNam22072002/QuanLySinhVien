using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLSV
{
    public partial class ThongTinSV_SV : Form
    {
        public ThongTinSV_SV()
        {
            InitializeComponent();
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();

        private void Sinhvien_Load(object sender, EventArgs e)
        {

            //an button sinh vien
            txtMSSV.Enabled = false;
            txtHoTen.Enabled = false;
            NgaySinh.Enabled = false;
            txtPhone.Enabled = false;
            groupBox1.Enabled = false;

            //Combox QueQuan 
            cbQueQuan.DisplayMember = "QueQuan";
            cbQueQuan.ValueMember = "QueQuan";
            cbQueQuan.DataSource = db.Show_DSSinhVien();
            cbQueQuan.Enabled = false;
            //Combobox Lop
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";
            cbMaLop.DataSource = db.Show_DSlop();
            cbMaLop.Enabled = false;

            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", cbMaLop.DataSource, "maLop");
            txtMaLop.Enabled = false;
            dataGridView1.DataSource = db.Show_SV();
        }
        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SinhVien_SelectMaLop(cbMaLop.SelectedValue.ToString());
            dataGridView1.Columns["MaSV"].HeaderText = "Mã SV";
            dataGridView1.Columns["TenSV"].HeaderText = "Họ và Tên";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["QueQuan"].HeaderText = "Quê quán";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["MaLop"].HeaderText = "Mã Lớp";
        }

        Boolean adSinhvien = false;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtMSSV.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            if (dataGridView1.Rows[r].Cells[2].Value.ToString() == "Nam") rbtnNam.Checked = true;
            else rbtnNu.Checked = true;
            NgaySinh.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            cbQueQuan.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SinhViens.Where(x => x.TenSV.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.Columns["MaSV"].HeaderText = "Mã SV";
            txtMSSV.DataBindings.Clear();
            txtMSSV.DataBindings.Add("Text", dataGridView1.DataSource, "MaSV");

            dataGridView1.Columns["TenSV"].HeaderText = "Họ và Tên";
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dataGridView1.DataSource, "TenSV");

            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            NgaySinh.DataBindings.Clear();
            NgaySinh.DataBindings.Add("Text", dataGridView1.DataSource, "NgaySinh");

            dataGridView1.Columns["QueQuan"].HeaderText = "Quê Quán";
            cbQueQuan.DataBindings.Clear();
            cbQueQuan.DataBindings.Add("Text", dataGridView1.DataSource, "QueQuan");

            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", dataGridView1.DataSource, "SoDienThoai");
        }
    }
}
