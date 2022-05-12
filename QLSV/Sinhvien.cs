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
    public partial class Sinhvien : Form
    {
        public Sinhvien()
        {
            InitializeComponent();
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ChonTatCaSinhVien();
            //an hien button sinh vien
            txtMSSV.Enabled = false;
            txtHoTen.Enabled = false;
            NgaySinh.Enabled = false;
            txtPhone.Enabled = false;
            btnThem.Enabled = true;
            groupBox1.Enabled = false;
            //btnLuu.Enabled = false;
            //Combox QueQuan 
            cbQueQuan.DisplayMember = "QueQuan";
            cbQueQuan.ValueMember = "QueQuan";
            cbQueQuan.DataSource = db.ChonTatCaSinhVien();
            cbQueQuan.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {

            }
        }
        Boolean adSinhvien = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            //btnLuu.Enabled = true;

            txtMSSV.Enabled = true;
            txtHoTen.Enabled = true;
            NgaySinh.Enabled = true;
            txtPhone.Enabled = true;
            groupBox1.Enabled = true;
            cbQueQuan.Enabled = true;
            txtMSSV.Focus();
            adSinhvien = true;
        }
    }
    
}
