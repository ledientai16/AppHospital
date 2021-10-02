using AppHospital.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital.BUS
{
    class BUS_User
    {
        private DAO_User dUser;
        public BUS_User()
        {
            dUser = new DAO_User();

        }
        public void getUsers(DataGridView d,string role, string name, string active)
        {
                d.DataSource = dUser.GetUsers(role, name, active);          
        }
        public User GetUser(string username, string password)
        {
            return dUser.GetUser(username, password);
        }
        public bool EditUser(User u)
        {
            if (!dUser.IsAdmin(u.ID))
            {
                if (dUser.CheckUserByID(u.ID))
                {
                    try
                    {
                        dUser.EditUser(u);
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }


                } 
            }MessageBox.Show("Không có quyền tương tác với admin");
            return false;
        }

        //xử lý login 
        public bool CheckLogin(string username, string password)
        {
            if(this.dUser.CheckLogin(username, password))
            {
                if (dUser.CheckUserActive(username, password))
                    return true;
                else MessageBox.Show("Tài khoản này bị khóa");

            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc pass");
            }
            return false;
        }
    }
}
