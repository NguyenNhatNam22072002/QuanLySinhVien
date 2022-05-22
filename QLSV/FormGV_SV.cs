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
    public partial class FormGV_SV : Form
    {
        public FormGV_SV()
        {
            InitializeComponent();
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();

        private void GiangVien_Load(object sender, EventArgs e)
        {

            //an button giảng viên
            txtMaGV.Enabled = false;
            txtTenGV.Enabled = false;
            txtPhone.Enabled = false;
            cbTrinhdo.Enabled = false;
            txtQuoctich.Enabled = false;
            cbBomon.Enabled = false;
            cbMakhoa.Enabled = false;

            //Combox Monhoc 
            cbBomon.DisplayMember = "TenMH";
            cbBomon.ValueMember = "MaMH";
            cbBomon.DataSource = db.Show_DSMonhoc();
            cbBomon.Enabled = false;
            //Combobox Khoa
            cbMakhoa.DisplayMember = "TenKhoa";
            cbMakhoa.ValueMember = "MaKhoa";
            cbMakhoa.DataSource = db.Show_DSKhoa();
            cbMakhoa.Enabled = false;

            dataGridView1.DataSource = db.Show_DSGiangVien();
        }

        Boolean adGiangvien = false;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtMaGV.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenGV.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            cbTrinhdo.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            txtQuoctich.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            cbBomon.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            cbMakhoa.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GiangViens.Where(x => x.TenGV.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.Columns["MaGV"].HeaderText = "Mã GV";
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", dataGridView1.DataSource, "MaGV");

            dataGridView1.Columns["TenGV"].HeaderText = "Tên giảng viên";
            txtTenGV.DataBindings.Clear();
            txtTenGV.DataBindings.Add("Text", dataGridView1.DataSource, "TenGV");

            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", dataGridView1.DataSource, "SoDienThoai");

            dataGridView1.Columns["TrinhDo"].HeaderText = "Trình độ";
            cbTrinhdo.DataBindings.Clear();
            cbTrinhdo.DataBindings.Add("Text", dataGridView1.DataSource, "TrinhDo");

            dataGridView1.Columns["QuocTich"].HeaderText = "SQuốc tịch";
            txtQuoctich.DataBindings.Clear();
            txtQuoctich.DataBindings.Add("Text", dataGridView1.DataSource, "QuocTich");

            dataGridView1.Columns["BoMon"].HeaderText = "Bộ môn";
            cbBomon.DataBindings.Clear();
            cbBomon.DataBindings.Add("Text", dataGridView1.DataSource, "BoMon");

            dataGridView1.Columns["MaKhoa"].HeaderText = "Mã khoa";
            cbMakhoa.DataBindings.Clear();
            cbMakhoa.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhoa");
        }

        private void cbBomon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
