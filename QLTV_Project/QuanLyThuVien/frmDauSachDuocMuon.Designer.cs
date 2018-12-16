namespace QuanLyThuVien
{
    partial class frmDauSachDuocMuon
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimSachMuon = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.cbxMucTim = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 50);
            this.panel3.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxMucTim);
            this.groupBox3.Controls.Add(this.txtTimSachMuon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(710, 50);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtTimSachMuon
            // 
            this.txtTimSachMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimSachMuon.Location = new System.Drawing.Point(281, 21);
            this.txtTimSachMuon.Name = "txtTimSachMuon";
            this.txtTimSachMuon.Size = new System.Drawing.Size(299, 20);
            this.txtTimSachMuon.TabIndex = 0;
            this.txtTimSachMuon.TextChanged += new System.EventHandler(this.txtTimSachMuon_TextChanged);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.groupBox6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 50);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(710, 287);
            this.panel14.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvDSSach);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(710, 287);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách sách";
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSach.Location = new System.Drawing.Point(3, 16);
            this.dgvDSSach.MultiSelect = false;
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.ReadOnly = true;
            this.dgvDSSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSach.Size = new System.Drawing.Size(704, 268);
            this.dgvDSSach.TabIndex = 0;
            this.dgvDSSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSach_CellContentClick);
            // 
            // cbxMucTim
            // 
            this.cbxMucTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMucTim.FormattingEnabled = true;
            this.cbxMucTim.Location = new System.Drawing.Point(145, 20);
            this.cbxMucTim.Name = "cbxMucTim";
            this.cbxMucTim.Size = new System.Drawing.Size(130, 21);
            this.cbxMucTim.TabIndex = 1;
            // 
            // frmDauSachDuocMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 337);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel3);
            this.Name = "frmDauSachDuocMuon";
            this.Text = "Danh sách đầu sách";
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimSachMuon;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.ComboBox cbxMucTim;
    }
}