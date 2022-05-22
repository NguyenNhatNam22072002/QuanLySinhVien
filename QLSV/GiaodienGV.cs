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
    public partial class GiaodienGV : Form
    {
        StudentDataContextDataContext db = new StudentDataContextDataContext();

        private Form currentFormChild;
        public GiaodienGV()
        {
            InitializeComponent();
            MessageBox.Show(" Chào mừng đến với hệ thống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenChildForm(new FormTrangChuSV());
        }
        private void OpenChildForm(Form childForm)
        {
            if (this.currentFormChild != null)
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
            FormTrangChuSV Form = new FormTrangChuSV();
            OpenChildForm(Form);
        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sinhvien());
        }

        private void btnCTDT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CTDT_SV());
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

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGV_SV());
        }

        private void GiaoDienChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            showLogin(sender, new EventArgs());
        }
    }
}
