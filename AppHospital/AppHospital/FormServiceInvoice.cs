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
        private Nurse nurse;
        BUS_Patient busPatient;
        BUS_ServiceInvoice busServiceInvoice;
        BUS_Service busService;
       
        public FormServiceInvoice()
        {
            InitializeComponent();
            busPatient = new BUS_Patient();
            busService = new BUS_Service();
            busServiceInvoice = new BUS_ServiceInvoice();
           
        }

        private void FormPatientManager_Load(object sender, EventArgs e)
        {

            GetAllPatient();
            busService.GetAllService(cbService);
            nurse = user.Nurses.FirstOrDefault();
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
        public void GetAllServiceInvoice()
        {
            gvSvInvoices.DataSource = null;
            busServiceInvoice.getServiceInvoice(gvSvInvoices, int.Parse(txtID.Text));
            gvSvInvoices.Columns[0].Width = (int)(gVPatient.Width * 0.1);
            gvSvInvoices.Columns[1].Width = (int)(gVPatient.Width * 0.1);
            gvSvInvoices.Columns[2].Width = (int)(gVPatient.Width * 0.1);
            gvSvInvoices.Columns[3].Width = (int)(gVPatient.Width * 0.1);
          
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            GetAllPatient();
            
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
                GetAllServiceInvoice();


            }
        }

      

        


        private bool checkInfo()
        {

            if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || cbGender.Text == ""
                || txtPhone.Text == "" )
                return false;
            return true;
        }

        private void cbService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowInfoServiceID(int.Parse(cbService.SelectedValue.ToString()));
        }

        private void ShowInfoServiceID(int id)
        {
            Service s;
            s = busService.GetServiceByID(id);
         
            cbService.Text = s.Name;
            txtFee.Text = s.Fee.ToString();
        }

        private void gvSvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0 && e.RowIndex < gvSvInvoices.Rows.Count)
            {
                
                txtInvoiceID.Text = gvSvInvoices.Rows[e.RowIndex].Cells[0].Value.ToString();
               
                txtNurseID.Text = gvSvInvoices.Rows[e.RowIndex].Cells[1].Value.ToString();
                ShowInfoServiceID(int.Parse(gvSvInvoices.Rows[e.RowIndex].Cells[2].Value.ToString()));

                txtPhone.Text = gvSvInvoices.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateCreated.Value = (DateTime)gvSvInvoices.Rows[e.RowIndex].Cells[4].Value;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhập lập hóa đơn?", "lập hóa đơn", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {

                    ServiceInvoice s = new ServiceInvoice();
                    s.NurseID = this.nurse.ID;
                    s.PatientID = int.Parse(txtID.Text);
                    s.ServiceID = (int?)cbService.SelectedValue;
                    s.Fee = decimal.Parse(txtFee.Text);
                    s.CreatedDate = DateTime.Now;
                   
                    if (busServiceInvoice.Create(s))
                    {
                        MessageBox.Show("lập hóa đơn thành công");
                        GetAllServiceInvoice();
                    }
                    else MessageBox.Show("Lập hóa đơn thất bại");


                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        
    }
}
