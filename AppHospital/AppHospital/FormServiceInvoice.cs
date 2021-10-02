using AppHospital.BUS;
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
    public partial class FormServiceInvoice : Form
    {
        public User user;
        BUS_Patient busPatient;
        public FormServiceInvoice()
        {
            InitializeComponent();
            busPatient = new BUS_Patient();

        }

        private void FormPatientManager_Load(object sender, EventArgs e)
        {

            GetAllPatient();
        }

        private void GetAllPatient()
        {
            gVPatient.DataSource = null;
            busPatient.GetPatients(gVPatient,txtNameFind.Text);
            gVPatient.Columns[0].Width = (int)(gVPatient.Width * 0.1);
            gVPatient.Columns[1].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[2].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[3].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[4].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[5].Width = (int)(gVPatient.Width * 0.15);
         

        }
        private void btnFind_Click(object sender, EventArgs e)
        {

        }
        private void gVPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVPatient.Rows.Count)
            {
                txtID.Enabled = false;
                txtID.Text = gVPatient.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = gVPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = gVPatient.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateBirth.Value = (DateTime)gVPatient.Rows[e.RowIndex].Cells[3].Value;
                cbGender.Text = gVPatient.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = gVPatient.Rows[e.RowIndex].Cells[5].Value.ToString();
               


            }
        }

      

        


        private bool checkInfo()
        {

            if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || cbGender.Text == ""
                || txtPhone.Text == "" )
                return false;
            return true;
        }

    }
}
