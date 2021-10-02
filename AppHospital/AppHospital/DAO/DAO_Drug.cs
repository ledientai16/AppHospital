using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_Drug
    {
        HospitalEntities db;
        public DAO_Drug()
        {
            db = new HospitalEntities();
        }

        public dynamic GetAllDrugs()
        {
            var d = db.Drugs.Select(t => new
            {
                t.ID,
                t.Name,             
                t.Quantity,  
                t.UnitPrice,
                t.Expiry,
                t.Manufacturer,
                t.Type
            }).ToList();
            return d;
        }

        public void AddDrug(Drug d)
        {
            db.Drugs.Add(d);
            db.SaveChanges();
        }


        public Drug GetDrugByID(int id)
        {
            Drug d = db.Drugs.Where(s => s.ID == id).FirstOrDefault();
            return d;
        }

        internal bool CheckDrugByID(int id)
        {

            if (GetDrugByID(id) != null)
                return true;
            return false;
        }


        public void EditDrug(Drug d)
        {
            Drug d2 = new Drug();
            d2 = GetDrugByID(d.ID);
            d2.Name = d.Name;
            d2.UnitPrice = d.UnitPrice;
            d2.Quantity = d.Quantity;
            d2.Expiry = d.Expiry;
            d2.Manufacturer = d.Manufacturer;
            d2.Type = d.Type;
            db.SaveChanges();
        }


        public void DeleteDrug(int id)
        {
            db.Drugs.Remove(GetDrugByID(id));
            db.SaveChanges();
        }
    }
}
