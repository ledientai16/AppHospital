using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHospital.DAO
{
    class DAO_User
    {
        HospitalEntities db;
        public DAO_User()
        {
            db = new HospitalEntities();
        }
        public dynamic GetUsers(string role, string name, String active)
        {
            
            if (!active.Equals("ALL"))
            {
                bool a;
                if (active.Equals("Active"))
                    a = true;
                else a = false;

                var u = db.Users.Where(t => (t.UserName.Contains(name)) && (t.Role_User.Equals(role)) && (t.Active == a)).Select(t => new
                {
                    t.ID,
                    t.UserName,
                    t.Role_User,
                    t.CreatedDate
                }).ToList();
                
                return u;

            }
            else
            {
                var u = db.Users.Where(t => (t.UserName.Contains(name)) && (t.Role_User.Contains(role))).Select(t => new
                {
                    t.ID,
                    t.UserName,
                    t.Role_User,
                    t.CreatedDate
                }).ToList();
                return u;
                
            }
        }

        

        public bool IsAdmin(int ID)
        {
            User u = GetUserByID(ID);
            if (u.Role_User.Equals("ROLE_ADMIN"))
                return false;
            return true;
        }
        public bool CheckUserByID(int iD)
        {
            if (GetUserByID(iD) != null)
                return true;
            return false;
        }
        public User GetUserByID(int id)
        {
            User u = db.Users.Where(s => s.ID == id).FirstOrDefault();
            return u;
        }
        public void EditUser(User u)
        {
            User u2 = this.GetUserByID(u.ID);
            u2.Active = u.Active;
        }

        //xử lý đăng nhập

        public bool CheckLogin(string username, string password)
        {
            int count = (int)db.userLogin(username, password).FirstOrDefault();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public User GetUser(string username, string password)
        {
            User u = db.Users.Where(k => (k.UserName == username) && (k.Password == password)).FirstOrDefault();
            return u;
        }
        public bool CheckUserActive(string username, string password)
        {
            User u = GetUser(username, password);
            if (u.Active == true)
                return true;
            return false;
        }

    }
}
