using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_ServiceInvoice
    {
        DAO_ServiceInvoice daoServiceInvoice;
        public BUS_ServiceInvoice()
        {
            daoServiceInvoice = new DAO_ServiceInvoice();
        }
        public void getServiceInvoice(DataGridView d, int id)
        {
            d.DataSource = daoServiceInvoice.GetServicesByPatient(id);
        }

        public ServiceInvoice GetServiceInvoiceByID(int id)
        {
            return daoServiceInvoice.GetServiceInvoiceByID(id);
        }

        internal bool Create(ServiceInvoice s)
        {
            try
            {
                daoServiceInvoice.Create(s);
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
