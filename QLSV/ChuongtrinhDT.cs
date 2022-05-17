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
    public partial class ChuongtrinhDT : Form
    {
        public ChuongtrinhDT()
        {
            InitializeComponent();

        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        private void ChuongtrinhDT_Load(object sender, EventArgs e)
        {
            //tat cac textbox HeDT
            txtMaHeDT.Enabled = false;
            txtTenHeDT.Enabled = false;
            //Mo button Them
            btnThem.Enabled = true;
            // Tang do dai hien thi dgv
            dataGridView1.DataSource = db.DSChuongtrinhDT();
            for (int i = 0; i < 2; i++)
                dataGridView1.Columns[i].Width = 180;
        }
        Boolean adKhoa;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            // hien cac textbox HeDT
            txtMaHeDT.Enabled = true;
            txtTenHeDT.Enabled = true;
            txtMaHeDT.Focus();
            adKhoa = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adKhoa)
            {
                try
                {
                    if (txtMaHeDT.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã hệ đào tạo");
                        txtMaHeDT.Focus();
                        return;
                    }
                    if (txtTenHeDT.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên hệ đào tạo");
                        txtTenHeDT.Focus();
                        return;
                    }
                    db.ThemHeDT(txtMaHeDT.Text, txtTenHeDT.Text);
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mo cac button chinh sua 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox HeDT
                    txtMaHeDT.Enabled = false;
                    txtTenHeDT.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Mã lớp bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.SuaThongTinHeDT(txtMaHeDT.Text, txtTenHeDT.Text);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //Mo button them xoa sua
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox HeDT
                    txtMaHeDT.Enabled = false;
                    txtTenHeDT.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ChuongtrinhDT_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                db.XoaHeDT(txtMaHeDT.Text);
                ChuongtrinhDT_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //An hien cac button
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            //an hien textbox HeDT
            txtMaHeDT.Enabled = true;
            txtTenHeDT.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtMaHeDT.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenHeDT.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.HeDTs.Where(x => x.TenHeDT.Contains(txtTimkiem.Text)).ToList();
            dataGridView1.Columns["MaHeDT"].HeaderText = "Mã hệ đào tạo";
            txtMaHeDT.DataBindings.Clear();
            txtMaHeDT.DataBindings.Add("Text", dataGridView1.DataSource, "MaHeDT");

            dataGridView1.Columns["TenHeDT"].HeaderText = "Tên hệ đào tạo";
            txtTenHeDT.DataBindings.Clear();
            txtTenHeDT.DataBindings.Add("Text", dataGridView1.DataSource, "TenHeDT");
        }
    }
}
