using System;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.IO;

namespace RentalMobil
{
    public partial class FormPayment : Form
    {
        public string invoice_number;
        public string id_payment;

        public FormPayment()
        {
            InitializeComponent();

        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            invoice_number_bayar.Text = this.invoice_number;
        }

        private void btn_simpan_payment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Data sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (db_rental_mobilEntities ctx = new db_rental_mobilEntities())
                {
                    var updateOrder = ctx.Database.ExecuteSqlCommand("UPDATE orders SET status = 'PAID' WHERE invoice_number = @invoice_number",
                       new SqlParameter("invoice_number", this.invoice_number)
                    );

                    var updatePayment = ctx.Database.ExecuteSqlCommand("UPDATE payments SET waktu_bayar = @waktu_bayar, nama_rekening = @nama_rekening, nominal = @nominal, nama_bank = @nama_bank, nomor_rekening = @nomor_rekening WHERE id_payment = @id_payment",
                       new SqlParameter("id_payment", this.id_payment),
                       new SqlParameter("nama_bank", this.cb_bank.Text),
                       new SqlParameter("nomor_rekening", this.tb_no_rekening.Text),
                       new SqlParameter("nama_rekening", this.tb_atas_nama.Text),
                       new SqlParameter("nominal", this.tb_nominal.Text),
                       new SqlParameter("waktu_bayar", DateTime.Now)
                    );
                }

                this.DialogResult = DialogResult.No;
              
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Yakin membatalkan order anda?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (db_rental_mobilEntities ctx = new db_rental_mobilEntities())
                {
                    var updateOrder = ctx.Database.ExecuteSqlCommand("UPDATE orders SET status = 'READY' WHERE invoice_number = @invoice_number",
                       new SqlParameter("invoice_number", this.invoice_number)
                    );

                    if (updateOrder != 0)
                    {
                        MessageBox.Show("Order anda sudah dibatalkan");
                        this.DialogResult = DialogResult.No;
                    }
                }
            }
       }
    }
}
