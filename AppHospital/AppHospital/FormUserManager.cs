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
    public partial class FormUserManager : Form
    {
        private BUS_User busUser;
        public FormUserManager()
        {
            InitializeComponent();
        }

       public void Design()
        {
            
            cbRole.Items.Add("ROLE_ADMIN");
            cbRole.Items.Add("ROLE_DOCTOR");
            cbRole.Items.Add("ROLE_NURSE");
            cbRole.Text = "ROLE_ADMIN";

            cbActive.Items.Add("ALL");
            cbActive.Items.Add("Active");
            cbActive.Items.Add("Not active");
            cbActive.Text = "ALL";
        }

        
        private void GetAllUsers()
        {
            gVUser.DataSource = null;
            busUser.getUsers(gVUser,cbRole.Text, txtUserName.Text,cbActive.Text);
            gVUser.Columns[0].Width = (int)(gVUser.Width * 0.1);
            gVUser.Columns[1].Width = (int)(gVUser.Width * 0.2);
            gVUser.Columns[2].Width = (int)(gVUser.Width * 0.3);
            gVUser.Columns[3].Width = (int)(gVUser.Width * 0.1);
        }
        private void FormUserManager_Load(object sender, EventArgs e)
        {
            Design();
            busUser = new BUS_User();
            GetAllUsers();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GetAllUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chỉnh sửa thông tin?", "Chỉnh sửa bác sĩ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
               

                    User u = new User();
                    u.ID = int.Parse(txtID.Text);
                    u.Active = radioActive.Checked;


                    if (busUser.EditUser(u))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        GetAllUsers();

                    }
                    else MessageBox.Show("Chỉnh sửa thất bại");
             
               
            }
            else MessageBox.Show("Hãy chắc chắn khi bạn muốn sửa vào lần sau!");
        }
    }
}
