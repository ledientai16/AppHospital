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
    public partial class FormDrugManager : Form
    {
        BUS_Drug busDrug;
        public FormDrugManager()
        {
            InitializeComponent();
            busDrug = new BUS_Drug();
        }

        private void FormDrugManager_Load(object sender, EventArgs e)
        {
            GetAllDrugs();
        


        }
        private void GetAllDrugs()
        {
            gVDrug.DataSource = null;
            busDrug.GetAllDrugs(gVDrug);
            gVDrug.Columns[0].Width = (int)(gVDrug.Width * 0.1);
            gVDrug.Columns[1].Width = (int)(gVDrug.Width * 0.15);
            gVDrug.Columns[2].Width = (int)(gVDrug.Width * 0.1);
            gVDrug.Columns[3].Width = (int)(gVDrug.Width * 0.1);
            gVDrug.Columns[4].Width = (int)(gVDrug.Width * 0.1);
            gVDrug.Columns[5].Width = (int)(gVDrug.Width * 0.10);
            gVDrug.Columns[6].Width = (int)(gVDrug.Width * 0.10);

        }

        private void gVDrug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDrug.Rows.Count)
            {
                txtID.Enabled = false;
                txtID.Text = gVDrug.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = gVDrug.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = gVDrug.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = gVDrug.Rows[e.RowIndex].Cells[3].Value.ToString();               
                dateExpiry.Value = (DateTime)gVDrug.Rows[e.RowIndex].Cells[4].Value;
                dateManufature.Value = (DateTime)gVDrug.Rows[e.RowIndex].Cells[5].Value;
                cbType.Text = gVDrug.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm thuốc?", "Thêm thuốc", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {

                    Drug d = new Drug();
                    d.ID = int.Parse(txtID.Text);

                    d.Name = txtName.Text;
                    d.UnitPrice = txtPrice.Text;
                    d.Quantity = int.Parse (txtQuantity.Text);
                    d.Expiry = dateExpiry.Value;
                    d.Manufacturer = dateManufature.Value;
                    d.Type = cbType.Text;
                               
                    if (busDrug.AddDrug(d))
                    {
                        MessageBox.Show("thêm thuốc thành công");
                        busDrug.GetAllDrugs(gVDrug);
                        gVDrug.Rows[gVDrug.RowCount - 1].Selected = true;
                        gVDrug.CurrentCell = gVDrug.Rows[gVDrug.RowCount - 1].Cells[0];
                    }
                    else MessageBox.Show("Thêm thuốc thất bại");


                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

        private bool checkInfo()
        {

            if (txtID.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == ""
                || dateExpiry.Text == "" || dateManufature.Text == "" || cbType.Text == "")
                return false;
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin?", "Chỉnh sửa thuốc", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo())
                {

                    Drug d = new Drug();
                    d.Name = txtName.Text;
                    d.UnitPrice = txtPrice.Text;
                    d.Quantity = int.Parse(txtQuantity.Text);
                    d.Expiry = dateExpiry.Value;
                    d.Manufacturer = dateManufature.Value;
                    d.Type = cbType.Text;



                    d.ID = int.Parse(txtID.Text);



                    if (busDrug.EditDrug(d))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        busDrug.GetAllDrugs(gVDrug);

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
                    if (busDrug.DeleteDrug(id))
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");
                        busDrug.GetAllDrugs(gVDrug);

                    }
                    else MessageBox.Show("Đã có lỗi gì đó");
                }
                else MessageBox.Show("Hãy chọn thuốc muốn xóa");

                //đặt về default
                txtID.Text = "";

            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }

    }
}
