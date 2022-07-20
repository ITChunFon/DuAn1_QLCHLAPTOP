namespace Presentation
{
    partial class FormThongKeDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_guibaocao = new System.Windows.Forms.Button();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdb_thang = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdb_tatca = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 879);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_guibaocao);
            this.panel3.Controls.Add(this.rdb_nam);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.rdb_thang);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.rdb_tatca);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(47, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1317, 841);
            this.panel3.TabIndex = 2;
            // 
            // bt_guibaocao
            // 
            this.bt_guibaocao.BackColor = System.Drawing.Color.Yellow;
            this.bt_guibaocao.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_guibaocao.ForeColor = System.Drawing.Color.Black;
            this.bt_guibaocao.Location = new System.Drawing.Point(1166, 758);
            this.bt_guibaocao.Name = "bt_guibaocao";
            this.bt_guibaocao.Size = new System.Drawing.Size(151, 37);
            this.bt_guibaocao.TabIndex = 40;
            this.bt_guibaocao.Text = "Gửi Báo Cáo";
            this.bt_guibaocao.UseVisualStyleBackColor = false;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nam.Location = new System.Drawing.Point(25, 145);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(68, 27);
            this.rdb_nam.TabIndex = 37;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Năm";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2022",
            "2023"});
            this.comboBox2.Location = new System.Drawing.Point(175, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 31);
            this.comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.comboBox1.Location = new System.Drawing.Point(175, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 31);
            this.comboBox1.TabIndex = 31;
            // 
            // rdb_thang
            // 
            this.rdb_thang.AutoSize = true;
            this.rdb_thang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_thang.Location = new System.Drawing.Point(25, 200);
            this.rdb_thang.Name = "rdb_thang";
            this.rdb_thang.Size = new System.Drawing.Size(79, 27);
            this.rdb_thang.TabIndex = 36;
            this.rdb_thang.TabStop = true;
            this.rdb_thang.Text = "Tháng";
            this.rdb_thang.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 484);
            this.dataGridView1.TabIndex = 33;
            // 
            // rdb_tatca
            // 
            this.rdb_tatca.AutoSize = true;
            this.rdb_tatca.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_tatca.Location = new System.Drawing.Point(25, 98);
            this.rdb_tatca.Name = "rdb_tatca";
            this.rdb_tatca.Size = new System.Drawing.Size(80, 27);
            this.rdb_tatca.TabIndex = 34;
            this.rdb_tatca.TabStop = true;
            this.rdb_tatca.Text = "Tất Cả";
            this.rdb_tatca.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1317, 43);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(144, 39);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click_1);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(157, 39);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 903);
            this.Controls.Add(this.panel1);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDoanhThu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button bt_guibaocao;
        private RadioButton rdb_nam;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private RadioButton rdb_thang;
        private DataGridView dataGridView1;
        private RadioButton rdb_tatca;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
    }
}