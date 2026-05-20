using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            UCQLSinhVien uCQLSinhVien = new UCQLSinhVien();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uCQLSinhVien);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLSinhVien uCQLSinhVien = new UCQLSinhVien();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uCQLSinhVien);
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLLopHoc uCQLLopHoc = new UCQLLopHoc();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uCQLLopHoc);
            
        }
    }
}
