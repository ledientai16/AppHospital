
namespace AppHospital
{
    partial class FormPrescriptionManager
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
            this.gVPre = new System.Windows.Forms.DataGridView();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.cbBS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBN = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.createdDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVPre)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gVPre
            // 
            this.gVPre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gVPre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gVPre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVPre.Location = new System.Drawing.Point(21, 209);
            this.gVPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gVPre.Name = "gVPre";
            this.gVPre.RowHeadersWidth = 62;
            this.gVPre.RowTemplate.Height = 28;
            this.gVPre.Size = new System.Drawing.Size(881, 314);
            this.gVPre.TabIndex = 0;
            this.gVPre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVPre_CellClick);
            this.gVPre.DoubleClick += new System.EventHandler(this.gVPre_DoubleClick);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.cbBS);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.cbBN);
            this.groupbox1.Controls.Add(this.label9);
            this.groupbox1.Controls.Add(this.createdDate);
            this.groupbox1.Controls.Add(this.label6);
            this.groupbox1.Controls.Add(this.txtID);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Location = new System.Drawing.Point(12, 8);
            this.groupbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox1.Size = new System.Drawing.Size(904, 157);
            this.groupbox1.TabIndex = 4;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Thông tin";
            // 
            // cbBS
            // 
            this.cbBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBS.FormattingEnabled = true;
            this.cbBS.Location = new System.Drawing.Point(156, 91);
            this.cbBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(169, 24);
            this.cbBS.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bác Sĩ";
            // 
            // cbBN
            // 
            this.cbBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBN.FormattingEnabled = true;
            this.cbBN.Location = new System.Drawing.Point(554, 89);
            this.cbBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBN.Name = "cbBN";
            this.cbBN.Size = new System.Drawing.Size(169, 24);
            this.cbBN.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Bệnh Nhân";
            // 
            // createdDate
            // 
            this.createdDate.Location = new System.Drawing.Point(532, 31);
            this.createdDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(296, 22);
            this.createdDate.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngày Tạo";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(153, 41);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 22);
            this.txtID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Toa";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Image = global::AppHospital.Properties.Resources.delete_icon;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(333, 167);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnEdit.Image = global::AppHospital.Properties.Resources.Pencil_icon;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(187, 167);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 38);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Image = global::AppHospital.Properties.Resources.sign_add_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(45, 167);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormPrescriptionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 533);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.gVPre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrescriptionManager";
            this.Text = "FormPrescriptionManager";
            this.Load += new System.EventHandler(this.FormPrescriptionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVPre)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gVPre;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker createdDate;
        private System.Windows.Forms.ComboBox cbBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBN;
        private System.Windows.Forms.Label label9;
    }
}


