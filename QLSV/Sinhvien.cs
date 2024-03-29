﻿using System;
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

            //an button sinh vien
            txtMSSV.Enabled = false;
            txtHoTen.Enabled = false;
            NgaySinh.Enabled = false;
            txtPhone.Enabled = false;
            btnThem.Enabled = true;
            groupBox1.Enabled = false;
            btnLuu.Enabled = false;

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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                db.XoaSinhVien(txtMSSV.Text);
                Sinhvien_Load(sender, e);
            }
        }
        Boolean adSinhvien = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            //Hien thong tin sv de them vao
            txtMSSV.Enabled = true;
            txtHoTen.Enabled = true;
            NgaySinh.Enabled = true;
            txtPhone.Enabled = true;
            groupBox1.Enabled = true;
            cbQueQuan.Enabled = true;
            txtMaLop.Enabled = true;
            cbMaLop.Enabled = true;
            txtMSSV.Focus();
            adSinhvien = true;
            rbtnNam.Checked = true;
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
                        return;
                    }
                    if (txtHoTen.Text == "") 
                    {
                        MessageBox.Show("Bạn chưa nhập Họ và Tên");
                        txtHoTen.Focus();
                        return;
                    }
                    if (txtPhone.Text == "") 
                    {
                        MessageBox.Show("Bạn chưa nhập số điện thoại ");
                        txtPhone.Focus();
                        return;
                    }
                   
                    if (cbQueQuan.Text =="")
                    {
                        MessageBox.Show("Bạn chưa nhập quê quán ");
                        cbQueQuan.Focus();
                        return;
                    }
                    if (NgaySinh.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập ngày sinh ");
                        NgaySinh.Focus();
                        return;
                    }
                    db.ThemMoiSinhVien(txtMSSV.Text, txtHoTen.Text, rbtnNam.Checked, NgaySinh.Value, cbQueQuan.Text, txtPhone.Text, txtMaLop.Text);
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mo cac button chinh sua 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    adSinhvien = false;
                    //an thong tin sinh vien
                    txtMSSV.Enabled = false;
                    txtHoTen.Enabled = false;
                    NgaySinh.Enabled = false;
                    txtPhone.Enabled = false;
                    groupBox1.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Mã sinh viên bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {

                    db.UpdateSinhVien(txtMSSV.Text, txtHoTen.Text, rbtnNam.Checked, NgaySinh.Value, cbQueQuan.Text, txtPhone.Text, txtMaLop.Text);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //Mo button them xoa sua
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    //an thong tin sinh vien
                    txtMSSV.Enabled = false;
                    txtHoTen.Enabled = false;
                    NgaySinh.Enabled = false;
                    txtPhone.Enabled = false;
                    groupBox1.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Sinhvien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            //an thong tin sv
            txtMSSV.Enabled = false;
            txtHoTen.Enabled = true;
            NgaySinh.Enabled = true;
            txtPhone.Enabled = true;
            groupBox1.Enabled = true;
            cbQueQuan.Enabled = true;
            cbMaLop.Enabled = true;
            txtMaLop.Enabled = true;
        }

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
