using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMobil
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = tb_username.Text;
            Boolean is_admin = cb_admin.Checked;

            using (db_rental_mobilEntities context = new db_rental_mobilEntities())
            {
                if (!is_admin)
                {

                    var verif_username = context.members.FirstOrDefault(u => u.username == username);

                    if (verif_username != null)
                    {
                        String password = tb_password.Text;

                        var verif_password = context.members.FirstOrDefault(u => u.password == password);
                        if (verif_password != null)
                        {

                            //MessageBox.Show("Berhasil masuk");

                            this.Hide();

                            LoginInfo.UserID = username;

                            FormHomeMembers formHomeMember = new FormHomeMembers();
                            formHomeMember.Show();
                            formHomeMember.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Password Anda salah!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username anda salah");
                    }
                }
                else
                {
                    var verif_username = context.admins.FirstOrDefault(u => u.username == username);

                    if (verif_username != null)
                    {
                        String password = tb_password.Text;

                        var verif_password = context.admins.FirstOrDefault(u => u.password == password);

                        if (verif_password != null)
                        {
                            //MessageBox.Show("Berhasil masuk anda Admin");
                            this.Hide();

                            FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
                            formHomeAdmin.Show();
                            formHomeAdmin.Focus();

                        }
                        else
                        {
                            MessageBox.Show("Password Admin Anda salah!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Admin anda salah");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
