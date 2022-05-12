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
    public partial class KhoaForm : Form
    {
        public KhoaForm()
        {
            InitializeComponent();
            
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        private void KhoaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DSKhoa();
            //tat cac textbox Khoa
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
            txtDiaChi.Enabled = false;
            txtPhone.Enabled = false;
            //Mo button Them
            btnThem.Enabled = true;
            for (int i = 0; i < 4; i++)
                dataGridView1.Columns[i].Width = 180;
        }
        bool adKhoa;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            // hien cac textbox Khoa
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;
            txtDiaChi.Enabled = true;
            txtPhone.Enabled = true;
            txtMaKhoa.Focus();
            bool adKhoa = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adKhoa)
            {
                try
                {
                    if (txtMaKhoa.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã khoa");
                        txtMaKhoa.Focus();
                    }
                    if (txtTenKhoa.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên khoa");
                        txtTenKhoa.Focus();
                    }
                    if (txtDiaChi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập địa chỉ");
                        txtDiaChi.Focus();
                    }
                    if (txtPhone.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập số điện thoại");
                        txtPhone.Focus();
                    }
                    db.ThemKhoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChi.Text, txtPhone.Text);
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mo cac button chinh sua 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Khoa
                    txtMaKhoa.Enabled = false;
                    txtTenKhoa.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtPhone.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Mã khoa bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.SuaKhoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChi.Text, txtPhone.Text);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //Mo button them xoa sua
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Khoa
                    txtMaKhoa.Enabled = false;
                    txtTenKhoa.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtPhone.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                KhoaForm_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa khoa này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                db.XoaSinhVien(txtMaKhoa.Text);
                KhoaForm_Load(sender, e);
            }
        }
    }
}
