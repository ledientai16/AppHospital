using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_Service
    {
        HospitalEntities1 db;
        public DAO_Service()
        {
            db = new HospitalEntities1();
        }
        public dynamic getAllService()
        {
            var list = db.Services.Select(s => new {
                s.ID,
                s.NameService,
                s.Fee,
                s.Description,
                s.Medical.Name
            }).ToList();
            return list;
        }
        public void addService(Service s)
        {
            db.Services.Add(s);
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
            sv.NameService = s.NameService;
            sv.Description = s.Description;
            sv.Fee = s.Fee;
            sv.MedicalID = s.MedicalID;
            db.SaveChanges();

        }
    }
}
