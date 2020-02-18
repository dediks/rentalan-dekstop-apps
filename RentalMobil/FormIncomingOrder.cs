using System;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.IO;

namespace RentalMobil
{
    public partial class FormIncomingOrder : Form
    {
        public String[] rowData;

        public FormIncomingOrder(String[] rowData)
        {
            InitializeComponent();
            this.rowData = rowData;

            this.invoice_number_bayar.Text = rowData[0].ToString();
            this.lb_nama.Text = rowData[5].ToString();
            this.lb_unit_mobil.Text = rowData[1].ToString();
            this.lb_waktu_ambil.Text = rowData[3].ToString();
            this.lb_waktu_kembali.Text = rowData[4].ToString();
            this.lb_tgl_order.Text = rowData[6].ToString();
            this.lb_bayar.Text = rowData[7].ToString();
        }

        private void FormIncomingOrder_Load(object sender, EventArgs e)
        {
            invoice_number_bayar.Text = this.rowData[0].ToString();
        }

        private void btn_simpan_payment_Click(object sender, EventArgs e)
        {
            using (db_rental_mobilEntities ctx = new db_rental_mobilEntities())
            {
                var updateOrder= ctx.Database.ExecuteSqlCommand("UPDATE orders SET status = 'CONFIRMED' WHERE invoice_number = @invoice_number",
                   new SqlParameter("invoice_number", this.rowData[0].ToString())
                );              
            }

            this.DialogResult = DialogResult.No;

            //dg_payment_clear();
        }

        private void btn_cancel_payment_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
