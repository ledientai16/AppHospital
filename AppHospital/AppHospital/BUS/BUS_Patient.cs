using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_Patient
    {
        DAO_Patient dPatient;

        public BUS_Patient()
        {
            dPatient = new DAO_Patient();
        }

        public void GetAllPatients(DataGridView d)
        {
            d.DataSource = dPatient.GetAllPatients();
        }

        public bool AddPatient(Patient d)
        {

            try
            {
                dPatient.AddPatient(d);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void GetPatients(DataGridView d, string name)
        {
            d.DataSource = dPatient.GetPatients(name);
        }
        
        public bool DeletePatient(int id)
        {
            if (dPatient.CheckPatientByID(id))
            {
                try
                {
                    dPatient.DeletePatient(id);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }
        public bool EditPatient(Patient d)
        {
            if (dPatient.CheckPatientByID(d.ID))
            {
                try
                {
                    dPatient.EditPatient(d);
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
