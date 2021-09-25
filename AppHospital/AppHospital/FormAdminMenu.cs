using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital
{
    public partial class FormAdminMenu : Form
    {
        public FormAdminMenu()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            panelInternalManager.Visible = false;
            panelPatient.Visible = false;
            panelMoney.Visible = false;

        }
        private void hideSubmenu()
        {
            if (panelInternalManager.Visible == true)
            {
                panelInternalManager.Visible = false;
            }
            if (panelMoney.Visible == true)
            {
                panelMoney.Visible = false;
            }
            if (panelPatient.Visible == true)
            {
                panelPatient.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        //hiện và ẩn sub menu
      

        private void btnPatient_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPatient);
        }
        private void btnInternal_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInternalManager);
        }
        private void btnMoney_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMoney);
        }
        private Form activeForm = null;
        //mở form con
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(activeForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

        }

        //gọi form
        private void btnDoctorManagerment_Click(object sender, EventArgs e)
        {
            labelContent.Text = "Quản Lý Bác Sĩ";
            openChildForm(new FormDoctorManager());
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            labelContent.Text = "Quản Lý Chuyên Khoa";
            openChildForm(new FormMedicalManager());
        }

        private void btnNurseManager_Click(object sender, EventArgs e)
        {
            labelContent.Text = "Quản Lý Y tá";
            openChildForm(new FormNurseManager());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            labelContent.Text = "Quản Lý User";
            openChildForm(new FormUserManager());
        }
    }
}
