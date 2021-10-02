
namespace AppHospital
{
    partial class FormAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.btnPres = new System.Windows.Forms.Button();
            this.btnPantient = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.panelMoney = new System.Windows.Forms.Panel();
            this.btnServiceInvoice = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.panelInternalManager = new System.Windows.Forms.Panel();
            this.btnDrug = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnNurseManager = new System.Windows.Forms.Button();
            this.btnDoctorManagerment = new System.Windows.Forms.Button();
            this.btnMedical = new System.Windows.Forms.Button();
            this.btnInternal = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnHiddenMenu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelPatient.SuspendLayout();
            this.panelMoney.SuspendLayout();
            this.panelInternalManager.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(198)))));
            this.panelMenu.Controls.Add(this.panelPatient);
            this.panelMenu.Controls.Add(this.btnPatient);
            this.panelMenu.Controls.Add(this.panelMoney);
            this.panelMenu.Controls.Add(this.btnMoney);
            this.panelMenu.Controls.Add(this.panelInternalManager);
            this.panelMenu.Controls.Add(this.btnInternal);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(297, 976);
            this.panelMenu.TabIndex = 0;
            // 
            // panelPatient
            // 
            this.panelPatient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelPatient.Controls.Add(this.btnPres);
            this.panelPatient.Controls.Add(this.btnPantient);
            this.panelPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPatient.Location = new System.Drawing.Point(0, 933);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(271, 210);
            this.panelPatient.TabIndex = 8;
            // 
            // btnPres
            // 
            this.btnPres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPres.Location = new System.Drawing.Point(0, 40);
            this.btnPres.Name = "btnPres";
            this.btnPres.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPres.Size = new System.Drawing.Size(271, 40);
            this.btnPres.TabIndex = 1;
            this.btnPres.Text = "Lập toa thuốc";
            this.btnPres.UseVisualStyleBackColor = true;
            this.btnPres.Click += new System.EventHandler(this.btnPres_Click);
            // 
            // btnPantient
            // 
            this.btnPantient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPantient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPantient.Location = new System.Drawing.Point(0, 0);
            this.btnPantient.Name = "btnPantient";
            this.btnPantient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPantient.Size = new System.Drawing.Size(271, 40);
            this.btnPantient.TabIndex = 0;
            this.btnPantient.Text = "Danh sách bệnh nhân";
            this.btnPantient.UseVisualStyleBackColor = true;
            this.btnPantient.Click += new System.EventHandler(this.btnPantient_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(198)))));
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatient.Image = global::AppHospital.Properties.Resources.medical;
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.Location = new System.Drawing.Point(0, 815);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPatient.Size = new System.Drawing.Size(271, 118);
            this.btnPatient.TabIndex = 7;
            this.btnPatient.Text = "Quản lý bệnh nhân";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // panelMoney
            // 
            this.panelMoney.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMoney.Controls.Add(this.btnServiceInvoice);
            this.panelMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMoney.Location = new System.Drawing.Point(0, 658);
            this.panelMoney.Name = "panelMoney";
            this.panelMoney.Size = new System.Drawing.Size(271, 157);
            this.panelMoney.TabIndex = 6;
            // 
            // btnServiceInvoice
            // 
            this.btnServiceInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceInvoice.Location = new System.Drawing.Point(0, 0);
            this.btnServiceInvoice.Name = "btnServiceInvoice";
            this.btnServiceInvoice.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnServiceInvoice.Size = new System.Drawing.Size(271, 40);
            this.btnServiceInvoice.TabIndex = 0;
            this.btnServiceInvoice.Text = "Hóa Đơn Dịch vụ";
            this.btnServiceInvoice.UseVisualStyleBackColor = true;
            this.btnServiceInvoice.Click += new System.EventHandler(this.btnServiceInvoice_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(198)))));
            this.btnMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoney.FlatAppearance.BorderSize = 0;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoney.Image = global::AppHospital.Properties.Resources.internet_currency;
            this.btnMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.Location = new System.Drawing.Point(0, 540);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMoney.Size = new System.Drawing.Size(271, 118);
            this.btnMoney.TabIndex = 5;
            this.btnMoney.Text = "Quản lý thu chi";
            this.btnMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // panelInternalManager
            // 
            this.panelInternalManager.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelInternalManager.Controls.Add(this.btnDrug);
            this.panelInternalManager.Controls.Add(this.btnService);
            this.panelInternalManager.Controls.Add(this.btnUser);
            this.panelInternalManager.Controls.Add(this.btnNurseManager);
            this.panelInternalManager.Controls.Add(this.btnDoctorManagerment);
            this.panelInternalManager.Controls.Add(this.btnMedical);
            this.panelInternalManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInternalManager.Location = new System.Drawing.Point(0, 249);
            this.panelInternalManager.Name = "panelInternalManager";
            this.panelInternalManager.Size = new System.Drawing.Size(271, 291);
            this.panelInternalManager.TabIndex = 3;
            // 
            // btnDrug
            // 
            this.btnDrug.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDrug.Location = new System.Drawing.Point(0, 200);
            this.btnDrug.Name = "btnDrug";
            this.btnDrug.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDrug.Size = new System.Drawing.Size(271, 40);
            this.btnDrug.TabIndex = 5;
            this.btnDrug.Text = "Quản lý thuốc";
            this.btnDrug.UseVisualStyleBackColor = true;
            this.btnDrug.Click += new System.EventHandler(this.btnDrug_Click);
            // 
            // btnService
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnService.Location = new System.Drawing.Point(0, 160);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnService.Size = new System.Drawing.Size(271, 40);
            this.btnService.TabIndex = 4;
            this.btnService.Text = "Quản lý dịch vụ";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUser.Location = new System.Drawing.Point(0, 120);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(271, 40);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Quản lý user";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnNurseManager
            // 
            this.btnNurseManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNurseManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNurseManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNurseManager.Location = new System.Drawing.Point(0, 80);
            this.btnNurseManager.Name = "btnNurseManager";
            this.btnNurseManager.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNurseManager.Size = new System.Drawing.Size(271, 40);
            this.btnNurseManager.TabIndex = 2;
            this.btnNurseManager.Text = "Quản lý y tá";
            this.btnNurseManager.UseVisualStyleBackColor = true;
            this.btnNurseManager.Click += new System.EventHandler(this.btnNurseManager_Click);
            // 
            // btnDoctorManagerment
            // 
            this.btnDoctorManagerment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorManagerment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorManagerment.ForeColor = System.Drawing.Color.White;
            this.btnDoctorManagerment.Location = new System.Drawing.Point(0, 40);
            this.btnDoctorManagerment.Name = "btnDoctorManagerment";
            this.btnDoctorManagerment.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDoctorManagerment.Size = new System.Drawing.Size(271, 40);
            this.btnDoctorManagerment.TabIndex = 1;
            this.btnDoctorManagerment.Text = "Quản lý bác sĩ";
            this.btnDoctorManagerment.UseVisualStyleBackColor = true;
            this.btnDoctorManagerment.Click += new System.EventHandler(this.btnDoctorManagerment_Click);
            // 
            // btnMedical
            // 
            this.btnMedical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedical.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMedical.Location = new System.Drawing.Point(0, 0);
            this.btnMedical.Name = "btnMedical";
            this.btnMedical.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMedical.Size = new System.Drawing.Size(271, 40);
            this.btnMedical.TabIndex = 0;
            this.btnMedical.Text = "Quản lý chuyên khoa";
            this.btnMedical.UseVisualStyleBackColor = true;
            this.btnMedical.Click += new System.EventHandler(this.btnMedical_Click);
            // 
            // btnInternal
            // 
            this.btnInternal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(198)))));
            this.btnInternal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInternal.FlatAppearance.BorderSize = 0;
            this.btnInternal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInternal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInternal.Image = global::AppHospital.Properties.Resources.division;
            this.btnInternal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternal.Location = new System.Drawing.Point(0, 145);
            this.btnInternal.Name = "btnInternal";
            this.btnInternal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInternal.Size = new System.Drawing.Size(271, 104);
            this.btnInternal.TabIndex = 0;
            this.btnInternal.Text = "Quản lý nội bộ";
            this.btnInternal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInternal.UseVisualStyleBackColor = false;
            this.btnInternal.Click += new System.EventHandler(this.btnInternal_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.LightBlue;
            this.panelLogo.Controls.Add(this.button8);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.Username);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(271, 145);
            this.panelLogo.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Image = global::AppHospital.Properties.Resources.logout__1_;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 91);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 54);
            this.button8.TabIndex = 4;
            this.button8.Text = "Đăng xuất";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(103, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(103, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(80, 20);
            this.Username.TabIndex = 1;
            this.Username.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppHospital.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.btnHiddenMenu);
            this.panelChildForm.Controls.Add(this.label4);
            this.panelChildForm.Controls.Add(this.label3);
            this.panelChildForm.Controls.Add(this.labelContent);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(297, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(785, 976);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // btnHiddenMenu
            // 
            this.btnHiddenMenu.Image = global::AppHospital.Properties.Resources.left_alignment;
            this.btnHiddenMenu.Location = new System.Drawing.Point(0, 0);
            this.btnHiddenMenu.Name = "btnHiddenMenu";
            this.btnHiddenMenu.Size = new System.Drawing.Size(85, 63);
            this.btnHiddenMenu.TabIndex = 3;
            this.btnHiddenMenu.UseVisualStyleBackColor = true;
            this.btnHiddenMenu.Click += new System.EventHandler(this.btnHiddenMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(553, 300);
            this.label4.TabIndex = 2;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            // 
            // labelContent
            // 
            this.labelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(198)))));
            this.labelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelContent.Location = new System.Drawing.Point(0, 0);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(785, 66);
            this.labelContent.TabIndex = 0;
            this.labelContent.Text = "Phòng Khám DTT";
            this.labelContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 976);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1093, 1032);
            this.Name = "FormAdminMenu";
            this.Text = "FormAdminMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelPatient.ResumeLayout(false);
            this.panelMoney.ResumeLayout(false);
            this.panelInternalManager.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInternal;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelInternalManager;
        private System.Windows.Forms.Button btnNurseManager;
        private System.Windows.Forms.Button btnDoctorManagerment;
        private System.Windows.Forms.Button btnMedical;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Panel panelMoney;
        private System.Windows.Forms.Button btnServiceInvoice;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Button btnPres;
        private System.Windows.Forms.Button btnPantient;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDrug;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnHiddenMenu;
    }
}