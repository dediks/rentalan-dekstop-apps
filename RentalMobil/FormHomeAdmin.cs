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
    public partial class FormHomeAdmin : Form
    {
        FormDataMasterMobil formDataMasterMobil;
        FormDataMasterMember formDataMasterMember;

        public FormHomeAdmin()
        {
            InitializeComponent();

        }

        private void FormHomeAdmin_Load(object sender, EventArgs e)
        {
            this.loadDataPayments();
        }


        protected void loadDataPayments()
        {
            // TODO: This line of code loads data into the 'db_rental_mobil_payments_new.view_for_payments' table. You can move, or remove it, as needed.
            this.view_for_paymentsTableAdapter.Fill(this.db_rental_mobil_payments_new.view_for_payments);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
      
        private void mOBILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDataMasterMobil == null)
            {
                formDataMasterMobil = new FormDataMasterMobil();
                formDataMasterMobil.ShowDialog(this);
                //formDataMasterMobil.MdiParent = this;
               // formDataMasterMobil.Show();
            }
            else
            {
                formDataMasterMobil.Activate();
                formDataMasterMobil.ShowDialog(this);
                //  formDataMasterMobil.Show();
            }
           
        }

        private void ms_member_data_master_Click(object sender, EventArgs e)
        {
            if (formDataMasterMember == null)
            {
                formDataMasterMember = new FormDataMasterMember();
                formDataMasterMember.ShowDialog(this);
            }
            else
            {
                formDataMasterMember.Activate();
                formDataMasterMember.ShowDialog(this);
            }
        }

        main_form formLogin;
        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = null;

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

        private void btn_incoming_orders_Click(object sender, EventArgs e)
        {
            this.tab_admin.SelectedTab = this.tab_incoming_order;

        }

        private void btn_orders_history_Click(object sender, EventArgs e)
        {
            this.tab_admin.SelectedTab = this.tab_order_history;
        }

        private void tab_incoming_order_Click(object sender, EventArgs e)
        {

        }


        public void dg_incoming_order_refresh()
        {
            this.loadDataPayments();

            foreach (DataGridViewRow row in dg_incoming_order.Rows)
            {
                var status = row.Cells["status_order"].Value.ToString();

                if (status != "PAID")
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dg_incoming_order.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();

                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    row.Selected = false;
                }
            }

            dg_incoming_order.Update();
            dg_incoming_order.Refresh();
        }

        public void dg_order_history_refresh()
        {
            this.loadDataPayments();

            foreach (DataGridViewRow row in dg_order_history.Rows)
            {
                var status = row.Cells["status_order_history"].Value.ToString();

                if (status != "CONFIRMED")
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dg_order_history.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                    row.Selected = false;
                }
            }

            dg_order_history.Update();
            dg_order_history.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.dg_incoming_order_refresh();
        }

        private void dg_incoming_order_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dg_incoming_order.Rows[e.RowIndex];

                IList<string> rowData = new List<string>();

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    rowData.Add(row.Cells[i].Value.ToString());
                }

                FormIncomingOrder formIncomingOrder = new FormIncomingOrder(rowData.ToArray());
                var a = formIncomingOrder.ShowDialog(this);

                this.dg_incoming_order_refresh();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.dg_order_history_refresh();
        }

        private void dg_incoming_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
