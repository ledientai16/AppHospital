using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_Medicals
    {
        DAO_Medicals dMedical;
        public BUS_Medicals()
        {
            dMedical = new DAO_Medicals();
        }
        public void GetAllMedical(DataGridView dg)
        {
            dg.DataSource = dMedical.GetAllMedicals();
        }
        public bool AddMedical(Medical m)
        {

            try
            {
                dMedical.AddMedical(m);
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
