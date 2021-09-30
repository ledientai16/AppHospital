using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_Service
    {
        DAO_Service daoService;
        public BUS_Service()
        {
            daoService = new DAO_Service();
        }
        public void GetAllService(DataGridView d)
        {
            d.DataSource = daoService.getAllService();
        }
        public bool addService(Service s)
        {
            try
            {
                daoService.addService(s);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool deleteService(int id)
        {
            if (daoService.CheckServicebyID(id))
            {


                try
                {

                    daoService.deleteService(id);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }


            }
            return false;
        }
        public bool editService(Service sv)
        {
            if (daoService.CheckServicebyID(sv.ID))
            {
                try
                {
                    daoService.editService(sv);
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
