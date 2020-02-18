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
    public partial class FormHomeMembers : Form
    {

        public FormHomeMembers()
        {
            InitializeComponent();
            dp_ambil.Value = DateTime.Now;
            dp_kembali.Value = DateTime.Now.AddDays(1);
        }

        private void FormHomeMembers_Load(object sender, EventArgs e)
        {

            // this.view_for_paymentsTableAdapter1.Fill(this.db_rental_mobil_payments1.view_for_payments);
            //            this.view_order_fullTableAdapter.Fill(this.db_rental_mobil_rents_history.view_order_full);
            //            this.view_cars_ready_for_orderTableAdapter.Fill(this.db_rental_mobilDataSet3.view_cars_ready_for_order);
            // TODO: This line of code loads data into the 'dataset_rental_mobil_member.members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.dataset_rental_mobil_member.members);

            this.loadDataPayments();
            tab_control_list_mobil.Visible = true;
            tab_control_list_mobil.Show();
        }

        private void loadDataPayments()
        {
            this.view_for_paymentsTableAdapter2.Fill(this.db_rental_mobil_payments_new.view_for_payments);
            this.view_for_paymentsTableAdapter.Fill(this.db_rental_mobil_payments.view_for_payments);
        }

        FormSearchReadyCars fsrc;
        private void btn_cari_mobil_Click(object sender, EventArgs e)
        {
            DateTime tgl_ambil = dp_ambil.Value;
            DateTime tgl_kembali = dp_kembali.Value;
            DateTime tgl_hari_ini = DateTime.Now;

            //catat tanggal ambil dan kembali

            Order.waktu_ambil = tgl_ambil;
            Order.waktu_kembali = tgl_kembali;
            Order.order_date = tgl_hari_ini;

            if (tgl_ambil != tgl_kembali && tgl_kembali > tgl_ambil)
            {
                var selisih_hari = tgl_kembali - tgl_ambil;

                int hari = Convert.ToInt32(selisih_hari.Days);

                if (fsrc == null)
                {
                    fsrc = new FormSearchReadyCars(hari);

                    var y = fsrc.ShowDialog(this);

                    if (y.ToString() == "Abort")
                    {
                        this.tab_control_list_mobil.SelectedTab = this.tab_control_payments;
                    }
                    else if (y.ToString() == "No")
                    {
                        this.tab_control_list_mobil.SelectedTab = this.make_rents_tab_control;
                    }
                }
                else
                {
                    fsrc.Activate();
                    var y = fsrc.ShowDialog(this);

                    if (y.ToString() == "Abort")
                    {
                        this.tab_control_list_mobil.SelectedTab = this.tab_control_payments;
                    }
                    else if (y.ToString() == "No")
                    {
                        this.tab_control_list_mobil.SelectedTab = this.make_rents_tab_control;
                    }
                }

                // checkKetersediaan();

                jumlah_hari.Text = selisih_hari.ToString();
            }
            else
            {
                MessageBox.Show("Tanggal Kembali harus lebih besar");
                jumlah_hari.Text = "0";
            }
        }

        protected void checkKetersediaan()
        {
            panel_home.Hide();
            tab_control_list_mobil.Show();
        }

        private void dp_ambil_onValueChanged(object sender, EventArgs e)
        {

        }

        public Image ConverByteToImage(byte[] photo)
        {
            Image newImage;

            using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true);
            }

            return newImage;
        }

        public byte[] ConvertFiletoByte(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);

            return data;
        }

        private void panel_home_Paint(object sender, PaintEventArgs e)
        {
            // tab_control_list_mobil.Hide();
            //            dp_ambil.Value = DateTime.Now;
            //          dp_kembali.Value = DateTime.Now.AddDays(1);           
        }

        void pilihMobilButton_Click(object sender, EventArgs e)
        {
            String buttonID = ((Button)sender).Name;

            MessageBox.Show("ID Button " + buttonID);
        }

        private void btn_incoming_orders_Click(object sender, EventArgs e)
        {
            panel_home.Show();

            this.tab_control_list_mobil.SelectedTab = this.make_rents_tab_control;
        }

        private void pencarian_mobil_Click(object sender, EventArgs e)
        {

        }

        FormProfilMember profilMember;
        private void pROFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (profilMember == null)
            {
                profilMember = new FormProfilMember();

                profilMember.ShowDialog(this);
            }
            else
            {
                profilMember.Activate();
                profilMember.ShowDialog(this);
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_home.Show();
        }

        main_form formLogin;
        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginInfo.IDMember = null;

            if (formLogin == null)
            {
                formLogin = new main_form();
                formLogin.Show();
            }
            else
            {
                formLogin.Activate();
                formLogin.Show();
            }

            this.Hide();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_cars_ready_for_orderTableAdapter.FillBy(this.db_rental_mobilDataSet3.view_cars_ready_for_order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_cars_ready_for_orderTableAdapter.FillBy1(this.db_rental_mobilDataSet3.view_cars_ready_for_order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_order_fullTableAdapter.FillBy(this.db_rental_mobil_rents_history.view_order_full);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void new_query_cars_ready_for_rentToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.carsTableAdapter.new_query_cars_ready_for_rent(this.db_rental_mobil_SEMUA_TABLE.cars);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void new_searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.carsTableAdapter1.new_search(this.db_rental_mobilDataSet2.cars);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void new_query_cars_ready_for_rentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel_rents_history_Paint_1(object sender, PaintEventArgs e)
        {
            this.dg_payment_clear();
        }

        public void dg_payment_clear()
        {
            this.loadDataPayments();

            foreach (DataGridViewRow row in dg_payments.Rows)
            {
                var status = row.Cells["status_order"].Value.ToString();

                if (status != "PAID" && status != "UNPAID" && status != "PENDING")
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dg_payments.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }

                if (status == "PAID")
                {
                    row.Cells["action_payments"].ReadOnly = true;
                    //row.Cells["status_order"].Value = "PENDING";
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    row.Selected = false;
                }
            }

            dg_payments.Update();
            dg_payments.Refresh();
        }

        public void dg_rent_clear()
        {
            this.loadDataPayments();

            foreach (DataGridViewRow row in dg_rents.Rows)
            {
                var status = row.Cells[6].Value.ToString();

                if ( status != "CONFIRMED" && status != "READY")
                {
                    CurrencyManager currencyManager2 = (CurrencyManager)BindingContext[dg_rents.DataSource];
                    currencyManager2.SuspendBinding();
                    row.Visible = false;
                    currencyManager2.ResumeBinding();
                    
                }

                if (status == "READY")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    row.Cells[6].Value = "Terkembalikan";
                }

                if (status == "CONFIRMED")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    row.Cells[6].Value = "Terbooking";
                }
            }

            dg_rents.Update();
            dg_rents.Refresh();

        }

        private void tab_control_rents_history_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.dg_rent_clear();

        }

        FormPayment formPayment;

        private void dg_payments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void tab_control_payments_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.loadDataPayments();
            dg_payments.Update();
            dg_payments.Refresh();
        }

        private void dg_payments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dg_payments_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
        private void dg_payments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_orders_history_Click(object sender, EventArgs e)
        {
            this.tab_control_list_mobil.SelectedTab = this.tab_control_rents_history;          
        }

        private void btn_payments_Click(object sender, EventArgs e)
        {
            this.tab_control_list_mobil.SelectedTab = this.tab_control_payments;
        }

        private void dp_kembali_onValueChanged(object sender, EventArgs e)
        {
            DateTime tgl_ambil = dp_ambil.Value;
            DateTime tgl_kembali = dp_kembali.Value;


            if (tgl_ambil != tgl_kembali && tgl_kembali > tgl_ambil)
            {
                var selisih_hari = tgl_kembali - tgl_ambil;
                this.jumlah_hari.Text = selisih_hari.ToString();
            }
        }
        private void jumlah_hari_Click(object sender, EventArgs e)
        {

        }

        private void dg_payments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dg_payments.Rows[e.RowIndex];

                if (row.Cells["status_order"].Value.ToString() == "PAID")
                {
                    return;
                }

                var id_payment = row.Cells["id_payment_dg_payment"].Value.ToString();
                var invoice_number = row.Cells["in_dg_payments"].Value.ToString();

                formPayment = new FormPayment();
                formPayment.id_payment = id_payment;
                formPayment.invoice_number = invoice_number;
                formPayment.ShowDialog(this);

                dg_payment_clear();
            }
        }

        private void dg_rents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_rents.Rows[e.RowIndex];


                if (row.Cells["status_konifirmasi"].Value.ToString() == "Terkembalikan")
                {
                    return;
                }

                var invoice_number = row.Cells["invoicenumberDataGridViewTextBoxColumn"].Value.ToString();
                var id_payment = row.Cells["id_payment"].Value;
                int id_payments = Convert.ToInt32(id_payment);
                DateTime waktu_kembali = (DateTime)row.Cells["waktu_kembali_mobil"].Value;

                FormConfirmReturningCar formPengembalian = new FormConfirmReturningCar(invoice_number, waktu_kembali, id_payments);
                formPengembalian.ShowDialog(this);

                dg_rent_clear();
            }
        }

        private void dg_rents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tab_control_list_mobil_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tab_control_list_mobil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
