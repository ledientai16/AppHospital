using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace AppHospital.DAO
    {
        class DAO_Nurse
        {
            HospitalEntities db;
            public DAO_Nurse()
            {
                db = new HospitalEntities();
            }
            public dynamic GetAllNurse()
            {
                var d = db.Nurses.Select(t => new
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
            public void AddNurse(Nurse n)
            {
                db.Nurses.Add(n);
                db.SaveChanges();
            }
            public Nurse GetNurseByID(int id)
            {
                Nurse n = db.Nurses.Where(s => s.ID == id).FirstOrDefault();
                return n;
            }
            internal bool CheckNurseByID(int id)
            {

                if (GetNurseByID(id) != null)
                    return true;
                return false;
            }
            public void EditNurse(Nurse n)
            {
                Nurse nu = new Nurse();
                nu = GetNurseByID(n.ID);
                nu.FirstName = n.FirstName;
                nu.LastName = n.LastName;
                nu.Phone = n.Phone;
                nu.BirthDate = n.BirthDate;
                nu.Gender = n.Gender;
                nu.MedicalID = n.MedicalID;
                nu.Email = n.Email;

                db.SaveChanges();

            }
            public void DeleteNurse(int id)
            {
                db.Nurses.Remove(GetNurseByID(id));
                db.SaveChanges();
            }


        }
    }
}
