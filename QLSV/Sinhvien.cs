using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLSV
{
    public partial class Sinhvien : Form
    {
        public Sinhvien()
        {
            InitializeComponent();
        }
        StudentDataContextDataContext db = new StudentDataContextDataContext();

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ChonTatCaSinhVien();
        }
    }
    
}
