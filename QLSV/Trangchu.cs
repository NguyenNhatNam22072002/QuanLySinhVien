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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        public event EventHandler clickbtnSinhvien; 
        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            clickbtnSinhvien(this, new EventArgs());
        }
    }
}
