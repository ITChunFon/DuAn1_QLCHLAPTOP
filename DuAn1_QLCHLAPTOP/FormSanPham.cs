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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void comboBox_dongsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_dongsp.Text == "PC")
            {
                panel2.Controls.Clear();
                FormSanPhamPC fsppc = new FormSanPhamPC()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fsppc);
                fsppc.FormBorderStyle = FormBorderStyle.None;
                fsppc.Show();
            }
            if (comboBox_dongsp.Text == "Laptop")
            {
                panel2.Controls.Clear();
                FormSanPhamLaptop fspl = new FormSanPhamLaptop()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fspl) ;
                fspl.FormBorderStyle = FormBorderStyle.None;
                fspl.Show();
            }
        }
    }
}
