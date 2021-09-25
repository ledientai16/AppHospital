using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_Doctor
    {
        HospitalEntities db;
        public DAO_Doctor()
        {
            db = new HospitalEntities();
        }
        public dynamic GetAllDoctors()
        {
            var d = db.Doctors.Select(t => new
            {
                t.ID,
                t.FirstName,
                t.LastName,
                t.BirthDate,
                t.Gender,
                t.Phone,
                t.Email,
                t.Medical.Name

            }).ToList();
            return d;
        }

        public void AddDoctor(Doctor d)
        {
            db.Doctors.Add(d);
            db.SaveChanges();
        }
    }
}
