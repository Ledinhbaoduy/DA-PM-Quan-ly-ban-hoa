namespace WindowsFormsApplication1
{
    partial class Frmthungan
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.radTT = new System.Windows.Forms.RadioButton();
            this.radVL = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiSp = new System.Windows.Forms.ComboBox();
            this.dgvDanhsachSP = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(798, 489);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(175, 49);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 26);
            this.label3.TabIndex = 133;
            this.label3.Text = "Số lượng sản phẩm";
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(15, 34);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.Size = new System.Drawing.Size(420, 284);
            this.dgvHoadon.TabIndex = 136;
            this.dgvHoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHoadon_CellContentClick);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(675, 492);
            this.txtSL.Multiline = true;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(104, 46);
            this.txtSL.TabIndex = 2;
            this.txtSL.Text = "1";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(18, 33);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(258, 29);
            this.txtTongTien.TabIndex = 139;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 83);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thành tiền";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.tính_tien;
            this.pictureBox1.Location = new System.Drawing.Point(292, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboKH);
            this.groupBox2.Controls.Add(this.radTT);
            this.groupBox2.Controls.Add(this.radVL);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Người mua";
            // 
            // cboKH
            // 
            this.cboKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(235, 36);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(128, 28);
            this.cboKH.TabIndex = 4;
            this.cboKH.SelectedIndexChanged += new System.EventHandler(this.CboKH_SelectedIndexChanged);
            // 
            // radTT
            // 
            this.radTT.AutoSize = true;
            this.radTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTT.Location = new System.Drawing.Point(110, 37);
            this.radTT.Name = "radTT";
            this.radTT.Size = new System.Drawing.Size(98, 24);
            this.radTT.TabIndex = 4;
            this.radTT.TabStop = true;
            this.radTT.Text = "Thân thiết";
            this.radTT.UseVisualStyleBackColor = true;
            this.radTT.CheckedChanged += new System.EventHandler(this.RadTT_CheckedChanged);
            // 
            // radVL
            // 
            this.radVL.AutoSize = true;
            this.radVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVL.Location = new System.Drawing.Point(20, 37);
            this.radVL.Name = "radVL";
            this.radVL.Size = new System.Drawing.Size(84, 24);
            this.radVL.TabIndex = 4;
            this.radVL.TabStop = true;
            this.radVL.Text = "Vãng lai";
            this.radVL.UseVisualStyleBackColor = true;
            this.radVL.CheckedChanged += new System.EventHandler(this.RadVL_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 26);
            this.label4.TabIndex = 135;
            this.label4.Text = "Loại sản phẩm";
            // 
            // cboLoaiSp
            // 
            this.cboLoaiSp.BackColor = System.Drawing.Color.White;
            this.cboLoaiSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiSp.FormattingEnabled = true;
            this.cboLoaiSp.Location = new System.Drawing.Point(643, 92);
            this.cboLoaiSp.Name = "cboLoaiSp";
            this.cboLoaiSp.Size = new System.Drawing.Size(191, 28);
            this.cboLoaiSp.TabIndex = 1;
            this.cboLoaiSp.SelectedIndexChanged += new System.EventHandler(this.CboLoaiSp_SelectedIndexChanged);
            // 
            // dgvDanhsachSP
            // 
            this.dgvDanhsachSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhsachSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhsachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachSP.Location = new System.Drawing.Point(8, 34);
            this.dgvDanhsachSP.Name = "dgvDanhsachSP";
            this.dgvDanhsachSP.Size = new System.Drawing.Size(509, 252);
            this.dgvDanhsachSP.TabIndex = 137;
            this.dgvDanhsachSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhsachSP_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHoadon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 324);
            this.groupBox3.TabIndex = 142;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDanhsachSP);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(456, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 292);
            this.groupBox4.TabIndex = 143;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin sản phẩm";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(814, 620);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 49);
            this.btnThoat.TabIndex = 145;
            this.btnThoat.Text = "    Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(271, 620);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 49);
            this.btnXoa.TabIndex = 147;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnlammoi.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnlammoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnlammoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Location = new System.Drawing.Point(436, 620);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(178, 49);
            this.btnlammoi.TabIndex = 149;
            this.btnlammoi.Text = "      Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.Btnlammoi_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXacnhan.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnXacnhan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnXacnhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.Location = new System.Drawing.Point(620, 620);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(188, 49);
            this.btnXacnhan.TabIndex = 151;
            this.btnXacnhan.Text = "    Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.BtnXacnhan_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.XOa;
            this.pictureBox4.Location = new System.Drawing.Point(282, 627);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 153;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApplication1.Properties.Resources.xacnhan;
            this.pictureBox6.Location = new System.Drawing.Point(625, 627);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 152;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApplication1.Properties.Resources.lammoi;
            this.pictureBox5.Location = new System.Drawing.Point(444, 627);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 150;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Brown;
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.thoat;
            this.pictureBox3.Location = new System.Drawing.Point(823, 627);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 146;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.zô;
            this.pictureBox2.Location = new System.Drawing.Point(812, 494);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 144;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(997, 56);
            this.label1.TabIndex = 154;
            this.label1.Text = "Thu ngân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frmthungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(997, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboLoaiSp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmthungan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu ngân";
            this.Load += new System.EventHandler(this.Frmthungan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachSP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radTT;
        private System.Windows.Forms.RadioButton radVL;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiSp;
        private System.Windows.Forms.DataGridView dgvDanhsachSP;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}