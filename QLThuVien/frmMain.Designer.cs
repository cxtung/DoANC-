namespace QLThuVien
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnQLMuon_Tra = new System.Windows.Forms.Button();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.btnQLDocGia = new System.Windows.Forms.Button();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnQLMuon_Tra);
            this.groupBox1.Controls.Add(this.btnQLSach);
            this.groupBox1.Controls.Add(this.btnQLDocGia);
            this.groupBox1.Controls.Add(this.btnThemDocGia);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(27, 439);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 52);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnQLMuon_Tra
            // 
            this.btnQLMuon_Tra.Location = new System.Drawing.Point(27, 289);
            this.btnQLMuon_Tra.Name = "btnQLMuon_Tra";
            this.btnQLMuon_Tra.Size = new System.Drawing.Size(156, 52);
            this.btnQLMuon_Tra.TabIndex = 4;
            this.btnQLMuon_Tra.Text = "Quản lí mượn-trả";
            this.btnQLMuon_Tra.UseVisualStyleBackColor = true;
            this.btnQLMuon_Tra.Click += new System.EventHandler(this.btnQLMuon_Tra_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.Location = new System.Drawing.Point(27, 205);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Size = new System.Drawing.Size(156, 52);
            this.btnQLSach.TabIndex = 3;
            this.btnQLSach.Text = "Quản lí Sách";
            this.btnQLSach.UseVisualStyleBackColor = true;
            this.btnQLSach.Click += new System.EventHandler(this.btnQLSach_Click);
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.Location = new System.Drawing.Point(27, 132);
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.Size = new System.Drawing.Size(156, 52);
            this.btnQLDocGia.TabIndex = 2;
            this.btnQLDocGia.Text = "Quản lí độc giả";
            this.btnQLDocGia.UseVisualStyleBackColor = true;
            this.btnQLDocGia.Click += new System.EventHandler(this.btnQLDocGia_Click);
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Location = new System.Drawing.Point(27, 56);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(156, 52);
            this.btnThemDocGia.TabIndex = 1;
            this.btnThemDocGia.Text = "Thêm độc giả";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÍ THƯ VIỆN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(261, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 636);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(881, 592);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 737);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQLMuon_Tra;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.Button btnQLDocGia;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}