using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_DrugDetail
    {
        DAO_DrugDetail dDeltail;

        public BUS_DrugDetail()
        {
            dDeltail = new DAO_DrugDetail();
        }

        public void GetAllDrugDetail(DataGridView d, int presID)
        {
            d.DataSource = dDeltail.GetAllDrugDetail(presID);
        }


        public void GetListDrug(ComboBox cb)
        {
            cb.DataSource = dDeltail.GetListDrug();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";


        }
      

        public bool AddDrugDetail(DrugDetail d)
        {

            try
            {
                dDeltail.AddDrugDetail(d);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool EditDrugDetail(DrugDetail d)
        {
            if (dDeltail.CheckDrugDetailByID(d.PrescriptionID, d.DrugID))
            {
                try
                {
                    dDeltail.EditDrugDetail(d);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }



        public bool DeleteDrugDetail(int idPre, int idDrug)
        {
            if (dDeltail.CheckDrugDetailByID(idPre, idDrug))
            {
                try
                {
                    dDeltail.DeleteDrugDetail(idPre, idDrug);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }

        public bool Update(DrugDetail d)
        {
            
            if(dDeltail.CheckDrugDetailByID(d.PrescriptionID, d.DrugID) == false)
            {
                try
                {
                    dDeltail.AddDrugDetail(d);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
            {
                try
                {
                    dDeltail.EditDrugDetail(d);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            
        }
    }
}
