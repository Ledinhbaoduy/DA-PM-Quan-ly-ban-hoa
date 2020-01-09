namespace WindowsFormsApplication1
{
    partial class FrmKhuyenmai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHinhthuc = new System.Windows.Forms.TextBox();
            this.dtpNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa_KM = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.btnXEm = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 204);
            this.panel1.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHinhthuc);
            this.groupBox1.Controls.Add(this.dtpNgayketthuc);
            this.groupBox1.Controls.Add(this.dtpNgaybatdau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa_KM);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtHinhthuc
            // 
            this.txtHinhthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHinhthuc.Location = new System.Drawing.Point(151, 76);
            this.txtHinhthuc.Multiline = true;
            this.txtHinhthuc.Name = "txtHinhthuc";
            this.txtHinhthuc.Size = new System.Drawing.Size(214, 22);
            this.txtHinhthuc.TabIndex = 2;
            // 
            // dtpNgayketthuc
            // 
            this.dtpNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayketthuc.Location = new System.Drawing.Point(151, 158);
            this.dtpNgayketthuc.Name = "dtpNgayketthuc";
            this.dtpNgayketthuc.Size = new System.Drawing.Size(214, 22);
            this.dtpNgayketthuc.TabIndex = 4;
            this.dtpNgayketthuc.Value = new System.DateTime(2019, 5, 15, 0, 0, 0, 0);
            // 
            // dtpNgaybatdau
            // 
            this.dtpNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybatdau.Location = new System.Drawing.Point(151, 117);
            this.dtpNgaybatdau.Name = "dtpNgaybatdau";
            this.dtpNgaybatdau.Size = new System.Drawing.Size(214, 22);
            this.dtpNgaybatdau.TabIndex = 3;
            this.dtpNgaybatdau.Value = new System.DateTime(2019, 5, 15, 0, 0, 0, 0);
            this.dtpNgaybatdau.ValueChanged += new System.EventHandler(this.DtpNgaybatdau_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // txtMa_KM
            // 
            this.txtMa_KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMa_KM.Location = new System.Drawing.Point(151, 39);
            this.txtMa_KM.Multiline = true;
            this.txtMa_KM.Name = "txtMa_KM";
            this.txtMa_KM.Size = new System.Drawing.Size(214, 22);
            this.txtMa_KM.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.Location = new System.Drawing.Point(14, 82);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(71, 16);
            this.lblTen.TabIndex = 10;
            this.lblTen.Text = "Hình thức";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã khuyễn mãi";
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(546, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 44);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnthem
            // 
            this.btnthem.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(546, 64);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(142, 43);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "    Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.Btnthem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.zô;
            this.pictureBox1.Location = new System.Drawing.Point(555, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.sua1;
            this.pictureBox3.Location = new System.Drawing.Point(556, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 49);
            this.panel3.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(5, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Khuyến Mãi";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Brown;
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.pictureBox4.Location = new System.Drawing.Point(559, 371);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 239);
            this.panel2.TabIndex = 72;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvdanhsach);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(10, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 231);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khuyến mãi";
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.BackgroundColor = System.Drawing.Color.White;
            this.dgvdanhsach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Location = new System.Drawing.Point(9, 21);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.Size = new System.Drawing.Size(480, 196);
            this.dgvdanhsach.TabIndex = 1;
            this.dgvdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvdanhsach_CellContentClick);
            // 
            // btnXEm
            // 
            this.btnXEm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnXEm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnXEm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnXEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXEm.Location = new System.Drawing.Point(546, 242);
            this.btnXEm.Name = "btnXEm";
            this.btnXEm.Size = new System.Drawing.Size(142, 42);
            this.btnXEm.TabIndex = 8;
            this.btnXEm.Text = "Xem thông tin";
            this.btnXEm.UseVisualStyleBackColor = true;
            this.btnXEm.Click += new System.EventHandler(this.BtnXEm_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(546, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 41);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "  Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox5.Image = global::WindowsFormsApplication1.Properties.Resources.luu;
            this.pictureBox5.Location = new System.Drawing.Point(553, 306);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 76;
            this.pictureBox5.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(546, 302);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 41);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "  Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(546, 123);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 44);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.XOa;
            this.pictureBox2.Location = new System.Drawing.Point(555, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // FrmKhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(707, 512);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXEm);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnthem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhuyenmai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhuyenmai";
            this.Load += new System.EventHandler(this.FrmKhuyenmai_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMa_KM;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.Button btnXEm;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtpNgayketthuc;
        private System.Windows.Forms.DateTimePicker dtpNgaybatdau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtHinhthuc;
    }
}