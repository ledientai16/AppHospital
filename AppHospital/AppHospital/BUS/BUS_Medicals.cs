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
        //lấy lên combobox
        public void GetAllMedical(ComboBox cb)
        {
            cb.DataSource = dMedical.GetAllMedicals();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
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

        public bool EditMedical(Medical m)
        {
            if (dMedical.CheckMedicalByID(m.ID))
            {

                try
                {
                    dMedical.EditMedical(m);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

            return false;
        }

        public bool DeleteMedical(int id)
        {
            if (dMedical.CheckMedicalByID(id))
            {


                try
                {
                    if (dMedical.DeleteMedical(id))
                    {
                        return true;
                    }
                    else
                        MessageBox.Show("là khóa ngoại");
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

