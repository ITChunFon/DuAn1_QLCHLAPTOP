using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormThongKeSanPham : Form
    {
        public FormThongKeSanPham()
        {
            InitializeComponent();
        }
     
        private void doanhThuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormThongKeDoanhThu ftkdt = new FormThongKeDoanhThu()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel1.Controls.Add(ftkdt);
            ftkdt.FormBorderStyle = FormBorderStyle.None;
            ftkdt.Show();
        }
    }
}
