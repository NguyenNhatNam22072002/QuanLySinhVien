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
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }
        private void LoginGUI_Load(object sender, EventArgs e)
        {

        }

        int an_hien = 0;
        private void AnHien_Click(object sender, EventArgs e)
        {
            if (an_hien == 0)
            {
                an_hien = 1;
                //Hiện mật khẩu người dùng
                AnHien.BackgroundImage = Properties.Resources.Hien;
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                an_hien = 0;
                AnHien.BackgroundImage = Properties.Resources.An;
                txtMatKhau.PasswordChar = '●';
            }
        }
    }
}
