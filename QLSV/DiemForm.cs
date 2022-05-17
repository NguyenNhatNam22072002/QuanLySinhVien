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
    public partial class DiemForm : Form
    {
        public DiemForm()
        {
            InitializeComponent();

        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();
        private void DiemForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Show_DSDiem();
            //tat cac textbox Khoa
            cbMSSV.Enabled = false;
            cbTenMH.Enabled = false;
            txtHocky.Enabled = false;
            txtQT1.Enabled = false;
            txtQT2.Enabled = false;
            txtCuoiKy.Enabled = false;
            //Mo button Them
            btnThem.Enabled = true;
            // Tang do dai hien thi dgv
            for (int i = 0; i < 6; i++)
                dataGridView1.Columns[i].Width = 120;
            //Truyen du lieu vao cb MSSV
            cbMSSV.DisplayMember = "MaSV";
            cbMSSV.ValueMember = "MaSV";
            cbMSSV.DataSource = db.Show_DSSinhVien();
            //Truyen du lieu vao cb MaMH
            cbTenMH.DisplayMember = "TenMH";
            cbTenMH.ValueMember = "MaMH";
            cbTenMH.DataSource = db.Show_DSMonhoc();
            // Lay du lieu tu comboBox MaLop
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", cbTenMH.DataSource, "MaMH");

        }
        Boolean adKhoa=false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            cbMSSV.Enabled = true;
            cbTenMH.Enabled = true;
            // hien cac textbox Khoa
            txtHocky.Enabled = true;
            txtQT1.Enabled = true;
            txtQT2.Enabled = true;
            txtCuoiKy.Enabled = true;
            txtHocky.Focus();
            adKhoa = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (adKhoa)
            {
                try
                {
                    if (txtHocky.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập học kỳ");
                        txtHocky.Focus();
                        return;
                    }
                    if (txtQT1.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập điểm QT 1");
                        txtQT1.Focus();
                        return;
                    }
                    if (txtQT2.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập điểm QT 2");
                        txtQT2.Focus();
                        return;
                    }
                    if (txtCuoiKy.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập điểm cuối kỳ");
                        txtCuoiKy.Focus();
                        return;
                    }
                    if (cbTenMH.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn mã môn học");
                        cbTenMH.Focus();
                        return;
                    }
                    if (cbMSSV.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn MSSV");
                        cbMSSV.Focus();
                        return;
                    }
                    db.ThemDiemSinhVien(cbMSSV.Text, txtMaMH.Text, Convert.ToInt32(txtHocky.Text), Convert.ToInt32(txtQT1.Text), Convert.ToInt32(txtQT2.Text), Convert.ToInt32(txtCuoiKy.Text));
                    MessageBox.Show("Lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Mo cac button chinh sua 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Mon Hoc
                    txtHocky.Enabled = false;
                    txtQT1.Enabled = false;
                    txtQT2.Enabled = false;
                    txtCuoiKy.Enabled = false;
                    DiemForm_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã môn học bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.SuaDiemSinhVien(cbMSSV.Text, txtMaMH.Text, Convert.ToInt32(txtHocky.Text), Convert.ToInt32(txtQT1.Text), Convert.ToInt32(txtQT2.Text), Convert.ToInt32(txtCuoiKy.Text));
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //Mo button them xoa sua
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;

                    //an textbox Khoa
                    txtHocky.Enabled = false;
                    txtQT1.Enabled = false;
                    txtQT2.Enabled = false;
                    txtCuoiKy.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DiemForm_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (xoa == DialogResult.Yes)
            {
                db.XoaDiemSinhVien(cbMSSV.Text);
                DiemForm_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //An hien cac button
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            //an hien textbox Khoa
            txtHocky.Enabled = false;
            txtQT1.Enabled = true;
            txtQT2.Enabled = true;
            txtCuoiKy.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            cbMSSV.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            cbTenMH.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            txtHocky.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            txtQT1.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            txtQT2.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            txtCuoiKy.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Diems.Where(x => x.MaMH.Contains(cbTenMH.Text)).ToList();
            dataGridView1.Columns["MaSV"].HeaderText = "MSSV";
            txtHocky.DataBindings.Clear();
            txtHocky.DataBindings.Add("Text", dataGridView1.DataSource, "MaSV");

            dataGridView1.Columns["MaMH"].HeaderText = "Mã môn học";
            txtQT1.DataBindings.Clear();
            txtQT1.DataBindings.Add("Text", dataGridView1.DataSource, "MaMH");

            dataGridView1.Columns["HocKy"].HeaderText = "Học kỳ";
            txtQT2.DataBindings.Clear();
            txtQT2.DataBindings.Add("Text", dataGridView1.DataSource, "HocKy");

            dataGridView1.Columns["DiemQuaTrinhLan1"].HeaderText = "Điểm quá trình 1";
            txtCuoiKy.DataBindings.Clear();
            txtCuoiKy.DataBindings.Add("Text", dataGridView1.DataSource, "DiemQuaTrinhLan1");

            dataGridView1.Columns["DiemQuaTrinhLan2"].HeaderText = "Điểm quá trình 2";
            txtCuoiKy.DataBindings.Clear();
            txtCuoiKy.DataBindings.Add("Text", dataGridView1.DataSource, "DiemQuaTrinhLan2");

            dataGridView1.Columns["DiemCuoiKi"].HeaderText = "Điểm cuối kỳ";
            txtCuoiKy.DataBindings.Clear();
            txtCuoiKy.DataBindings.Add("Text", dataGridView1.DataSource, "DiemCuoiKi");
        }
    }
}
