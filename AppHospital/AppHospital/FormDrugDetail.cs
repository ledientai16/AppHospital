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
    public partial class FormDrugDetail : Form
    {
         public int idDetail;
        BUS_DrugDetail busDetail;
        public FormDrugDetail()
        {
            InitializeComponent();
            busDetail = new BUS_DrugDetail();
        }

        private void FormDrugDetail_Load(object sender, EventArgs e)
        {
            GetAllDrugDetail();
            busDetail.GetListDrug(cbDrugName);
        }


        private void GetAllDrugDetail() { 
            gVDetail.DataSource = null;
            busDetail.GetAllDrugDetail(gVDetail);
            gVDetail.Columns[0].Width = (int)(gVDetail.Width * 0.1);
            gVDetail.Columns[1].Width = (int)(gVDetail.Width * 0.1);
            gVDetail.Columns[2].Width = (int)(gVDetail.Width * 0.2);
            gVDetail.Columns[3].Width = (int)(gVDetail.Width * 0.2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm thuốc?", "Thêm thuốc", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (checkInfo() == true)
                {
                    DrugDetail d = new DrugDetail();
                    d.PrescriptionID= int.Parse(txtID.Text);

                    d.DrugID = int.Parse(cbDrugName.SelectedValue.ToString());
                   
                    d.Quantity = int.Parse(txtQuantity.Text);
                    d.UserGuide = txtGuide.Text;
                    

                    if (busDetail.AddDrugDetail(d))
                    {
                        MessageBox.Show("thêm thuốc thành công");
                        busDetail.GetAllDrugDetail(gVDetail);
                        gVDetail.Rows[gVDetail.RowCount - 1].Selected = true;
                        gVDetail.CurrentCell = gVDetail.Rows[gVDetail.RowCount - 1].Cells[0];
                    }
                    else MessageBox.Show("Thêm thuốc thất bại");


                }
                else MessageBox.Show("Hãy nhập đầy đủ!");
            }
            else MessageBox.Show("Hãy suy nghĩ kỹ càng hơn bạn nhé!");
        }


        private bool checkInfo()
        {

            if (txtID.Text == "" || cbDrugName.Text == "" || txtGuide.Text == "" || txtQuantity.Text == "")
                return false;
            return true;
        }

        private void FormDrugDetail_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
