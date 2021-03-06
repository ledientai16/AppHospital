using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_Prescription
    {
        HospitalEntities db;
        public DAO_Prescription()
        {
            db = new HospitalEntities();
        }


        public dynamic GetListPatient()
        {
            var ds = db.Patients.Select(s => new
            {
                s.ID,
                s.LastName
            }).ToList();
            return ds;
        }

        public dynamic GetListDoctor()
        {
            var ds = db.Doctors.Select(s => new
            {
                s.ID,
                s.FirstName
            }).ToList();
            return ds;
        }


        public dynamic GetAllPrescription()
        {
            var d = db.Prescriptions.Select(t => new
            {
                t.ID,
                t.CreatedDate,
                t.PatientID,
                t.DoctorID

            }).ToList();
            return d;
        }
        public dynamic GetAllPrescription(int patientID)
        {
            var d = db.Prescriptions.Where(t => t.PatientID == patientID).Select(t => new
            {
                t.ID,
                t.CreatedDate,
                t.PatientID,
                t.DoctorID,
                t.Diagnosis,
                t.Appointment
            }).ToList();
            return d;
        }
        public void AddPrescription(Prescription d)
        {
            db.Prescriptions.Add(d);
            db.SaveChanges();
        }

        public Prescription GetPrescriptionByID(int id)
        {
            Prescription d = db.Prescriptions.Where(s => s.ID == id).FirstOrDefault();
            return d;
        }

        internal bool CheckPrescriptionByID(int id)
        {

            if (GetPrescriptionByID(id) != null)
                return true;
            return false;
        }


        public void EditPrescription(Prescription d)
        {
            Prescription d2 = new Prescription();
            d2 = GetPrescriptionByID(d.ID);
            d2.Diagnosis = d.Diagnosis;
            d2.Appointment = d.Appointment;
            db.SaveChanges();
        }


        public void DeletePrescription(int id)
        {
            db.Prescriptions.Remove(GetPrescriptionByID(id));
            db.SaveChanges();
        }

    }
}
