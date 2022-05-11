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
    public partial class GiaoDienChinh : Form
    {
        private Form currentFormChild;
        public GiaoDienChinh()
        {
            InitializeComponent();
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
        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sinhvien());
        }
    }
}
