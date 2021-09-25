using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_Medicals
    {
        HospitalEntities db;
        public DAO_Medicals()
        {
            db = new HospitalEntities();
        }

        public dynamic GetAllMedicals()
        {
            var list = db.Medicals.Select(s => new {
                s.ID,
                s.Name,
                s.Description
            }).ToList();
            return list;
        }
        public void AddMedical(Medical m)
        {
            db.Medicals.Add(m);
            db.SaveChanges();
        }
        public Medical GetMedicalByID(int id)
        {
            Medical m = db.Medicals.Where(s => s.ID == id).FirstOrDefault();
            return m;
        }
        public bool CheckMedicalByID(int iD)
        {
            if (GetMedicalByID(iD) != null)
                return true;
            return false;
        }
        public void EditMedical(Medical m)
        {
            Medical m2 = new Medical();
            m2 = this.GetMedicalByID(m.ID);

            m2.Name = m.Name;
            m2.Description = m.Description;
           
            db.SaveChanges();
        }

        public bool DeleteMedical(int id)
        {

            if (db.Doctors.Count(d => d.MedicalID == id) == 0)
            {
                db.Medicals.Remove(GetMedicalByID(id));
                db.SaveChanges();
                return true;
            }
            else return false;
            
        }
        
    }
}
