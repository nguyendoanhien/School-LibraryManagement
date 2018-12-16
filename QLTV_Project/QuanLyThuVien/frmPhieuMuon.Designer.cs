namespace QuanLyThuVien
{
    partial class frmPhieuMuon
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
            this.lsDSsachMuon = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChiTietSach = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblMaDauSach = new System.Windows.Forms.Label();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChiTietDG = new System.Windows.Forms.Button();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.dateMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.MaThuThu = new System.Windows.Forms.Label();
            this.lblMaPhieuMuon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsDSsachMuon
            // 
            this.lsDSsachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsDSsachMuon.Location = new System.Drawing.Point(3, 19);
            this.lsDSsachMuon.Name = "lsDSsachMuon";
            this.lsDSsachMuon.Size = new System.Drawing.Size(665, 169);
            this.lsDSsachMuon.TabIndex = 0;
            this.lsDSsachMuon.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 348);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(671, 191);
            this.panel5.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsDSsachMuon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 191);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách mượn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 539);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 59);
            this.panel4.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyThuVien.Properties.Resources.EXIT;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(549, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QuanLyThuVien.Properties.Resources.savee;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(450, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 41);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã sách";
            // 
            // btnChiTietSach
            // 
            this.btnChiTietSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChiTietSach.Location = new System.Drawing.Point(384, 37);
            this.btnChiTietSach.Name = "btnChiTietSach";
            this.btnChiTietSach.Size = new System.Drawing.Size(49, 23);
            this.btnChiTietSach.TabIndex = 9;
            this.btnChiTietSach.Text = "...";
            this.btnChiTietSach.UseVisualStyleBackColor = true;
            this.btnChiTietSach.Click += new System.EventHandler(this.btnChiTietSach_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tên sách";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Mã đầu sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTenSach);
            this.groupBox2.Controls.Add(this.lblMaSach);
            this.groupBox2.Controls.Add(this.lblMaDauSach);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnXoaSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Controls.Add(this.btnChiTietSach);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 164);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm sách mượn";
            // 
            // lblTenSach
            // 
            this.lblTenSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenSach.Location = new System.Drawing.Point(145, 121);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(227, 23);
            this.lblTenSach.TabIndex = 21;
            // 
            // lblMaSach
            // 
            this.lblMaSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaSach.Location = new System.Drawing.Point(145, 79);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(227, 23);
            this.lblMaSach.TabIndex = 20;
            // 
            // lblMaDauSach
            // 
            this.lblMaDauSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaDauSach.Location = new System.Drawing.Point(145, 37);
            this.lblMaDauSach.Name = "lblMaDauSach";
            this.lblMaDauSach.Size = new System.Drawing.Size(227, 23);
            this.lblMaDauSach.TabIndex = 19;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSach.Image = global::QuanLyThuVien.Properties.Resources.cancel2;
            this.btnXoaSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSach.Location = new System.Drawing.Point(484, 101);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(81, 41);
            this.btnXoaSach.TabIndex = 17;
            this.btnXoaSach.Text = "Xoá";
            this.btnXoaSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.Image = global::QuanLyThuVien.Properties.Resources.add;
            this.btnThemSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSach.Location = new System.Drawing.Point(484, 28);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(81, 41);
            this.btnThemSach.TabIndex = 12;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 164);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 138);
            this.panel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChiTietDG);
            this.groupBox1.Controls.Add(this.dateTra);
            this.groupBox1.Controls.Add(this.dateMuon);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.MaThuThu);
            this.groupBox1.Controls.Add(this.lblMaPhieuMuon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn";
            // 
            // btnChiTietDG
            // 
            this.btnChiTietDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChiTietDG.Image = global::QuanLyThuVien.Properties.Resources.search;
            this.btnChiTietDG.Location = new System.Drawing.Point(378, 93);
            this.btnChiTietDG.Name = "btnChiTietDG";
            this.btnChiTietDG.Size = new System.Drawing.Size(55, 25);
            this.btnChiTietDG.TabIndex = 6;
            this.btnChiTietDG.Text = "...";
            this.btnChiTietDG.UseVisualStyleBackColor = true;
            this.btnChiTietDG.Click += new System.EventHandler(this.KT_DocGia_Click);
            // 
            // dateTra
            // 
            this.dateTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTra.CustomFormat = "dd/MM/yyyy";
            this.dateTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTra.Location = new System.Drawing.Point(515, 58);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(105, 26);
            this.dateTra.TabIndex = 15;
            // 
            // dateMuon
            // 
            this.dateMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateMuon.CustomFormat = "dd/MM/yyyy";
            this.dateMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMuon.Location = new System.Drawing.Point(515, 29);
            this.dateMuon.Name = "dateMuon";
            this.dateMuon.Size = new System.Drawing.Size(105, 26);
            this.dateMuon.TabIndex = 13;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDocGia.Location = new System.Drawing.Point(169, 93);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(203, 26);
            this.txtMaDocGia.TabIndex = 5;
            this.txtMaDocGia.TextChanged += new System.EventHandler(this.txtMaDocGia_TextChanged);
            // 
            // MaThuThu
            // 
            this.MaThuThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaThuThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MaThuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaThuThu.Location = new System.Drawing.Point(169, 62);
            this.MaThuThu.Name = "MaThuThu";
            this.MaThuThu.Size = new System.Drawing.Size(203, 26);
            this.MaThuThu.TabIndex = 3;
            // 
            // lblMaPhieuMuon
            // 
            this.lblMaPhieuMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuMuon.Location = new System.Drawing.Point(169, 26);
            this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
            this.lblMaPhieuMuon.Size = new System.Drawing.Size(203, 26);
            this.lblMaPhieuMuon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày mượn";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã độc giả";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày trả";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO PHIẾU MƯỢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 46);
            this.panel1.TabIndex = 7;
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 598);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu mượn";
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsDSsachMuon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnChiTietSach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChiTietDG;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.DateTimePicker dateMuon;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label MaThuThu;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblMaDauSach;
    }
}