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
    public partial class FormPrescriptionManager : Form
    {
        public int presID;
        public User user;
        private Doctor doctor;
        BUS_Prescription busPrescription;
        BUS_Patient busPatient;
        BUS_Doctor busDoctor;
        public FormPrescriptionManager()
        {
            InitializeComponent();
            busPrescription = new BUS_Prescription();
        }

        private void FormPrescriptionManager_Load(object sender, EventArgs e)
        {
            busDoctor = new BUS_Doctor();
            busPrescription = new BUS_Prescription();
            busPatient = new BUS_Patient();
                doctor = busDoctor.GetDoctorByUser(user.ID);
            GetAllPatient();
        }
        private void GetAllPatient()
        {
            gVPatient.DataSource = null;
            busPatient.GetAllPatients(gVPatient);
            gVPatient.Columns[0].Width = (int)(gVPatient.Width * 0.1);
            gVPatient.Columns[1].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[2].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[3].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[4].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[5].Width = (int)(gVPatient.Width * 0.15);


        }
    
        private void GetAllPrescription()
        {
            gVPre.DataSource = null;
            busPrescription.GetAllPrescription(gVPre,int.Parse(txtPatientID.Text));
            gVPre.Columns[0].Width = (int)(gVPre.Width * 0.1);
            gVPre.Columns[1].Width = (int)(gVPre.Width * 0.1);
            gVPre.Columns[2].Width = (int)(gVPre.Width * 0.2);
            gVPre.Columns[3].Width = (int)(gVPre.Width * 0.1);
            gVPre.Columns[4].Width = (int)(gVPre.Width * 0.2);
            gVPre.Columns[5].Width = (int)(gVPre.Width * 0.1);

        }

        private void gVPre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVPre.Rows.Count)
            {
               
                txtID.Text = gVPre.Rows[e.RowIndex].Cells[0].Value.ToString();
                createdDate.Text = gVPre.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPatientID.Text = gVPre.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDoctorID.Text = gVPre.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiagnosis.Text = gVPre.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateApointment.Value = (DateTime)gVPre.Rows[e.RowIndex].Cells[5].Value;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm thuốc?", "Thêm thuốc", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {

                    Prescription d = new Prescription();
                   
                    d.DoctorID = doctor.ID;
                    d.PatientID = int.Parse(txtPatientID.Text);
                    d.Diagnosis = txtDiagnosis.Text;
                    d.CreatedDate = DateTime.Now;
                    d.Appointment = dateApointment.Value;

                    if (busPrescription.AddPrescription(d))
                    {
                        MessageBox.Show("thêm toa thuốc thành công");
                        GetAllPrescription();
                        gVPre.Rows[gVPre.RowCount - 1].Selected = true;
                        gVPre.CurrentCell = gVPre.Rows[gVPre.RowCount - 1].Cells[0];
                        showPresDetailForm();

                    }
                    else MessageBox.Show("Thêm toa thuốc thất bại");


                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin?", "Chỉnh sửa thuốc", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() && txtID.Text == "")
                {

                    Prescription d = new Prescription();
                    d.ID = int.Parse(txtID.Text);

                    d.Appointment = dateApointment.Value;
                    

                    if (busPrescription.EditPrescription(d))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        GetAllPrescription();
                       
                    }
                    else MessageBox.Show("Chỉnh sửa thất bại");
                }
                else MessageBox.Show("Hãy nhập đầy đủ");
            }
            else MessageBox.Show("Hãy chắc chắn khi bạn muốn sửa vào lần sau!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thuốc?", "Xóa thuốc", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtID.Text != "")
                {
                    int id = Int32.Parse(txtID.Text);
                    if (busPrescription.DeletePrescription(id))
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");
                    
                    }
                    else MessageBox.Show("Đã có lỗi gì đó");
                }
                else MessageBox.Show("Hãy chọn thuốc muốn xóa");

                //đặt về default
                txtID.Text = "";

            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private bool checkInfo()
        {

            if (txtPatientID.Text == "" || txtDiagnosis.Text =="")
                return false;
            return true;
        }

    

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gVPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVPatient.Rows.Count)
            {
                txtPatientID.Text = gVPatient.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDoctorID.Text = "";
                GetAllPrescription();
            }
        }
        private void showPresDetailForm()
        {
            int id = int.Parse(txtID.Text);
            FormPrescriptionDetail f = new FormPrescriptionDetail();
            f.presID = id;
            f.doctorID = int.Parse(txtDoctorID.Text);
            f.patiedID = int.Parse(txtPatientID.Text);
            f.Show();
        }

        

        private void gVPre_DoubleClick(object sender, EventArgs e)
        {
            this.showPresDetailForm();
        }
    }
}
