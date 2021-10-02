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
    public partial class FormPatientManager : Form
    {
        BUS_Patient busPatient;
        public FormPatientManager()
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
            busPatient.GetAllPatients(gVPatient);
            gVPatient.Columns[0].Width = (int)(gVPatient.Width * 0.1);
            gVPatient.Columns[1].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[2].Width = (int)(gVPatient.Width * 0.1);
            gVPatient.Columns[3].Width = (int)(gVPatient.Width * 0.1);
            gVPatient.Columns[4].Width = (int)(gVPatient.Width * 0.1);
            gVPatient.Columns[5].Width = (int)(gVPatient.Width * 0.15);
            gVPatient.Columns[6].Width = (int)(gVPatient.Width * 0.15);
          
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
                txtEmail.Text = gVPatient.Rows[e.RowIndex].Cells[6].Value.ToString();
              

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm bác sỉ?", "Thêm bệnh nhân", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {

                    Patient d = new Patient();
                    d.FirstName = txtFirstName.Text;
                    d.LastName = txtLastName.Text;
                    d.Phone = txtPhone.Text;
                    d.BirthDate = dateBirth.Value;
                    d.Gender = cbGender.Text;



                    d.ID = int.Parse(txtID.Text);
                    d.Email = txtEmail.Text;

                    if (busPatient.AddPatient(d))
                    {
                        MessageBox.Show("thêm bác sĩ thành công");
                        busPatient.GetAllPatients(gVPatient);
                        gVPatient.Rows[gVPatient.RowCount - 1].Selected = true;
                        gVPatient.CurrentCell = gVPatient.Rows[gVPatient.RowCount - 1].Cells[0];
                    }
                    else MessageBox.Show("Thêm bệnh nhân thất bại");


                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin?", "Chỉnh sửa bệnh nhân", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo())
                {

                    Patient d = new Patient();
                    d.ID = int.Parse(txtID.Text);
                    d.FirstName = txtFirstName.Text;
                    d.LastName = txtLastName.Text;
                    d.Phone = txtPhone.Text;
                    d.BirthDate = dateBirth.Value;
                    d.Gender = cbGender.Text;
                    
                    d.Email = txtEmail.Text;



                    if (busPatient.EditPatient(d))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        busPatient.GetAllPatients(gVPatient);

                    }
                    else MessageBox.Show("Chỉnh sửa thất bại");
                }
                else MessageBox.Show("Hãy nhập đầy đủ");
            }
            else MessageBox.Show("Hãy chắc chắn khi bạn muốn sửa vào lần sau!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa bệnh nhân?", "Xóa bệnh nhân", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtID.Text != "")
                {
                    int id = Int32.Parse(txtID.Text);
                    if (busPatient.DeletePatient(id))
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");
                        busPatient.GetAllPatients(gVPatient);

                    }
                    else MessageBox.Show("Đã có lỗi gì đó");
                }
                else MessageBox.Show("Hãy chọn bệnh nhân muốn xóa");

                //đặt về default
                txtID.Text = "";

            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }


        private bool checkInfo()
        {

            if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || cbGender.Text == ""
                || txtPhone.Text == "" || txtEmail.Text == "")
                return false;
            return true;
        }
    }
}
