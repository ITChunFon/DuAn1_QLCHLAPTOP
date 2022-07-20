namespace Presentation
{
    partial class FormKhuyenMai
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
            this.groupBox_danhsach = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_chuongtrinh = new System.Windows.Forms.GroupBox();
            this.comboBox_htkm = new System.Windows.Forms.ComboBox();
            this.lb_timeoff = new System.Windows.Forms.Label();
            this.lb_timeon = new System.Windows.Forms.Label();
            this.label_hinhthuc = new System.Windows.Forms.Label();
            this.lb_makm = new System.Windows.Forms.Label();
            this.lb_ctkm = new System.Windows.Forms.Label();
            this.lb_sanphamgiamgia = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.tb_makhuyenmai = new System.Windows.Forms.TextBox();
            this.tb_chuongtrinhkhuyenmai = new System.Windows.Forms.TextBox();
            this.tb_spgiamgia = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.rdb_apdung = new System.Windows.Forms.RadioButton();
            this.rdb_khongapdung = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox_danhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_chuongtrinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_danhsach);
            this.panel1.Controls.Add(this.groupBox_chuongtrinh);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 879);
            this.panel1.TabIndex = 1;
            // 
            // groupBox_danhsach
            // 
            this.groupBox_danhsach.Controls.Add(this.dataGridView1);
            this.groupBox_danhsach.Location = new System.Drawing.Point(10, 535);
            this.groupBox_danhsach.Name = "groupBox_danhsach";
            this.groupBox_danhsach.Size = new System.Drawing.Size(1331, 323);
            this.groupBox_danhsach.TabIndex = 1;
            this.groupBox_danhsach.TabStop = false;
            this.groupBox_danhsach.Text = "Danh Sách Khuyến Mại";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox_chuongtrinh
            // 
            this.groupBox_chuongtrinh.Controls.Add(this.rdb_khongapdung);
            this.groupBox_chuongtrinh.Controls.Add(this.rdb_apdung);
            this.groupBox_chuongtrinh.Controls.Add(this.lb_trangthai);
            this.groupBox_chuongtrinh.Controls.Add(this.bt_sua);
            this.groupBox_chuongtrinh.Controls.Add(this.bt_them);
            this.groupBox_chuongtrinh.Controls.Add(this.dataGridView2);
            this.groupBox_chuongtrinh.Controls.Add(this.tb_mota);
            this.groupBox_chuongtrinh.Controls.Add(this.dateTimePicker2);
            this.groupBox_chuongtrinh.Controls.Add(this.dateTimePicker1);
            this.groupBox_chuongtrinh.Controls.Add(this.tb_spgiamgia);
            this.groupBox_chuongtrinh.Controls.Add(this.tb_chuongtrinhkhuyenmai);
            this.groupBox_chuongtrinh.Controls.Add(this.tb_makhuyenmai);
            this.groupBox_chuongtrinh.Controls.Add(this.lb_mota);
            this.groupBox_chuongtrinh.Controls.Add(this.lb_sanphamgiamgia);
            this.groupBox_chuongtrinh.Controls.Add(this.lb_ctkm);
            this.groupBox_chuongtrinh.Controls.Add(this.lb_makm);
            this.groupBox_chuongtrinh.Controls.Add(this.comboBox_htkm);
            this.groupBox_chuongtrinh.Controls.Add(this.lb_timeoff);
            this.groupBox_chuongtrinh.Controls.Add(this.lb_timeon);
            this.groupBox_chuongtrinh.Controls.Add(this.label_hinhthuc);
            this.groupBox_chuongtrinh.Location = new System.Drawing.Point(10, 11);
            this.groupBox_chuongtrinh.Name = "groupBox_chuongtrinh";
            this.groupBox_chuongtrinh.Size = new System.Drawing.Size(1331, 498);
            this.groupBox_chuongtrinh.TabIndex = 0;
            this.groupBox_chuongtrinh.TabStop = false;
            this.groupBox_chuongtrinh.Text = "Chương Trình Khuyến Mại";
            // 
            // comboBox_htkm
            // 
            this.comboBox_htkm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_htkm.FormattingEnabled = true;
            this.comboBox_htkm.Items.AddRange(new object[] {
            "Giảm theo %",
            "Giảm theo số tiền"});
            this.comboBox_htkm.Location = new System.Drawing.Point(268, 149);
            this.comboBox_htkm.Name = "comboBox_htkm";
            this.comboBox_htkm.Size = new System.Drawing.Size(193, 31);
            this.comboBox_htkm.TabIndex = 29;
            // 
            // lb_timeoff
            // 
            this.lb_timeoff.AutoSize = true;
            this.lb_timeoff.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_timeoff.Location = new System.Drawing.Point(726, 103);
            this.lb_timeoff.Name = "lb_timeoff";
            this.lb_timeoff.Size = new System.Drawing.Size(155, 23);
            this.lb_timeoff.TabIndex = 28;
            this.lb_timeoff.Text = "Thời Gian Kết Thúc";
            // 
            // lb_timeon
            // 
            this.lb_timeon.AutoSize = true;
            this.lb_timeon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_timeon.Location = new System.Drawing.Point(726, 51);
            this.lb_timeon.Name = "lb_timeon";
            this.lb_timeon.Size = new System.Drawing.Size(149, 23);
            this.lb_timeon.TabIndex = 27;
            this.lb_timeon.Text = "Thời Gian Bắt Đầu";
            // 
            // label_hinhthuc
            // 
            this.label_hinhthuc.AutoSize = true;
            this.label_hinhthuc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_hinhthuc.Location = new System.Drawing.Point(17, 157);
            this.label_hinhthuc.Name = "label_hinhthuc";
            this.label_hinhthuc.Size = new System.Drawing.Size(187, 23);
            this.label_hinhthuc.TabIndex = 26;
            this.label_hinhthuc.Text = "Hình Thức Khuyến Mại";
            // 
            // lb_makm
            // 
            this.lb_makm.AutoSize = true;
            this.lb_makm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_makm.Location = new System.Drawing.Point(17, 51);
            this.lb_makm.Name = "lb_makm";
            this.lb_makm.Size = new System.Drawing.Size(132, 23);
            this.lb_makm.TabIndex = 32;
            this.lb_makm.Text = "Mã Khuyến Mại";
            // 
            // lb_ctkm
            // 
            this.lb_ctkm.AutoSize = true;
            this.lb_ctkm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ctkm.Location = new System.Drawing.Point(17, 103);
            this.lb_ctkm.Name = "lb_ctkm";
            this.lb_ctkm.Size = new System.Drawing.Size(212, 23);
            this.lb_ctkm.TabIndex = 33;
            this.lb_ctkm.Text = "Chương Trình Khuyến Mại";
            // 
            // lb_sanphamgiamgia
            // 
            this.lb_sanphamgiamgia.AutoSize = true;
            this.lb_sanphamgiamgia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_sanphamgiamgia.Location = new System.Drawing.Point(17, 220);
            this.lb_sanphamgiamgia.Name = "lb_sanphamgiamgia";
            this.lb_sanphamgiamgia.Size = new System.Drawing.Size(162, 23);
            this.lb_sanphamgiamgia.TabIndex = 34;
            this.lb_sanphamgiamgia.Text = "Sản Phẩm Giảm Giá";
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_mota.Location = new System.Drawing.Point(726, 157);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(59, 23);
            this.lb_mota.TabIndex = 35;
            this.lb_mota.Text = "Mô Tả";
            // 
            // tb_makhuyenmai
            // 
            this.tb_makhuyenmai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_makhuyenmai.Location = new System.Drawing.Point(268, 44);
            this.tb_makhuyenmai.Name = "tb_makhuyenmai";
            this.tb_makhuyenmai.Size = new System.Drawing.Size(263, 30);
            this.tb_makhuyenmai.TabIndex = 36;
            // 
            // tb_chuongtrinhkhuyenmai
            // 
            this.tb_chuongtrinhkhuyenmai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_chuongtrinhkhuyenmai.Location = new System.Drawing.Point(268, 96);
            this.tb_chuongtrinhkhuyenmai.Name = "tb_chuongtrinhkhuyenmai";
            this.tb_chuongtrinhkhuyenmai.Size = new System.Drawing.Size(263, 30);
            this.tb_chuongtrinhkhuyenmai.TabIndex = 37;
            // 
            // tb_spgiamgia
            // 
            this.tb_spgiamgia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_spgiamgia.Location = new System.Drawing.Point(268, 213);
            this.tb_spgiamgia.Name = "tb_spgiamgia";
            this.tb_spgiamgia.Size = new System.Drawing.Size(263, 30);
            this.tb_spgiamgia.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(911, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 30);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(911, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(321, 30);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // tb_mota
            // 
            this.tb_mota.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mota.Location = new System.Drawing.Point(911, 150);
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(263, 30);
            this.tb_mota.TabIndex = 41;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 280);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(708, 195);
            this.dataGridView2.TabIndex = 1;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Yellow;
            this.bt_them.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_them.ForeColor = System.Drawing.Color.Black;
            this.bt_them.Location = new System.Drawing.Point(911, 315);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(167, 37);
            this.bt_them.TabIndex = 42;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Yellow;
            this.bt_sua.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.ForeColor = System.Drawing.Color.Black;
            this.bt_sua.Location = new System.Drawing.Point(911, 399);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(167, 37);
            this.bt_sua.TabIndex = 43;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_trangthai.Location = new System.Drawing.Point(726, 220);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(90, 23);
            this.lb_trangthai.TabIndex = 44;
            this.lb_trangthai.Text = "Trạng Thái";
            // 
            // rdb_apdung
            // 
            this.rdb_apdung.AutoSize = true;
            this.rdb_apdung.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_apdung.Location = new System.Drawing.Point(911, 218);
            this.rdb_apdung.Name = "rdb_apdung";
            this.rdb_apdung.Size = new System.Drawing.Size(99, 27);
            this.rdb_apdung.TabIndex = 45;
            this.rdb_apdung.TabStop = true;
            this.rdb_apdung.Text = "Áp Dụng";
            this.rdb_apdung.UseVisualStyleBackColor = true;
            // 
            // rdb_khongapdung
            // 
            this.rdb_khongapdung.AutoSize = true;
            this.rdb_khongapdung.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_khongapdung.Location = new System.Drawing.Point(1075, 218);
            this.rdb_khongapdung.Name = "rdb_khongapdung";
            this.rdb_khongapdung.Size = new System.Drawing.Size(154, 27);
            this.rdb_khongapdung.TabIndex = 46;
            this.rdb_khongapdung.TabStop = true;
            this.rdb_khongapdung.Text = "Không Áp Dụng";
            this.rdb_khongapdung.UseVisualStyleBackColor = true;
            // 
            // FormKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 903);
            this.Controls.Add(this.panel1);
            this.Name = "FormKhuyenMai";
            this.Text = "FormKhuyenMai";
            this.panel1.ResumeLayout(false);
            this.groupBox_danhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_chuongtrinh.ResumeLayout(false);
            this.groupBox_chuongtrinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox_danhsach;
        private DataGridView dataGridView1;
        private GroupBox groupBox_chuongtrinh;
        private ComboBox comboBox_htkm;
        private Label lb_timeoff;
        private Label lb_timeon;
        private Label label_hinhthuc;
        private Label lb_ctkm;
        private Label lb_makm;
        private Label lb_sanphamgiamgia;
        private Label lb_mota;
        private DataGridView dataGridView2;
        private TextBox tb_mota;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox tb_spgiamgia;
        private TextBox tb_chuongtrinhkhuyenmai;
        private TextBox tb_makhuyenmai;
        private Button bt_them;
        private Label lb_trangthai;
        private Button bt_sua;
        private RadioButton rdb_khongapdung;
        private RadioButton rdb_apdung;
    }
}