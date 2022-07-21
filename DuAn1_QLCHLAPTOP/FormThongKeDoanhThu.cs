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

            FormThongKeSanPham ftksp = new FormThongKeSanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            ftksp.FormBorderStyle = FormBorderStyle.None;
            ftksp.Show();
        }
    }
}
