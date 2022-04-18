namespace KiemTra15p
{
    partial class QuanLi
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
            this.dgrQl = new System.Windows.Forms.DataGridView();
            this.btlThem = new System.Windows.Forms.Button();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.txtTD = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTL = new System.Windows.Forms.ComboBox();
            this.btlXoa = new System.Windows.Forms.Button();
            this.btlLuu = new System.Windows.Forms.Button();
            this.btlThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrQl
            // 
            this.dgrQl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrQl.Location = new System.Drawing.Point(0, 302);
            this.dgrQl.Name = "dgrQl";
            this.dgrQl.RowHeadersWidth = 51;
            this.dgrQl.RowTemplate.Height = 24;
            this.dgrQl.Size = new System.Drawing.Size(800, 150);
            this.dgrQl.TabIndex = 0;
            this.dgrQl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrQl_CellClick);
            this.dgrQl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrQl_CellContentClick);
            this.dgrQl.Click += new System.EventHandler(this.dgrQl_Click);
            // 
            // btlThem
            // 
            this.btlThem.Location = new System.Drawing.Point(130, 263);
            this.btlThem.Name = "btlThem";
            this.btlThem.Size = new System.Drawing.Size(75, 23);
            this.btlThem.TabIndex = 1;
            this.btlThem.Text = "Thêm";
            this.btlThem.UseVisualStyleBackColor = true;
            this.btlThem.Click += new System.EventHandler(this.btlThem_Click);
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(212, 54);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(118, 22);
            this.txtMS.TabIndex = 2;
            this.txtMS.TextChanged += new System.EventHandler(this.txtMS_TextChanged);
            // 
            // txtTD
            // 
            this.txtTD.Location = new System.Drawing.Point(212, 119);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(118, 22);
            this.txtTD.TabIndex = 3;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(212, 180);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(118, 22);
            this.txtG.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(625, 60);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(121, 22);
            this.txtSL.TabIndex = 5;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thể Loại";
            // 
            // cbbTL
            // 
            this.cbbTL.FormattingEnabled = true;
            this.cbbTL.Location = new System.Drawing.Point(625, 116);
            this.cbbTL.Name = "cbbTL";
            this.cbbTL.Size = new System.Drawing.Size(121, 24);
            this.cbbTL.TabIndex = 11;
            // 
            // btlXoa
            // 
            this.btlXoa.Location = new System.Drawing.Point(387, 263);
            this.btlXoa.Name = "btlXoa";
            this.btlXoa.Size = new System.Drawing.Size(75, 23);
            this.btlXoa.TabIndex = 12;
            this.btlXoa.Text = "Xóa";
            this.btlXoa.UseVisualStyleBackColor = true;
            this.btlXoa.Click += new System.EventHandler(this.btlXoa_Click);
            // 
            // btlLuu
            // 
            this.btlLuu.Location = new System.Drawing.Point(271, 263);
            this.btlLuu.Name = "btlLuu";
            this.btlLuu.Size = new System.Drawing.Size(75, 23);
            this.btlLuu.TabIndex = 13;
            this.btlLuu.Text = "Lưu";
            this.btlLuu.UseVisualStyleBackColor = true;
            this.btlLuu.Click += new System.EventHandler(this.btlLuu_Click);
            // 
            // btlThoat
            // 
            this.btlThoat.Location = new System.Drawing.Point(504, 263);
            this.btlThoat.Name = "btlThoat";
            this.btlThoat.Size = new System.Drawing.Size(75, 23);
            this.btlThoat.TabIndex = 15;
            this.btlThoat.Text = "Thoát";
            this.btlThoat.UseVisualStyleBackColor = true;
            this.btlThoat.Click += new System.EventHandler(this.btlThoat_Click);
            // 
            // QuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlThoat);
            this.Controls.Add(this.btlLuu);
            this.Controls.Add(this.btlXoa);
            this.Controls.Add(this.cbbTL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtTD);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.btlThem);
            this.Controls.Add(this.dgrQl);
            this.Name = "QuanLi";
            this.Text = "QuanLi";
            this.Load += new System.EventHandler(this.QuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrQl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrQl;
        private System.Windows.Forms.Button btlThem;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.TextBox txtTD;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTL;
        private System.Windows.Forms.Button btlXoa;
        private System.Windows.Forms.Button btlLuu;
        private System.Windows.Forms.Button btlThoat;
    }
}