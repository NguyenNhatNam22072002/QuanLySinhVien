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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        private void UserForm_Load(object sender, EventArgs e)
        {
            //Tat cac textbox dang nhap
            txtUser.Enabled = false;
            txtPassword.Enabled = false;
            cbQuyen.Enabled = false;
            btnThem.Enabled = true;
            //Load du lieu vao combobox
            dataGridView1.DataSource = db.DangNhap_SelectAll();
            cbQuyen.DisplayMember = "Quyen";
            cbQuyen.ValueMember = "Quyen";
            cbQuyen.DataSource = db.DangNhap_SelectAll();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        Boolean adUser = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;

            txtUser.Enabled = true;
            txtPassword.Enabled = true;
            cbQuyen.Enabled = true;
            txtUser.Focus();
            adUser = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                db.DangNhap_Delete(txtUser.Text);
                UserForm_Load(sender, e);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            //an thong tin sv
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
            cbQuyen.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adUser)
            {
                try
                {
                    if (txtUser.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Username");
                        txtUser.Focus();
                        return;
                    }
                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Password");
                        txtPassword.Focus();
                        return;
                    }
                    if (cbQuyen.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Quyền");
                        cbQuyen.Focus();
                        return;
                    }
                    db.DangNhap_Insert(txtUser.Text, txtPassword.Text, cbQuyen.Text);
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mo cac button chinh sua 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    adUser = false;
                    //an thong tin nguoi dung
                    txtUser.Enabled = false;
                    txtPassword.Enabled = false;
                    cbQuyen.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Username bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.DangNhap_Update(txtUser.Text, txtPassword.Text, cbQuyen.Text);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //Mo button them xoa sua
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    //an thong tin sinh vien
                    txtUser.Enabled = false;
                    txtPassword.Enabled = false;
                    cbQuyen.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UserForm_Load(sender, e);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtUser.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            cbQuyen.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DangNhaps.Where(x => x.userName.Contains(txtTimKiem.Text)).ToList();
            dataGridView1.Columns["userName"].HeaderText = "Tài Khoản";
            txtUser.DataBindings.Clear();
            txtUser.DataBindings.Add("Text", dataGridView1.DataSource, "userName");

            dataGridView1.Columns["passWord"].HeaderText = "Mật khẩu";
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", dataGridView1.DataSource, "passWord");

            dataGridView1.Columns["Quyen"].HeaderText = "Quyền";
            cbQuyen.DataBindings.Clear();
            cbQuyen.DataBindings.Add("Text", dataGridView1.DataSource, "Quyen");
        }
    }
}
