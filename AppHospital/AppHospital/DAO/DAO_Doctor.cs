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

        public Doctor GetDoctorByID(int id)
        {
            Doctor d = db.Doctors.Where(s => s.ID == id).FirstOrDefault();
            return d;
        }
        internal bool CheckDoctorByID(int id)
        {

            if (GetDoctorByID(id) != null)
                return true;
            return false;
        }

        public void DeleteDoctor(int id)
        {
            db.Doctors.Remove(GetDoctorByID(id));
            db.SaveChanges();
        }

        public void EditDoctor(Doctor d)
        {
            Doctor d2 = new Doctor();
            d2 = GetDoctorByID(d.ID);
            d2.FirstName = d.FirstName;
            d2.LastName = d.LastName;
            d2.Phone = d.Phone;
            d2.BirthDate = d.BirthDate;
            d2.Gender = d.Gender;
            d2.MedicalID = d.MedicalID;
            d2.Email = d.Email;
            db.SaveChanges();
        }
    }
}
