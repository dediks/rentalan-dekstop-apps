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
    public partial class FormProfilMember : Form
    {
        public FormProfilMember()
        {
            InitializeComponent();
        }

        private void FormProfilMember_Load(object sender, EventArgs e)
        {
            using (db_rental_mobilEntities ctx = new db_rental_mobilEntities())
            {
                var member = ctx.members.Where(a=> a.id_member == 1);

                foreach (var detail_member in member.ToList())
                {
                    this.no_identitas.Text = detail_member.no_identitas.ToString();
                    this.nama_member.Text = detail_member.nama.ToString();
                    this.alamat_member.Text = detail_member.alamat.ToString();
                    this.no_telp_member.Text = detail_member.no_telp.ToString();
                    this.id_member.Text = detail_member.id_member.ToString();
                    this.username_member.Text = detail_member.username.ToString();
                    this.email_member.Text = detail_member.email.ToString();
                }
            }
        }
    }
}
