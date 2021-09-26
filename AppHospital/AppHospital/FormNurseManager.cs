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
    public partial class FormNurseManager : Form
    {
        BUS_Medicals busMedicals;
        BUS_Nurse busNurse;

        public FormNurseManager()
        {
            InitializeComponent();
            busMedicals = new BUS_Medicals();
            busNurse = new BUS_Nurse();

        }

        private void FormNurseManager_Load(object sender, EventArgs e)
        {
            cbGender.Items.AddRange(new String[] { "nam", "nữ" });
            busMedicals.GetAllMedical(cBMedical);
            busNurse.GetAllNurse(gVNurse);

        }
        private void GetAllNurse()
        {
            gVNurse.DataSource = null;
            busNurse.GetAllNurse(gVNurse);
            gVNurse.Columns[0].Width = (int)(gVNurse.Width * 0.1);
            gVNurse.Columns[1].Width = (int)(gVNurse.Width * 0.15);
            gVNurse.Columns[2].Width = (int)(gVNurse.Width * 0.1);
            gVNurse.Columns[3].Width = (int)(gVNurse.Width * 0.1);
            gVNurse.Columns[4].Width = (int)(gVNurse.Width * 0.1);
            gVNurse.Columns[5].Width = (int)(gVNurse.Width * 0.15);
            gVNurse.Columns[6].Width = (int)(gVNurse.Width * 0.15);
            gVNurse.Columns[7].Width = (int)(gVNurse.Width * 0.15);
        }
        private bool checkInfo()
        {

            if (txtFirstName.Text == "" || txtLastName.Text == "" || cbGender.Text == ""
                || cBMedical.Text == "")
                return false;
            return true;
        }
        private void gVNurse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVNurse.Rows.Count)
            {
                txtID.Text = gVNurse.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = gVNurse.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = gVNurse.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateBirth.Value = (DateTime)gVNurse.Rows[e.RowIndex].Cells[3].Value;
                cbGender.Text = gVNurse.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = gVNurse.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtEmail.Text = gVNurse.Rows[e.RowIndex].Cells[6].Value.ToString();
                cBMedical.Text = gVNurse.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin?", "Chỉnh sửa Y ta", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo())
                {
                    Nurse n = new Nurse();
                    n.ID = int.Parse(txtID.Text);
                    n.FirstName = txtFirstName.Text;
                    n.LastName = txtLastName.Text;
                    n.Phone = txtPhone.Text;
                    n.BirthDate = dateBirth.Value;
                    n.Gender = cbGender.Text;
                    n.MedicalID = int.Parse(cBMedical.SelectedValue.ToString());
                    n.Email = txtEmail.Text;
                    if (busNurse.EditNurse(n))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        busNurse.GetAllNurse(gVNurse);

                    }
                    else MessageBox.Show("Chỉnh sửa thất bại");
                }
                else MessageBox.Show("Hãy nhập đầy đủ");
            }
            else MessageBox.Show("Hãy chắc chắn khi bạn muốn sửa vào lần sau!");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm y tas?", "Thêm y ta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {

                    Nurse n = new Nurse();
                    n.FirstName = txtFirstName.Text;
                    n.LastName = txtLastName.Text;
                    n.Phone = txtPhone.Text;
                    n.BirthDate = dateBirth.Value;
                    n.Gender = cbGender.Text;
                    n.MedicalID = int.Parse(cBMedical.SelectedValue.ToString());
                    n.Email = txtEmail.Text;

                    if (busNurse.AddNurse(n))
                    {
                        MessageBox.Show("thêm y ta thành công");
                        busNurse.GetAllNurse(gVNurse);
                        gVNurse.Rows[gVNurse.RowCount - 1].Selected = true;
                        gVNurse.CurrentCell = gVNurse.Rows[gVNurse.RowCount - 1].Cells[0];
                    }
                    else MessageBox.Show("Thêm y ta thất bại");


                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa Y ta ?", "Xóa Y ta", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtID.Text != "")
                {
                    int id = Int32.Parse(txtID.Text);
                    if (busNurse.DeleteNurse(id))
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");
                        busNurse.GetAllNurse(gVNurse);

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
