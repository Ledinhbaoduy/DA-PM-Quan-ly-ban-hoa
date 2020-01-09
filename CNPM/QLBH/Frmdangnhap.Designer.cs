namespace WindowsFormsApplication1
{
    partial class Frmdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdangnhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.lblTendangnhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTendangnhap);
            this.panel1.Controls.Add(this.lblTendangnhap);
            this.panel1.Location = new System.Drawing.Point(171, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 33);
            this.panel1.TabIndex = 0;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendangnhap.Location = new System.Drawing.Point(131, 3);
            this.txtTendangnhap.Multiline = true;
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(176, 24);
            this.txtTendangnhap.TabIndex = 1;
            this.txtTendangnhap.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblTendangnhap
            // 
            this.lblTendangnhap.AutoSize = true;
            this.lblTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendangnhap.Location = new System.Drawing.Point(13, 7);
            this.lblTendangnhap.Name = "lblTendangnhap";
            this.lblTendangnhap.Size = new System.Drawing.Size(112, 16);
            this.lblTendangnhap.TabIndex = 0;
            this.lblTendangnhap.Text = "Tên đăng nhập";
            this.lblTendangnhap.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMatkhau);
            this.panel2.Controls.Add(this.lblMatkhau);
            this.panel2.Location = new System.Drawing.Point(171, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 30);
            this.panel2.TabIndex = 2;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(131, 3);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(176, 26);
            this.txtMatkhau.TabIndex = 1;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(13, 8);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(70, 16);
            this.lblMatkhau.TabIndex = 0;
            this.lblMatkhau.Text = "Mật khẩu";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(359, 93);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btndangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btndangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(224, 92);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(129, 33);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "      Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.Btndangnhap_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Brown;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(370, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox5.Image = global::WindowsFormsApplication1.Properties.Resources.thoat;
            this.pictureBox5.Location = new System.Drawing.Point(229, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Frmdangnhap
            // 
            this.AcceptButton = this.btndangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(501, 133);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTendangnhap;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}