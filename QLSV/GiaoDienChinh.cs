﻿using System;
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
    public partial class GiaoDienChinh : Form
    {
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        
        private Form currentFormChild;
        public GiaoDienChinh(string user)
        {
            InitializeComponent();
            MessageBox.Show(" Chào mừng đến với hệ thống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void OpenChildForm(Form childForm)
        {
            if(this.currentFormChild != null)
            {
                currentFormChild.Close();
            }
            this.currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            Trangchu Form = new Trangchu();
            OpenChildForm(Form);
            Form.clickbtnSinhvien += btnSinhvien_Click;
            Form.clickbtnKhoa += btnKhoa_Click;
            Form.clickbtnLop += btnLop_Click;
            Form.clickbtnMonhoc += btnQLMonHoc_Click;
        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sinhvien());
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhoaForm());
        }

        private void btnCTDT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChuongtrinhDT());
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopForm());
        }

        private void btnQLMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLMonhoc());
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiemForm());
        }
        public event EventHandler showLogin;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            showLogin(sender, new EventArgs());
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiangVienForm());
        }

        private void GiaoDienChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            showLogin(sender, new EventArgs());
        }
    }
}
