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
        BUS_Prescription busPrescription;
        BUS_Doctor busDoctor;
        public FormPrescriptionManager()
        {
            InitializeComponent();
            busPrescription = new BUS_Prescription();
        }

        private void FormPrescriptionManager_Load(object sender, EventArgs e)
        {
            GetAllPrescription();
            busPrescription.GetListPatient(cbBN);
            busPrescription.GetListDoctor(cbBS);
        }

        private void GetAllPrescription()
        {
            gVPre.DataSource = null;
            busPrescription.GetAllPrescription(gVPre);
            gVPre.Columns[0].Width = (int)(gVPre.Width * 0.1);
            gVPre.Columns[1].Width = (int)(gVPre.Width * 0.1);
            gVPre.Columns[2].Width = (int)(gVPre.Width * 0.2);
            gVPre.Columns[3].Width = (int)(gVPre.Width * 0.2);
            gVPre.Columns[0].HeaderText = "Mã toa";
            gVPre.Columns[1].HeaderText = "Ngày tạo toa";
            gVPre.Columns[2].HeaderText = "Tên bệnh nhân";
            gVPre.Columns[3].HeaderText = "Tên bác sĩ";

        }

        private void gVPre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVPre.Rows.Count)
            {
                txtID.Enabled = false;
                txtID.Text = gVPre.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                createdDate.Text = gVPre.Rows[e.RowIndex].Cells[1].Value.ToString();   
                cbBN.Text = gVPre.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbBS.Text = gVPre.Rows[e.RowIndex].Cells[3].Value.ToString();
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
                    d.ID = int.Parse(txtID.Text);

                    d.CreatedDate = createdDate.Value;
                    d.DoctorID = int.Parse(cbBS.SelectedValue.ToString());
                    d.PatientID = int.Parse(cbBN.SelectedValue.ToString());

                    if (busPrescription.AddPrescription(d))
                    {
                        MessageBox.Show("thêm toa thuốc thành công");
                        busPrescription.GetAllPrescription(gVPre);
                        gVPre.Rows[gVPre.RowCount - 1].Selected = true;
                        gVPre.CurrentCell = gVPre.Rows[gVPre.RowCount - 1].Cells[0];
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
                if (checkInfo())
                {

                    Prescription d = new Prescription();
                    d.ID = int.Parse(txtID.Text);

                    d.CreatedDate = createdDate.Value;
                    d.DoctorID = int.Parse(cbBS.SelectedValue.ToString());
                    d.PatientID = int.Parse(cbBN.SelectedValue.ToString());

                    if (busPrescription.EditPrescription(d))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        busPrescription.GetAllPrescription(gVPre);

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
                        busPrescription.GetAllPrescription(gVPre);

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

            if (txtID.Text == "" || createdDate.Text == "" || cbBN.Text == "" || cbBS.Text == "")
                return false;
            return true;
        }

    

        private void gVPre_DoubleClick(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(gVPre.CurrentRow.Cells[0].Value.ToString());
            FormDrugDetail f = new FormDrugDetail();
            f.idDetail = id;
            f.ShowDialog();
        }
    }
}
