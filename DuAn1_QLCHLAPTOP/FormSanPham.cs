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
            if (comboBox_dongsp.Text == "Bàn Phím")
            {
                panel2.Controls.Clear();
                FormSanPhamBanPhim fspbp = new FormSanPhamBanPhim()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fspbp);
                fspbp.FormBorderStyle = FormBorderStyle.None;
                fspbp.Show();
            }
            if (comboBox_dongsp.Text == "Chuột")
            {
                panel2.Controls.Clear();
                FormSanPhamChuot fspc = new FormSanPhamChuot()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fspc);
                fspc.FormBorderStyle = FormBorderStyle.None;
                fspc.Show();
            }
            if (comboBox_dongsp.Text == "Tai Nghe")
            {
                panel2.Controls.Clear();
                FormSanPhamTaiNghe fsptn = new FormSanPhamTaiNghe()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fsptn);
                fsptn.FormBorderStyle = FormBorderStyle.None;
                fsptn.Show();
            }
            if (comboBox_dongsp.Text == "Màn Hình")
            {
                panel2.Controls.Clear();
                FormSanPhamManHinh fspmh = new FormSanPhamManHinh()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fspmh);
                fspmh.FormBorderStyle = FormBorderStyle.None;
                fspmh.Show();
            }
        }
    }
}
