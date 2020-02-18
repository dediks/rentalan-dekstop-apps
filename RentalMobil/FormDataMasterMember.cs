using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RentalMobil
{
    public partial class FormDataMasterMember : Form
    {
        public FormDataMasterMember()
        {
            InitializeComponent();
        }

        public void clearTxts()
        {
            tb_no_identitas_member.Text = "";
            tb_nama_member.Text = "";
            tb_username_member.Text = "";
            tb_email_member.Text = "";
            tb_password_member.Text = "";
            tb_no_telpon_member.Text = "";
            tb_alamat_member.Text = "";
        }

        private void FormDataMasterMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset_rental_mobil_member.members' table. You can move, or remove it, as needed.
            loadDataMembers();
        }

        public void loadDataMembers()
        {
            this.membersTableAdapter.Fill(this.dataset_rental_mobil_member.members);
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            tambahDataMember();
        }

        public void tambahDataMember()
        {
            String no_identitas = tb_no_identitas_member.Text;
            String nama = tb_nama_member.Text;
            String username = tb_username_member.Text;
            String email = tb_email_member.Text;
            String password = tb_password_member.Text;
            String no_telp = tb_no_telpon_member.Text;
            String alamat = tb_alamat_member.Text;

            if (nama != "" && no_identitas != "" && username != "" && email != "" && password != "" && no_telp != "" && alamat != "")
            {
                try
                {
                    using (db_rental_mobilEntities context = new db_rental_mobilEntities())
                    {
                        var member = new members();

                        member.nama = nama;
                        member.no_identitas = no_identitas;
                        member.email = email;
                        member.username = username;
                        member.password = password;
                        member.no_telp = no_telp;
                        member.alamat = alamat;
                        context.members.Add(member);
                        context.SaveChanges();

                        MessageBox.Show("Member berhasil ditambhkan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearTxts();

                    }
                }
                catch
                {
                    MessageBox.Show("Gagal menambahkan member!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ada field kosong!. Mohon isi semua borang", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_browse_gambar_member_Click(object sender, EventArgs e)
        {
           
        }

        private void dataMember4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInputDataMember.Hide();
            panelListMember.Show();
        }

        private void dg_member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void btn_delete_member_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus? ", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int index = dg_member.SelectedRows[0].Index;
                int id = (int)dg_member.SelectedRows[0].Cells[0].Value;

                if (deleteDataMember(id))
                {
                    dg_member.Rows.RemoveAt(index);
                };
            }
        }

        private void btn_update_member_Click(object sender, EventArgs e)
        {
            if (dg_member.SelectedRows.Count > 0)
            {
                panelInputDataMember.Hide();
                panelListMember.Hide();
                panelEditMember.Show();

                tb_edit_no_identitas_member.Text = dg_member.SelectedRows[0].Cells[1].Value.ToString();
                tb_edit_nama_member.Text = dg_member.SelectedRows[0].Cells[2].Value.ToString();
                tb_edit_username_member.Text = dg_member.SelectedRows[0].Cells[3].Value.ToString();
                tb_edit_email_member.Text = dg_member.SelectedRows[0].Cells[4].Value.ToString();
                tb_edit_password_member.Text = dg_member.SelectedRows[0].Cells[5].Value.ToString();
                tb_edit_no_telpon_member.Text = dg_member.SelectedRows[0].Cells[6].Value.ToString();
                tb_edit_alamat_member.Text = dg_member.SelectedRows[0].Cells[7].Value.ToString();
            }else { 
                    MessageBox.Show("Anda Belum Memilih!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        public Boolean deleteDataMember(int id)
        {
            try
            {
                using (db_rental_mobilEntities context = new db_rental_mobilEntities())
                {
                    var member_deleted = (from member in context.members where member.id_member == id select member).Single();
                    context.members.Remove(member_deleted);
                    context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Gagal menghapus member!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public void updateDataMember(int id)
        {
            if (dg_member.SelectedRows.Count > 0)
            {
                String no_identitas = tb_edit_no_identitas_member.Text;
                String nama = tb_edit_nama_member.Text;
                String username = tb_edit_username_member.Text;
                String email = tb_edit_email_member.Text;
                String password = tb_edit_password_member.Text;
                String no_telp = tb_edit_no_telpon_member.Text;
                String alamat = tb_edit_alamat_member.Text;

                if (no_identitas != "" && nama != "" && username != "" && email != "" && password != "" && no_telp != "" && alamat != "")
                {
                    try
                    {
                        using (db_rental_mobilEntities contextMember = new db_rental_mobilEntities())
                        {
                            var member = (from a in contextMember.members where a.id_member == id select a).Single();

                            member.no_identitas = no_identitas;
                            member.nama = nama;
                            member.username = username;
                            member.email = email;
                            member.password = password;
                            member.no_telp = no_telp;
                            member.alamat = alamat;

                            contextMember.SaveChanges();

                            MessageBox.Show("Member berhasil diedit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            panelEditMember.Hide();
                            panelListMember.Show();

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Gagal mengedit member!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Borang ada yang kosong!");
                }
            }            
        }


        private void inputMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelListMember.Hide();
            panelEditMember.Hide();
            panelInputDataMember.Show();
        }

        private void panelEditMember_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelListMember_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_save_edit_Click(object sender, EventArgs e)
        {
            int id_member = (int)dg_member.SelectedRows[0].Cells[0].Value;
           // MessageBox.Show(""+id_member);
            updateDataMember(id_member);
            loadDataMembers();
        }

        private void panelListMember_Paint_1(object sender, PaintEventArgs e)
        {
            dg_member.AllowUserToAddRows = false;
        }
    }
}
