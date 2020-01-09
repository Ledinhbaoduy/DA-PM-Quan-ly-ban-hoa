namespace WindowsFormsApplication1
{
    partial class FrmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLCHBHDataSet = new WindowsFormsApplication1.QLCHBHDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOADONTableAdapter = new WindowsFormsApplication1.QLCHBHDataSetTableAdapters.HOADONTableAdapter();
            this.btnNgay = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.QLCHBHDataSet;
            // 
            // QLCHBHDataSet
            // 
            this.QLCHBHDataSet.DataSetName = "QLCHBHDataSet";
            this.QLCHBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(642, 426);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // btnNgay
            // 
            this.btnNgay.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNgay.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNgay.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            this.btnNgay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnNgay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnNgay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgay.Location = new System.Drawing.Point(702, 136);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(171, 32);
            this.btnNgay.TabIndex = 1;
            this.btnNgay.Text = "Theo ngày";
            this.btnNgay.UseVisualStyleBackColor = false;
            this.btnNgay.Click += new System.EventHandler(this.BtnNgay_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(702, 350);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpNgay.TabIndex = 2;
            this.dtpNgay.Value = new System.DateTime(2019, 5, 19, 0, 0, 0, 0);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThang.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnThang.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            this.btnThang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnThang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThang.Location = new System.Drawing.Point(702, 186);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(171, 32);
            this.btnThang.TabIndex = 3;
            this.btnThang.Text = "Theo tháng";
            this.btnThang.UseVisualStyleBackColor = false;
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNam.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNam.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            this.btnNam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnNam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnNam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Location = new System.Drawing.Point(702, 238);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(171, 32);
            this.btnNam.TabIndex = 4;
            this.btnNam.Text = "Theo năm";
            this.btnNam.UseVisualStyleBackColor = false;
            // 
            // btnHoadon
            // 
            this.btnHoadon.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHoadon.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnHoadon.FlatAppearance.CheckedBackColor = System.Drawing.Color.AliceBlue;
            this.btnHoadon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnHoadon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.Location = new System.Drawing.Point(702, 292);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(171, 32);
            this.btnHoadon.TabIndex = 5;
            this.btnHoadon.Text = "Theo hóa đơn";
            this.btnHoadon.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(919, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(919, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHoadon);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnThang);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.btnNgay);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReport";
            this.Text = "Report thống kê";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLCHBHDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private QLCHBHDataSet QLCHBHDataSet;
        private QLCHBHDataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Label label1;
    }
}