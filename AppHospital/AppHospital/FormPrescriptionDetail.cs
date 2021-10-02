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
    public partial class FormPrescriptionDetail : Form
    {
        public User user;
        
        BUS_Drug busDrug;
        BUS_Doctor busDoctor;
        BUS_Patient busPatient;
        BUS_DrugDetail busDrugDetail;
        
        public int presID;
        public int doctorID;
        public int patiedID;
        public FormPrescriptionDetail()
        {
            InitializeComponent();
        }

        private void GetALLDrugDetail()
        {
            gVDrugDetail.DataSource = null;
            busDrugDetail.GetAllDrugDetail(gVDrugDetail, this.presID);
            gVDrugDetail.Columns[0].Width = (int)(gVDrugDetail.Width * 0.1);
            gVDrugDetail.Columns[1].Width = (int)(gVDrugDetail.Width * 0.2);
            gVDrugDetail.Columns[2].Width = (int)(gVDrugDetail.Width * 0.2);
            gVDrugDetail.Columns[3].Width = (int)(gVDrugDetail.Width * 0.2);
            gVDrugDetail.Columns[4].Width = (int)(gVDrugDetail.Width * 0.2);
            gVDrugDetail.Columns[5].Width = (int)(gVDrugDetail.Width * 0.2);

        }
        public void Authorization()
        {
            if (!user.Role_User.Equals("ROLE_DOCTOR") && this.busDoctor.GetDoctorByUser(this.user.ID).ID == doctorID)
            {
                btnAddDrug.Visible = false;
                
            }
     
        }
        private void FormPrescriptionDetail_Load(object sender, EventArgs e)
        {
            busDrug = new BUS_Drug();
            busDrugDetail = new BUS_DrugDetail();
            busDoctor = new BUS_Doctor();
            busPatient = new BUS_Patient();
            busDrug.GetAllDrugs(cbDrug);
            GetALLDrugDetail();

            //

            
        }
        public void ShowInfo()
        {
            txtPresID.Text = this.presID.ToString();
            txtDoctorId.Text = this.doctorID.ToString();
            txtPatient.Text = this.patiedID.ToString();
            
        }
        private void cbDrug_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtDrugID.Text = cbDrug.SelectedValue.ToString();
            Drug d;
            d = busDrug.GetDrugByID(int.Parse(cbDrug.SelectedValue.ToString()));
            txtPrice.Text = d.UnitPrice.ToString();
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm thuốc vào đơn?", "Thêm bác sỉ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {
                    DrugDetail d = new DrugDetail();
                    d.DrugID = int.Parse(txtDrugID.Text);
                    d.PrescriptionID = this.presID;

                    d.Quantity = int.Parse(numQuan.Value.ToString());
                    d.UnitPrice = int.Parse(txtPrice.Text);
                    d.UserGuide = txtGuide.Text;
                   

                    if (busDrugDetail.Update(d))
                    {
                        MessageBox.Show("Thêm Thành công");
                        busDrugDetail.GetAllDrugDetail(gVDrugDetail, this.presID);
                    }
                    else MessageBox.Show("Thêm thất bại");


                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private bool checkInfo()
        {
            if (txtDrugID.Text == "")
                return false;
            return true;
        }

        private void gVDrugDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDrugDetail.Rows.Count)
            {
                txtDrugID.Text = gVDrugDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbDrug.Text = gVDrugDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                numQuan.Value =decimal.Parse(gVDrugDetail.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtPrice.Text = gVDrugDetail.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtGuide.Text = gVDrugDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa thuốc", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtDrugID.Text != "")
                {
                    int id = Int32.Parse(txtDrugID.Text);
                    if (busDrugDetail.DeleteDrugDetail(presID,id))
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");
                        busDrugDetail.GetAllDrugDetail(gVDrugDetail, presID);

                    }
                    else MessageBox.Show("Đã có lỗi gì đó");
                }
                else MessageBox.Show("Hãy chọn bác sĩ muốn xóa");

                //đặt về default
                txtDrugID.Text = "";

            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }
    }
}
