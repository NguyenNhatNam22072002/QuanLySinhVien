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
    public partial class FormDiemSV : Form
    {
        public FormDiemSV()
        {
            InitializeComponent();
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        private void FormDiemSV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DiemOfSV();
            //tat cac textbox Khoa
            cbMSSV.Enabled = false;
            cbTenMH.Enabled = false;
            txtHocky.Enabled = false;
            txtQT1.Enabled = false;
            txtQT2.Enabled = false;
            txtCuoiKy.Enabled = false;
            //Mo button Them
            // Tang do dai hien thi dgv
            for (int i = 0; i < 6; i++)
                dataGridView1.Columns[i].Width = 120;
            //Truyen du lieu vao cb MSSV
            cbMSSV.DisplayMember = "MaSV";
            cbMSSV.ValueMember = "MaSV";
            cbMSSV.DataSource = db.Show_DSSinhVien();
            //Truyen du lieu vao cb MaMH
            cbTenMH.DisplayMember = "TenMH";
            cbTenMH.ValueMember = "MaMH";
            cbTenMH.DataSource = db.Show_DSMonhoc();
            // Lay du lieu tu comboBox MaLop
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", cbTenMH.DataSource, "MaMH");

        }
        Boolean adKhoa = false;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            cbMSSV.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            cbTenMH.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtHocky.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            txtQT1.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            txtQT2.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            txtCuoiKy.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Diems.Where(x => x.MaMH.Contains(cbTenMH.Text)).ToList();
            dataGridView1.Columns["MaSV"].HeaderText = "MSSV";
            txtHocky.DataBindings.Clear();
            txtHocky.DataBindings.Add("Text", dataGridView1.DataSource, "MaSV");

            dataGridView1.Columns["MaMH"].HeaderText = "Mã môn học";
            txtQT1.DataBindings.Clear();
            txtQT1.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");

            dataGridView1.Columns["HocKy"].HeaderText = "Học kỳ";
            txtQT2.DataBindings.Clear();
            txtQT2.DataBindings.Add("Text", dataGridView1.DataSource, "HocKy");

            dataGridView1.Columns["DiemQuaTrinhLan1"].HeaderText = "Điểm quá trình 1";
            txtCuoiKy.DataBindings.Clear();
            txtCuoiKy.DataBindings.Add("Text", dataGridView1.DataSource, "DiemQuaTrinhLan1");

            dataGridView1.Columns["DiemQuaTrinhLan2"].HeaderText = "Điểm quá trình 2";
            txtCuoiKy.DataBindings.Clear();
            txtCuoiKy.DataBindings.Add("Text", dataGridView1.DataSource, "DiemQuaTrinhLan2");

            dataGridView1.Columns["DiemCuoiKi"].HeaderText = "Điểm cuối kỳ";
            txtCuoiKy.DataBindings.Clear();
            txtCuoiKy.DataBindings.Add("Text", dataGridView1.DataSource, "DiemCuoiKi");
        }
    }
}
