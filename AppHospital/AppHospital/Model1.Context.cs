//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppHospital
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalEntities1 : DbContext
    {
        public HospitalEntities1()
            : base("name=HospitalEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugDetail> DrugDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Medical> Medicals { get; set; }
        public virtual DbSet<MedicalExaminationCard> MedicalExaminationCards { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceInvoice> ServiceInvoices { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
