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
    public partial class FormMedicalManager : Form
    {
         BUS_Medicals busMedicals;
        public FormMedicalManager()
        {
            InitializeComponent();
            busMedicals = new BUS_Medicals();
        }
        //lấy danh sách chuyên khoa và định dạng collums
        private void GetAllMedicals()
        {
            gVMedical.DataSource = null;
            busMedicals.GetAllMedical(gVMedical);
            gVMedical.Columns[0].Width = (int)(gVMedical.Width * 0.2);
            gVMedical.Columns[1].Width = (int)(gVMedical.Width * 0.25);
            gVMedical.Columns[2].Width = (int)(gVMedical.Width * 0.5);
           
        }
        private void FormMedicalManager_Load(object sender, EventArgs e)
        {
            
            GetAllMedicals();
        }

        private void gVMedical_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVMedical.Rows.Count)
            {
                
                txtID.Text = gVMedical.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = gVMedical.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescription.Text = gVMedical.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm Chuyên khoa?", "Thêm chuyên khoa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtDescription.Text != "" && txtName.Text.ToString() != "")
                {

                    Medical m = new Medical();
                    m.Name = txtName.Text;
                    m.Description = txtDescription.Text;
                    
                    if (busMedicals.AddMedical(m))
                    {
                        MessageBox.Show("Tạo Chuyên khoa thành công");
                        busMedicals.GetAllMedical(gVMedical);
                        gVMedical.Rows[gVMedical.RowCount - 1].Selected = true;
                        gVMedical.CurrentCell = gVMedical.Rows[gVMedical.RowCount - 1].Cells[0];
                    }
                    else MessageBox.Show("Thêm Medical thất bại");
                    txtName.Text = "";
                    txtDescription.Text = "";
                   
                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin?", "Chỉnh sửa chuyên khoa", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtID.Text != "")
                {
                    Medical m = new Medical();
                    m.ID = Int32.Parse(txtID.Text);
                    m.Name = txtName.Text;
                    m.Description = txtDescription.Text;
                   

                    if (busMedicals.EditMedical(m))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        busMedicals.GetAllMedical(gVMedical);
                        gVMedical.Rows[gVMedical.RowCount - 1].Selected = true;
                        gVMedical.CurrentCell = gVMedical.Rows[gVMedical.RowCount - 1].Cells[0];
                    }
                    else MessageBox.Show("Chỉnh sửa thất bại");
                }
            }
            else MessageBox.Show("Hãy chắc chắn khi bạn muốn sửa vào lần sau!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa chuyên khoa?", "Xóa chuyên khoa", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (txtID.Text != "")
                {
                    int id = Int32.Parse(txtID.Text);
                    if (busMedicals.DeleteMedical(id))
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");
                        busMedicals.GetAllMedical(gVMedical);

                    }
                    else MessageBox.Show("Đã có lỗi gì đó");
                }
                else MessageBox.Show("Hãy chọn chuyên khoa muốn xóa");

                //đặt về default
                txtID.Text = "";
                txtName.Text = "";
                txtDescription.Text = "";
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }
    }
}
