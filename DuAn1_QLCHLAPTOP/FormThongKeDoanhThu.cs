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
    public partial class FormThongKeDoanhThu : Form
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
        }
      
        private void sảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormThongKeSanPham ftksp = new FormThongKeSanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel1.Controls.Add(ftksp);
            ftksp.FormBorderStyle = FormBorderStyle.None;
            ftksp.Show();
        }
    }
}
