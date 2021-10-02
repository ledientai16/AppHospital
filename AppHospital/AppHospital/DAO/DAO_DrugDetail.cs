using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_DrugDetail
    {
        HospitalEntities db;

        public DAO_DrugDetail()
        {
            db = new HospitalEntities();
        }

        public dynamic GetListDrug()
        {
            var ds = db.Drugs.Select(s => new
            {
                s.ID,
                s.Name
            }).ToList();
            return ds;
        }

      


        public dynamic GetAllDrugDetail(int presId)
        {
            var d = db.DrugDetails.Where(s => s.PrescriptionID == presId).Select(t => new
            {
                t.DrugID,
                t.Drug.Name,
                t.PrescriptionID,
                t.Quantity,
                t.UserGuide,
                t.UnitPrice
            }).ToList();
            return d;
        }

        public void AddDrugDetail(DrugDetail d)
        {
            db.DrugDetails.Add(d);
            db.SaveChanges();
        }

        public DrugDetail GetDrugDetailByID(int idPre , int idDrug)
        {
            DrugDetail d = db.DrugDetails.Find(idPre, idDrug);
            return d;
        }

        internal bool CheckDrugDetailByID(int idPre, int idDrug)
        {
         
            if (GetDrugDetailByID(idPre, idDrug) != null)
                return true;
            return false;
        }


        public void EditDrugDetail(DrugDetail d)
        {
            DrugDetail d2 = new DrugDetail();
            d2 = GetDrugDetailByID(d.PrescriptionID, d.DrugID);

            d2.PrescriptionID = d.PrescriptionID;
            d2.DrugID = d.DrugID;
            d2.UserGuide = d.UserGuide;
            d2.Quantity = d.Quantity;
            d2.UnitPrice = d.UnitPrice;
            db.SaveChanges();
        }


        public void DeleteDrugDetail(int idPre, int idDrug)
        {
            db.DrugDetails.Remove(GetDrugDetailByID(idPre, idDrug));
            db.SaveChanges();
        }
    }
}
