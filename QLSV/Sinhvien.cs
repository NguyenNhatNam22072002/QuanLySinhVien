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
            //Combobox Lop
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                //db.XoaSinhVien(txtMSSV.Text);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adSinhvien)
            {
                try
                {
                    if (txtMSSV.Text=="")
                    {
                        MessageBox.Show("Bạn chưa nhập MSSV");
                        txtMSSV.Focus();
                    }
                    if (txtHoTen.Text == "") 
                    {
                        MessageBox.Show("Bạn chưa nhập Họ và Tên");
                        txtHoTen.Focus();
                    }
                    if (txtPhone.Text == "") 
                    {
                        MessageBox.Show("Bạn chưa nhập số điện thoại ");
                        txtPhone.Focus();
                    }
                    //if (gioitinh.Text == "")
                    //{
                    //    MessageBox.Show("Bạn chưa nhập gioi tinh ");
                    //    gioitinh.Focus();
                    //}
                    if (cbQueQuan.Text =="")
                    {
                        MessageBox.Show("Bạn chưa nhập quê quán ");
                        cbQueQuan.Focus();
                    }
                    if (NgaySinh.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập ngày sinh ");
                        NgaySinh.Focus();
                    }
                    //db.ThemMoiSinhVien(txtMSSV.Text, txtHoTen.Text, NgaySinh.Value, cbQueQuan.Text, txtPhone.Text, cbMaLop.Text);
                }
                catch
                {

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
    
}
