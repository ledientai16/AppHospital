using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_Patient
    {
        HospitalEntities db;
        public DAO_Patient()
        {
            db = new HospitalEntities();
        }

        public dynamic GetAllPatients()
        {
            var d = db.Patients.Select(t => new
            {
                t.ID,
                t.FirstName,
                t.LastName,
                t.BirthDate,
                t.Gender,
                t.Phone,
                t.Email
            }).ToList();
            return d;
        }
        public dynamic GetPatients(String name) {
            var d = db.Patients.Where(t => t.LastName.Contains(name)).Select(t => new
            {
                t.ID,
                t.FirstName,
                t.LastName,
                t.BirthDate,
                t.Gender,
                t.Phone
                
            }).ToList();
            return d;
        }

        public void AddPatient(Patient d)
        {
            db.Patients.Add(d);
            db.SaveChanges();
        }

        public void DeletePatient(int id)
        {
            db.Patients.Remove(GetPatientByID(id));
            db.SaveChanges();
        }


        internal bool CheckPatientByID(int id)
        {

            if (GetPatientByID(id) != null)
                return true;
            return false;
        }


        public Patient GetPatientByID(int id)
        {
            Patient d = db.Patients.Where(s => s.ID == id).FirstOrDefault();
            return d;
        }


        public void EditPatient(Patient d)
        {
            Patient d2 = new Patient();
            d2 = GetPatientByID(d.ID);
            d2.FirstName = d.FirstName;
            d2.LastName = d.LastName;
            d2.Phone = d.Phone;
            d2.BirthDate = d.BirthDate;
            d2.Gender = d.Gender;
            d2.Email = d.Email;
            db.SaveChanges();
        }
    }
}
