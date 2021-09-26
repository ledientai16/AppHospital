//using System;
using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
 
    class BUS_Nurse
    {
        DAO_Nurse dNurse;
        public BUS_Nurse()
        {
            dNurse = new DAO_Nurse();

        }
        public void GetAllNurse(DataGridView d)
        {
            d.DataSource = dNurse.GetAllNurse();
        }
        public bool AddNurse(Nurse n)
        {

            try
            {
                dNurse.AddNurse(n);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool EditNurse(Nurse n)
        {
            if (dNurse.CheckNurseByID(n.ID))
            {
                try
                {
                    dNurse.EditNurse(n);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }


            }
            return false;


        }
        public bool DeleteNurse(int id)
        {
            if (dNurse.CheckNurseByID(id))
            {


                try
                {

                    dNurse.DeleteNurse(id);
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