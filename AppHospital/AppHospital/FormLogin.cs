using AppHospital.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHospital
{
    public partial class FormLogin : Form
    {
        public User user;
        BUS_User busUser;
        public FormLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            busUser = new BUS_User();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (busUser.CheckLogin(txtUsername.Text, txtPassword.Text))
            {
                 MessageBox.Show("Đăng nhập thành công");
                FormAdminMenu f  =  new FormAdminMenu();
                //truyen user cho admin

                f.user = busUser.GetUser(txtUsername.Text, txtPassword.Text);
                f.Show();
                this.Hide();
                
            }
            else MessageBox.Show("Đăng nhập thất bại");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
