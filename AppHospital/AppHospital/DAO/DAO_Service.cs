using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_Service
    {
        HospitalEntities db;
        public DAO_Service()
        {
            db = new HospitalEntities();
        }
        public dynamic getAllService()
        {
            var list = db.Services.Select(s => new {
                s.ID,
                s.Name,
                s.Fee,
                s.Description,
                medicalName = s.Medical.Name
            }).ToList();
            return list;
        }
        public void addService(Service s)
        {
            object p = db.Services.Add(s);
            db.SaveChanges();
        }
        public Service GetServicebyID(int id)
        {
            Service sv = db.Services.Where(s => s.ID == id).FirstOrDefault();
            return sv;
        }
        internal bool CheckServicebyID(int id)
        {

            if (GetServicebyID(id) != null)
                return true;
            return false;
        }
        public void deleteService(int id)
        {
            db.Services.Remove(GetServicebyID(id));
            db.SaveChanges();
        }
        public void editService(Service s)
        {
            Service sv = new Service();
            sv = GetServicebyID(s.ID);
            sv.Name = s.Name;
            sv.Description = s.Description;
            sv.Fee = s.Fee;
            sv.MedicalID = s.MedicalID;
            db.SaveChanges();

        }
    }
}
