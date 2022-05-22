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
    public partial class CTDT_SV : Form
    {
        public CTDT_SV()
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
            // Tang do dai hien thi dgv
            dataGridView1.DataSource = db.DSChuongtrinhDT();
            for (int i = 0; i < 2; i++)
                dataGridView1.Columns[i].Width = 180;
        }
        Boolean adKhoa;
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
