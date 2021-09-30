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
    public partial class FormDoctorManager : Form
    {
        BUS_Medicals busMedicals;
        BUS_Doctor busDoctor;
        public FormDoctorManager()
        {
            InitializeComponent();
            busDoctor = new BUS_Doctor();
            busMedicals = new BUS_Medicals();
        }
        private void FormDoctorManager_Load(object sender, EventArgs e)
        {
            GetAllDoctors();
            busMedicals.GetAllMedical(cBMedical);
            cbGender.Text = "nam";
        }

        private void GetAllDoctors()
        {
            gVDoctor.DataSource = null;
            busDoctor.GetAllDoctors(gVDoctor);
            gVDoctor.Columns[0].Width = (int)(gVDoctor.Width * 0.1);
            gVDoctor.Columns[1].Width = (int)(gVDoctor.Width * 0.15);
            gVDoctor.Columns[2].Width = (int)(gVDoctor.Width * 0.1);
            gVDoctor.Columns[3].Width = (int)(gVDoctor.Width * 0.1);
            gVDoctor.Columns[4].Width = (int)(gVDoctor.Width * 0.1);
            gVDoctor.Columns[5].Width = (int)(gVDoctor.Width * 0.15);
            gVDoctor.Columns[6].Width = (int)(gVDoctor.Width * 0.15);
            gVDoctor.Columns[7].Width = (int)(gVDoctor.Width * 0.15);
        }
        private void gVDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDoctor.Rows.Count)
            {

                txtID.Text = gVDoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = gVDoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = gVDoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateBirth.Value = (DateTime)gVDoctor.Rows[e.RowIndex].Cells[3].Value;
                cbGender.Text = gVDoctor.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = gVDoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtEmail.Text = gVDoctor.Rows[e.RowIndex].Cells[6].Value.ToString();
                cBMedical.Text = gVDoctor.Rows[e.RowIndex].Cells[7].Value.ToString();
                
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin?", "Chỉnh sửa bác sĩ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo())
                {

                    Doctor d = new Doctor();
                    d.ID = int.Parse(txtID.Text);
                    d.FirstName = txtFirstName.Text;
                    d.LastName = txtLastName.Text;
                    d.Phone = txtPhone.Text;
                    d.BirthDate = dateBirth.Value;
                    d.Gender = cbGender.Text;
                    d.MedicalID = int.Parse(cBMedical.SelectedValue.ToString());
                    d.Email = txtEmail.Text;
                    if (busDoctor.EditDoctor(d))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        busDoctor.GetAllDoctors(gVDoctor);
                      
                    }
                    else MessageBox.Show("Chỉnh sửa thất bại");
                }
                else MessageBox.Show("Hãy nhập đầy đủ");
            }
            else MessageBox.Show("Hãy chắc chắn khi bạn muốn sửa vào lần sau!");
        }
        //kiểm tra thông tin trước khi chỉnh sửa
        private bool checkInfo() { 
        
            if (txtID.Text==""|| txtFirstName.Text == "" || txtLastName.Text == "" || cbGender.Text == ""
                || cBMedical.Text == ""||txtPhone.Text==""||txtEmail.Text =="") 
                return false;
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm bác sỉ?", "Thêm bác sỉ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {

                    Doctor d = new Doctor();
                    d.FirstName = txtFirstName.Text;
                    d.LastName = txtLastName.Text;
                    d.Phone = txtPhone.Text;
                    d.BirthDate = dateBirth.Value;
                    d.Gender = cbGender.Text;
                    d.MedicalID = int.Parse(cBMedical.SelectedValue.ToString());
                    d.Email = txtEmail.Text;

                    if (busDoctor.AddDoctor(d))
                    {
                        MessageBox.Show("thêm bác sĩ thành công");
                        busDoctor.GetAllDoctors(gVDoctor);
                        gVDoctor.Rows[gVDoctor.RowCount - 1].Selected = true;
                        gVDoctor.CurrentCell = gVDoctor.Rows[gVDoctor.RowCount - 1].Cells[0];
                    }
                    else MessageBox.Show("Thêm bác sĩ thất bại");
                  

                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa bác sĩ?", "Xóa bác sĩ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtID.Text != "")
                {
                    int id = Int32.Parse(txtID.Text);
                    if (busDoctor.DeleteDoctor(id))
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");
                        busDoctor.GetAllDoctors(gVDoctor);

                    }
                    else MessageBox.Show("Đã có lỗi gì đó");
                }
                else MessageBox.Show("Hãy chọn bác sĩ muốn xóa");

                //đặt về default
                txtID.Text = "";
               
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }
    }
}
