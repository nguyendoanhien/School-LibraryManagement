namespace QuanLyThuVien
{
    partial class frmPhieuTra
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
            this.dtgvDsSachMuon = new System.Windows.Forms.DataGridView();
            this.grpbx = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.btnTimPhieuMuon = new System.Windows.Forms.Button();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.MaThuThu = new System.Windows.Forms.Label();
            this.lblMaPhieuTra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTTPhieuTra = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDsSachTra = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnLuuThoat = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaPhieuMuon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsSachMuon)).BeginInit();
            this.grpbx.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnTTPhieuTra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsSachTra)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnLuuThoat.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDsSachMuon
            // 
            this.dtgvDsSachMuon.AllowUserToAddRows = false;
            this.dtgvDsSachMuon.AllowUserToDeleteRows = false;
            this.dtgvDsSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDsSachMuon.Location = new System.Drawing.Point(7, 29);
            this.dtgvDsSachMuon.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtgvDsSachMuon.MultiSelect = false;
            this.dtgvDsSachMuon.Name = "dtgvDsSachMuon";
            this.dtgvDsSachMuon.ReadOnly = true;
            this.dtgvDsSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDsSachMuon.Size = new System.Drawing.Size(1508, 291);
            this.dtgvDsSachMuon.TabIndex = 0;
            this.dtgvDsSachMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsSachMuon_CellContentClick);
            // 
            // grpbx
            // 
            this.grpbx.Controls.Add(this.dtgvDsSachMuon);
            this.grpbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx.Location = new System.Drawing.Point(0, 0);
            this.grpbx.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpbx.Name = "grpbx";
            this.grpbx.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpbx.Size = new System.Drawing.Size(1522, 327);
            this.grpbx.TabIndex = 0;
            this.grpbx.TabStop = false;
            this.grpbx.Text = "Danh sách sách mượn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpbx);
            this.panel3.Location = new System.Drawing.Point(64, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1522, 327);
            this.panel3.TabIndex = 0;
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.panel3);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTin.Location = new System.Drawing.Point(0, 408);
            this.pnThongTin.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(1650, 334);
            this.pnThongTin.TabIndex = 11;
            // 
            // btnTimPhieuMuon
            // 
            this.btnTimPhieuMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimPhieuMuon.Image = global::QuanLyThuVien.Properties.Resources.search;
            this.btnTimPhieuMuon.Location = new System.Drawing.Point(940, 205);
            this.btnTimPhieuMuon.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnTimPhieuMuon.Name = "btnTimPhieuMuon";
            this.btnTimPhieuMuon.Size = new System.Drawing.Size(130, 48);
            this.btnTimPhieuMuon.TabIndex = 18;
            this.btnTimPhieuMuon.UseVisualStyleBackColor = true;
            this.btnTimPhieuMuon.Click += new System.EventHandler(this.btnTimPhieuMuon_Click);
            // 
            // dateTra
            // 
            this.dateTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTra.CustomFormat = "yyyy-MM-dd";
            this.dateTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTra.Location = new System.Drawing.Point(940, 126);
            this.dateTra.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(231, 39);
            this.dateTra.TabIndex = 15;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia.Location = new System.Drawing.Point(428, 205);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(494, 39);
            this.txtMaDocGia.TabIndex = 5;
            // 
            // MaThuThu
            // 
            this.MaThuThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaThuThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MaThuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaThuThu.Location = new System.Drawing.Point(428, 126);
            this.MaThuThu.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MaThuThu.Name = "MaThuThu";
            this.MaThuThu.Size = new System.Drawing.Size(497, 59);
            this.MaThuThu.TabIndex = 3;
            // 
            // lblMaPhieuTra
            // 
            this.lblMaPhieuTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaPhieuTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaPhieuTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuTra.Location = new System.Drawing.Point(428, 52);
            this.lblMaPhieuTra.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMaPhieuTra.Name = "lblMaPhieuTra";
            this.lblMaPhieuTra.Size = new System.Drawing.Size(497, 59);
            this.lblMaPhieuTra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu trả";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã độc giả";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(932, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày trả thực tế";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaPhieuMuon);
            this.groupBox1.Controls.Add(this.btnTimPhieuMuon);
            this.groupBox1.Controls.Add(this.dateTra);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.MaThuThu);
            this.groupBox1.Controls.Add(this.lblMaPhieuTra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(1650, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu trả";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1650, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO PHIẾU TRẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTTPhieuTra
            // 
            this.pnTTPhieuTra.Controls.Add(this.groupBox1);
            this.pnTTPhieuTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTTPhieuTra.Location = new System.Drawing.Point(0, 105);
            this.pnTTPhieuTra.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pnTTPhieuTra.Name = "pnTTPhieuTra";
            this.pnTTPhieuTra.Size = new System.Drawing.Size(1650, 303);
            this.pnTTPhieuTra.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 105);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1514, 214);
            this.panel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvDsSachTra);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox4.Size = new System.Drawing.Size(1514, 214);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sách trả";
            // 
            // dtgvDsSachTra
            // 
            this.dtgvDsSachTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsSachTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDsSachTra.Location = new System.Drawing.Point(7, 29);
            this.dtgvDsSachTra.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtgvDsSachTra.Name = "dtgvDsSachTra";
            this.dtgvDsSachTra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvDsSachTra.Size = new System.Drawing.Size(1500, 178);
            this.dtgvDsSachTra.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(64, 349);
            this.panel5.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1219, 214);
            this.panel5.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyThuVien.Properties.Resources.savee;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(836, 7);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(198, 92);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyThuVien.Properties.Resources.EXIT;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1085, 7);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(198, 92);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnLuuThoat
            // 
            this.pnLuuThoat.Controls.Add(this.panel4);
            this.pnLuuThoat.Controls.Add(this.panel5);
            this.pnLuuThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLuuThoat.Location = new System.Drawing.Point(0, 408);
            this.pnLuuThoat.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pnLuuThoat.Name = "pnLuuThoat";
            this.pnLuuThoat.Size = new System.Drawing.Size(1650, 636);
            this.pnLuuThoat.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 503);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1650, 133);
            this.panel4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã phiếu mượn";
            // 
            // cbMaPhieuMuon
            // 
            this.cbMaPhieuMuon.FormattingEnabled = true;
            this.cbMaPhieuMuon.Location = new System.Drawing.Point(428, 250);
            this.cbMaPhieuMuon.Name = "cbMaPhieuMuon";
            this.cbMaPhieuMuon.Size = new System.Drawing.Size(494, 37);
            this.cbMaPhieuMuon.TabIndex = 19;
            this.cbMaPhieuMuon.SelectedValueChanged += new System.EventHandler(this.cbMaPhieuMuon_SelectedValueChanged);
            // 
            // frmPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1044);
            this.ControlBox = false;
            this.Controls.Add(this.pnThongTin);
            this.Controls.Add(this.pnLuuThoat);
            this.Controls.Add(this.pnTTPhieuTra);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmPhieuTra";
            this.Text = "Phiếu trả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsSachMuon)).EndInit();
            this.grpbx.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnThongTin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnTTPhieuTra.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsSachTra)).EndInit();
            this.panel5.ResumeLayout(false);
            this.pnLuuThoat.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dtgvDsSachMuon;
        private System.Windows.Forms.GroupBox grpbx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Button btnTimPhieuMuon;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label MaThuThu;
        private System.Windows.Forms.Label lblMaPhieuTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTTPhieuTra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvDsSachTra;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnLuuThoat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbMaPhieuMuon;
        private System.Windows.Forms.Label label5;
    }
}