namespace WindowsFormsApplication1
{
    partial class DonHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.ListView();
            this.MAHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MASP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MANV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYLAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOLUONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.THANHTIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tree = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(-5, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 334);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list);
            this.groupBox3.Controls.Add(this.tree);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(17, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(810, 319);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MAHD,
            this.MASP,
            this.MAKH,
            this.MANV,
            this.NGAYLAP,
            this.SOLUONG,
            this.GIA,
            this.KM,
            this.THANHTIEN});
            this.list.Location = new System.Drawing.Point(206, 22);
            this.list.Margin = new System.Windows.Forms.Padding(2);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(595, 292);
            this.list.TabIndex = 29;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // MAHD
            // 
            this.MAHD.Text = "MAHD";
            this.MAHD.Width = 95;
            // 
            // MASP
            // 
            this.MASP.Text = "MASP";
            this.MASP.Width = 92;
            // 
            // MAKH
            // 
            this.MAKH.Text = "MAKH";
            this.MAKH.Width = 92;
            // 
            // MANV
            // 
            this.MANV.Text = "MANV";
            this.MANV.Width = 83;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Text = "NGAYLAP";
            this.NGAYLAP.Width = 98;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Text = "SOLUONG";
            this.SOLUONG.Width = 92;
            // 
            // GIA
            // 
            this.GIA.Text = "GIA";
            this.GIA.Width = 100;
            // 
            // KM
            // 
            this.KM.Text = "KM";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.Text = "THANHTIEN";
            this.THANHTIEN.Width = 127;
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(5, 20);
            this.tree.Margin = new System.Windows.Forms.Padding(2);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(197, 292);
            this.tree.TabIndex = 28;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hóa Đơn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(701, 388);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 38);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "  Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Brown;
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.pictureBox4.Location = new System.Drawing.Point(712, 396);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // txtHD
            // 
            this.txtHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHD.Location = new System.Drawing.Point(135, 396);
            this.txtHD.Multiline = true;
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(100, 35);
            this.txtHD.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Mã HD cần xóa: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.XOa;
            this.pictureBox2.Location = new System.Drawing.Point(251, 405);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(241, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 32);
            this.btnXoa.TabIndex = 83;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(850, 438);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.DonHang_Load_1);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader MAHD;
        private System.Windows.Forms.ColumnHeader MASP;
        private System.Windows.Forms.ColumnHeader MAKH;
        private System.Windows.Forms.ColumnHeader MANV;
        private System.Windows.Forms.ColumnHeader SOLUONG;
        private System.Windows.Forms.ColumnHeader GIA;
        private System.Windows.Forms.ColumnHeader THANHTIEN;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ColumnHeader NGAYLAP;
        private System.Windows.Forms.ColumnHeader KM;
        private System.Windows.Forms.TextBox txtHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnXoa;
    }
}