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

        }
        private void hideSubmenu()
        {
            if (panelInternalManager.Visible == true)
            {
                panelInternalManager.Visible = false;
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
        private void btnInternalManager_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInternalManager);
        }
        
        private void btnPatientManager_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPatient);
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

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

        }

        private void btnDoctorManagerment_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDoctorManager());
        }
    }
}
