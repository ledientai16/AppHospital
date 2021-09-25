using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_Doctor
    {
        DAO_Doctor dDoctor;
        public BUS_Doctor()
        {
            dDoctor = new DAO_Doctor();
        }
        public void GetAllDoctors(DataGridView d)
        {
            d.DataSource = dDoctor.GetAllDoctors();
        }

        public bool AddDoctor(Doctor d)
        {

            try
            {
                dDoctor.AddDoctor(d);
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
