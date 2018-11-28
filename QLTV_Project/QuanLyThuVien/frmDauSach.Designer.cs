namespace QuanLyThuVien
{
    partial class frmDauSach
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
            this.btnTimKiemDS = new System.Windows.Forms.Button();
            this.txtTimKiemDS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSDauSach = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiemDS);
            this.panel1.Controls.Add(this.txtTimKiemDS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 44);
            this.panel1.TabIndex = 13;
            // 
            // btnTimKiemDS
            // 
            this.btnTimKiemDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDS.Image = global::QuanLyThuVien.Properties.Resources.search;
            this.btnTimKiemDS.Location = new System.Drawing.Point(425, 2);
            this.btnTimKiemDS.Name = "btnTimKiemDS";
            this.btnTimKiemDS.Size = new System.Drawing.Size(53, 37);
            this.btnTimKiemDS.TabIndex = 2;
            this.btnTimKiemDS.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemDS
            // 
            this.txtTimKiemDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemDS.Location = new System.Drawing.Point(150, 7);
            this.txtTimKiemDS.Name = "txtTimKiemDS";
            this.txtTimKiemDS.Size = new System.Drawing.Size(257, 26);
            this.txtTimKiemDS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSDauSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 373);
            this.panel2.TabIndex = 14;
            // 
            // dgvDSDauSach
            // 
            this.dgvDSDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDauSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvDSDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDauSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDauSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDSDauSach.MultiSelect = false;
            this.dgvDSDauSach.Name = "dgvDSDauSach";
            this.dgvDSDauSach.ReadOnly = true;
            this.dgvDSDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDauSach.ShowEditingIcon = false;
            this.dgvDSDauSach.Size = new System.Drawing.Size(627, 373);
            this.dgvDSDauSach.TabIndex = 0;
            this.dgvDSDauSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDauSach_CellContentClick);
            // 
            // frmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đầu sách";
            this.Load += new System.EventHandler(this.frmDauSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiemDS;
        private System.Windows.Forms.TextBox txtTimKiemDS;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvDSDauSach;
    }
}