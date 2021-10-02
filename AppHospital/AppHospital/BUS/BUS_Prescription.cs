using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_Prescription
    {
        DAO_Prescription dPrescription;

        public BUS_Prescription()
        {
            dPrescription = new DAO_Prescription();
        }

        public void GetAllPrescription(DataGridView d)
        {
            d.DataSource = dPrescription.GetAllPrescription();
        }

        public void GetListPatient(ComboBox cb)
        {
            cb.DataSource = dPrescription.GetListPatient();
            cb.DisplayMember = "LastName";
            cb.ValueMember = "ID";
            

        }
        public void GetListDoctor(ComboBox cb)
        {
            cb.DataSource = dPrescription.GetListDoctor();
            cb.DisplayMember = "FirstName";
            cb.ValueMember = "ID";

        }

        public bool AddPrescription(Prescription d)
        {

            try
            {
                dPrescription.AddPrescription(d);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool EditPrescription(Prescription d)
        {
            if (dPrescription.CheckPrescriptionByID(d.ID))
            {
                try
                {
                    dPrescription.EditPrescription(d);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }



        public bool DeletePrescription(int id)
        {
            if (dPrescription.CheckPrescriptionByID(id))
            {
                try
                {
                    dPrescription.DeletePrescription(id);
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
