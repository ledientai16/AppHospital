using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_Drug
    {
        DAO_Drug dDrug;
        public BUS_Drug()
        {
            dDrug = new DAO_Drug();
        }


        public void GetAllDrugs(DataGridView d)
        {
            d.DataSource = dDrug.GetAllDrugs();
        }


        public bool AddDrug(Drug d)
        {

            try
            {
                dDrug.AddDrug(d);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public bool EditDrug(Drug d)
        {
            if (dDrug.CheckDrugByID(d.ID))
            {
                try
                {
                    dDrug.EditDrug(d);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }



        public bool DeleteDrug(int id)
        {
            if (dDrug.CheckDrugByID(id))
            {
                try
                {
                    dDrug.DeleteDrug(id);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }
    }
}
