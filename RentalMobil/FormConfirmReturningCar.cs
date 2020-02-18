using System;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.IO;

namespace RentalMobil
{
    public partial class FormConfirmReturningCar : Form
    {
        protected string invoice_number;
        protected int id_payment;
        protected DateTime waktu_kembali;

        public FormConfirmReturningCar(string inv, DateTime waktu_kembali, int id_payment)
        {
            this.invoice_number = inv;
            this.id_payment = id_payment;
            this.waktu_kembali = waktu_kembali;

            InitializeComponent();
        }

        private void FormConfirmReturningCar_Load(object sender, EventArgs e)
        {
            this.tanggal_konfirmasi.Value = this.waktu_kembali;
        }

        private void btn_simpan_payment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("apa anda yakin ?", "Konfirmasi pengembalian mobil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                double besaranDenda = denda();
                using (db_rental_mobilEntities ctx = new db_rental_mobilEntities())
                {
                    var updateOrder = 0;

                    if (besaranDenda > 0)
                    {
                        updateOrder = ctx.Database.ExecuteSqlCommand("UPDATE orders SET status = 'READY' WHERE invoice_number = @invoice_number",
                           new SqlParameter("invoice_number", this.invoice_number)
                        );

                        var updatePayment = ctx.Database.ExecuteSqlCommand("UPDATE payment SET denda = @denda WHERE id_payment = @id_payment",
                           new SqlParameter("id_payment", this.id_payment),
                           new SqlParameter("denda", besaranDenda)
                        );
                    }else
                    {
                        updateOrder = ctx.Database.ExecuteSqlCommand("UPDATE orders SET status = 'READY' WHERE invoice_number = @invoice_number",
                            new SqlParameter("invoice_number", this.invoice_number)
                        );
                    }


                    if (updateOrder != 0)
                    {
                        MessageBox.Show("Pengembalian telah berhasil");
                    }               
                }            
                this.DialogResult = DialogResult.No;              
            }
        }

        protected double denda(double dendaPerhari = 50000)
        {
            var cek = this.tanggal_konfirmasi.Value - this.waktu_kembali;
            int berapahari = cek.Days;
            double denda = berapahari * dendaPerhari;

            return denda;

        }
        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

            if (this.denda() > 0)
            {
                this.nominal_denda.Text = this.denda().ToString();
            }
            else
            {
                this.nominal_denda.Text = "Tidak ada denda";
            }
        }
    }
}
