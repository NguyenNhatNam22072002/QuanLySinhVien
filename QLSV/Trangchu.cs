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
        public event EventHandler clickbtnKhoa;
        public event EventHandler clickbtnLop;
        public event EventHandler clickbtnMonhoc;
        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            clickbtnSinhvien(this, new EventArgs());
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            clickbtnKhoa(this, new EventArgs());
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            clickbtnLop(this, new EventArgs());
        }

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            clickbtnMonhoc(this, new EventArgs());
        }
    }
}
