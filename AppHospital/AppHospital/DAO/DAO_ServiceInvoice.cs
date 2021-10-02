using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_ServiceInvoice
    {
        HospitalEntities db;
        public DAO_ServiceInvoice()
        {
            db = new HospitalEntities();
        }

        public dynamic GetServicesByPatient(int pID)
        {
            var s = db.ServiceInvoices.Where(v => v.PatientID == pID).Select(v => new
            {
                v.ID,
                v.NurseID,
                v.ServiceID,

                v.Fee,
                v.CreatedDate

            }).ToList();
            return s;
        }

        public ServiceInvoice GetServiceInvoiceByID(int id)
        {
            ServiceInvoice s = db.ServiceInvoices.Find(id);
            return s;
        }

        public void Create(ServiceInvoice s)
        {
            db.ServiceInvoices.Add(s);
            db.SaveChanges();
        }
    }
}
