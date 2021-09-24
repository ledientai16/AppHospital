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
    }
}
