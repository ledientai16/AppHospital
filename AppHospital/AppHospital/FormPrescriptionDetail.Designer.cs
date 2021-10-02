
namespace AppHospital
{
    partial class FormPrescriptionDetail
    {/// <summary>
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
            this.gVDrugDetail = new System.Windows.Forms.DataGridView();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.txtPresID = new System.Windows.Forms.TextBox();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGuide = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddDrug = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDrugID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numQuan = new System.Windows.Forms.NumericUpDown();
            this.cbDrug = new System.Windows.Forms.ComboBox();
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gVDrugDetail)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // gVDrugDetail
            // 
            this.gVDrugDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gVDrugDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVDrugDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVDrugDetail.Location = new System.Drawing.Point(82, 263);
            this.gVDrugDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gVDrugDetail.Name = "gVDrugDetail";
            this.gVDrugDetail.RowHeadersWidth = 62;
            this.gVDrugDetail.RowTemplate.Height = 28;
            this.gVDrugDetail.Size = new System.Drawing.Size(852, 195);
            this.gVDrugDetail.TabIndex = 0;
            this.gVDrugDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVDrugDetail_CellClick);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.txtDoctorId);
            this.groupbox1.Controls.Add(this.txtPresID);
            this.groupbox1.Controls.Add(this.txtPatient);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label9);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Location = new System.Drawing.Point(82, 20);
            this.groupbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox1.Size = new System.Drawing.Size(856, 239);
            this.groupbox1.TabIndex = 4;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Thông tin";
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Enabled = false;
            this.txtDoctorId.Location = new System.Drawing.Point(157, 141);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(140, 26);
            this.txtDoctorId.TabIndex = 39;
            // 
            // txtPresID
            // 
            this.txtPresID.Enabled = false;
            this.txtPresID.Location = new System.Drawing.Point(157, 54);
            this.txtPresID.Name = "txtPresID";
            this.txtPresID.Size = new System.Drawing.Size(140, 26);
            this.txtPresID.TabIndex = 37;
            // 
            // txtPatient
            // 
            this.txtPatient.Enabled = false;
            this.txtPatient.Location = new System.Drawing.Point(157, 100);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(140, 26);
            this.txtPatient.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã Bác Sĩ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mã bệnh nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Toa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGuide);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAddDrug);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDrugID);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numQuan);
            this.groupBox2.Controls.Add(this.cbDrug);
            this.groupBox2.Controls.Add(this.hoTenNhanVienLabel);
            this.groupBox2.Controls.Add(this.ngaySinhLabel);
            this.groupBox2.Location = new System.Drawing.Point(82, 478);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(856, 212);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtGuide
            // 
            this.txtGuide.Location = new System.Drawing.Point(556, 138);
            this.txtGuide.Name = "txtGuide";
            this.txtGuide.Size = new System.Drawing.Size(245, 26);
            this.txtGuide.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Cách dùng";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(226, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 38);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.Location = new System.Drawing.Point(62, 165);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.Size = new System.Drawing.Size(125, 38);
            this.btnAddDrug.TabIndex = 21;
            this.btnAddDrug.Text = "Cập nhập";
            this.btnAddDrug.UseVisualStyleBackColor = true;
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã Thuốc";
            // 
            // txtDrugID
            // 
            this.txtDrugID.Enabled = false;
            this.txtDrugID.Location = new System.Drawing.Point(119, 106);
            this.txtDrugID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.Size = new System.Drawing.Size(326, 26);
            this.txtDrugID.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(577, 86);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(221, 26);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.Text = "Chọn sản phẩm đi!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Đơn giá:";
            // 
            // numQuan
            // 
            this.numQuan.Location = new System.Drawing.Point(577, 49);
            this.numQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQuan.Name = "numQuan";
            this.numQuan.Size = new System.Drawing.Size(92, 26);
            this.numQuan.TabIndex = 14;
            this.numQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbDrug
            // 
            this.cbDrug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrug.FormattingEnabled = true;
            this.cbDrug.Location = new System.Drawing.Point(119, 53);
            this.cbDrug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDrug.Name = "cbDrug";
            this.cbDrug.Size = new System.Drawing.Size(326, 28);
            this.cbDrug.TabIndex = 13;
            this.cbDrug.SelectionChangeCommitted += new System.EventHandler(this.cbDrug_SelectionChangeCommitted);
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(24, 51);
            this.hoTenNhanVienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(84, 20);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Tên Thuốc";
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.AutoSize = true;
            this.ngaySinhLabel.Location = new System.Drawing.Point(475, 51);
            this.ngaySinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(76, 20);
            this.ngaySinhLabel.TabIndex = 4;
            this.ngaySinhLabel.Text = "Số lượng:";
            // 
            // FormPrescriptionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 733);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.gVDrugDetail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrescriptionDetail";
            this.Text = "FormPrescriptionManager";
            this.Load += new System.EventHandler(this.FormPrescriptionDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVDrugDetail)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gVDrugDetail;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TextBox txtPresID;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDrugID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numQuan;
        private System.Windows.Forms.ComboBox cbDrug;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label ngaySinhLabel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddDrug;
        private System.Windows.Forms.TextBox txtGuide;
        private System.Windows.Forms.Label label10;
    }
}