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
    public partial class FormServiceManager : Form
    {
        BUS_Medicals busMedicals;
        BUS_Service busService;

        public FormServiceManager()
        {
            InitializeComponent();
            busMedicals = new BUS_Medicals();
            busService = new BUS_Service();

        }
        private void getAllService()
        {
            gVService.DataSource = null;
          
        }

        private void FormServiceManager_Load(object sender, EventArgs e)
        {
            busMedicals.GetAllMedical(cbMedical);
            busService.GetAllService(gVService);

        }
        private bool checkInfo()
        {

            if (txtName.Text == "" || txtDescription.Text == ""
                || txtPrice.Text == "" || cbMedical.Text=="")
                return false;
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm dịch vụ ?", "Thêm dịch vụ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {

                    Service s = new Service();
                    s.NameService = txtName.Text;
                    s.Description = txtDescription.Text;
                    s.Fee = int.Parse(txtPrice.Text);
                    s.MedicalID = int.Parse(cbMedical.SelectedValue.ToString());

                    if (busService.addService(s))
                    {
                        MessageBox.Show("Thêm dịch vụ thành công");
                        busService.GetAllService(gVService);
                        gVService.Rows[gVService.RowCount - 1].Selected = true;
                        gVService.CurrentCell = gVService.Rows[gVService.RowCount - 1].Cells[0];
                    }
                    else MessageBox.Show("Thêm dịch vụ thất bại");


                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dịch vụ?", "Xóa bác dịch vụ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtID.Text != "")
                {
                    int id = Int32.Parse(txtID.Text);
                    if (busService.deleteService(id))
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");
                        busService.GetAllService(gVService);

                    }
                    else MessageBox.Show("Đã có lỗi gì đó");
                }
                else MessageBox.Show("Hãy chọn dịch vụ muốn xóa");

                //đặt về default
                txtID.Text = "";
                txtDescription.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                cbMedical.Text = "";

            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private void gVService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVService.Rows.Count)
            {
                
                txtID.Text = gVService.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = gVService.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrice.Text = gVService.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescription.Text = gVService.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbMedical.Text = gVService.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin?", "Chỉnh sửa dịch vụ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo())
                {
                    Service sv = new Service();
                    sv.ID = int.Parse(txtID.Text);
                    sv.NameService = txtName.Text;
                    sv.Description = txtDescription.Text;
                    sv.Fee = int.Parse(txtPrice.Text);
                    sv.MedicalID = int.Parse(cbMedical.SelectedValue.ToString());
                    
                    if (busService.editService(sv))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        busService.GetAllService(gVService);

                    }
                    else MessageBox.Show("Chỉnh sửa thất bại");
                }
                else MessageBox.Show("Hãy nhập đầy đủ");
            }
            else MessageBox.Show("Hãy chắc chắn khi bạn muốn sửa vào lần sau!");
        }
    }
}
