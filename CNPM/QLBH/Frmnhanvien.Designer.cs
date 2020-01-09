namespace WindowsFormsApplication1
{
    partial class Frmnhanvien
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
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Controls.Add(this.dgvdanhsach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 435);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnTimkiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnTimkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.Location = new System.Drawing.Point(474, 23);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(106, 30);
            this.btnTimkiem.TabIndex = 27;
            this.btnTimkiem.Text = "Tìm kiếm ";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtTimkiem);
            this.panel11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(92, 23);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(376, 32);
            this.panel11.TabIndex = 26;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(6, 3);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(370, 24);
            this.txtTimkiem.TabIndex = 4;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.TxtTimkiem_TextChanged);
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdanhsach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Location = new System.Drawing.Point(6, 59);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.Size = new System.Drawing.Size(574, 365);
            this.dgvdanhsach.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Brown;
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.pictureBox4.Location = new System.Drawing.Point(491, 508);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(484, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "  Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 45);
            this.label1.TabIndex = 26;
            this.label1.Text = "Danh sách nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(614, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.Frmthongtinnhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
   
        #endregion
    
}