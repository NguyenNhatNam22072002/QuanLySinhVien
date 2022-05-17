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
            cbServer.Items.Add(SystemInformation.UserDomainName.ToString() + "\\SQLServer");
            cbServer.Text = cbServer.Items[0].ToString();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            StudentDataContextDataContext db = new StudentDataContextDataContext();

            var query = from LoginList in db.DangNhaps
                        where LoginList.userName == txtTaiKhoan.Text && LoginList.passWord == txtMatKhau.Text
                        select LoginList;
            if (query.Count() == 0)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Đăng nhập không thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
                Application.Exit();
            }
            else
            {
                GiaoDienChinh chinh = new GiaoDienChinh(txtTaiKhoan.Text);
                this.Hide();
                chinh.ShowDialog();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13 )
            {
                btnDangNhap.Enabled = true;
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
