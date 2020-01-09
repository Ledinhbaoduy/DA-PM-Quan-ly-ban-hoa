namespace WindowsFormsApplication1
{
    partial class FrmThongke
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnXemchitiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rpview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLCHBHDataSet = new WindowsFormsApplication1.QLCHBHDataSet();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new WindowsFormsApplication1.QLCHBHDataSetTableAdapters.HOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemchitiet
            // 
            this.btnXemchitiet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXemchitiet.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnXemchitiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnXemchitiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnXemchitiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXemchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemchitiet.Location = new System.Drawing.Point(434, 62);
            this.btnXemchitiet.Name = "btnXemchitiet";
            this.btnXemchitiet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXemchitiet.Size = new System.Drawing.Size(205, 35);
            this.btnXemchitiet.TabIndex = 2;
            this.btnXemchitiet.Text = "Xem thống kê";
            this.btnXemchitiet.UseVisualStyleBackColor = true;
            this.btnXemchitiet.Click += new System.EventHandler(this.BtnXemchitiet_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 47);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thống kê hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.BackColor = System.Drawing.Color.Brown;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(645, 62);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThoat.Size = new System.Drawing.Size(143, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Brown;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(651, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // rpview
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.HOADONBindingSource;
            this.rpview.LocalReport.DataSources.Add(reportDataSource2);
            this.rpview.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.rpview.Location = new System.Drawing.Point(0, 103);
            this.rpview.Name = "rpview";
            this.rpview.ServerReport.BearerToken = null;
            this.rpview.Size = new System.Drawing.Size(800, 343);
            this.rpview.TabIndex = 30;
            // 
            // QLCHBHDataSet
            // 
            this.QLCHBHDataSet.DataSetName = "QLCHBHDataSet";
            this.QLCHBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.QLCHBHDataSet;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // FrmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.rpview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemchitiet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FrmThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXemchitiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpview;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private QLCHBHDataSet QLCHBHDataSet;
        private QLCHBHDataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
    }
}