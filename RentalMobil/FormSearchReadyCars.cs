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
using System.Data.SqlClient;

namespace RentalMobil
{
    public partial class FormSearchReadyCars : Form
    {

        protected int jumlah_hari;
        public FormSearchReadyCars(int jumlah_hari)
        {
            this.jumlah_hari = jumlah_hari;
            InitializeComponent();
  
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        private void enableElement()
        {
            dp_ambil_search.Show();
            btn_car_mobil_by_filter.Show();
            tb_nama_search.Show();
            tb_vendor_search.Show();
            dp_kembali_search.Show();
            cb_transmisi_mobil.Show();
        }

        private void disabledElement()
        {
           // btn_car_mobil_by_filter.Enabled = false;
            //dp_ambil_search.Enabled = false;
            //tb_nama_search.Enabled = false;
            //tb_vendor_search.Enabled = false;
//            dp_kembali_search.Enabled = false;

            dp_ambil_search.Hide();
            btn_car_mobil_by_filter.Hide();
            tb_nama_search.Hide();
            tb_vendor_search.Hide();
            dp_kembali_search.Hide();
            cb_transmisi_mobil.Hide();
        }

        String car_id = null;
        int invoice_number;
        void pilihMobilButton_Click(object sender, EventArgs e)
        {

            car_id = ((Button)sender).Name;

            DialogResult dialogResult = MessageBox.Show("Yakin milih ini? dan lanjut ke pembayaran?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.panel1.Hide();
                this.panelPayment.Visible = true;
                this.panelPayment.Show();

                disabledElement();

                int id_mobil = int.Parse(car_id);
                invoice_number = int.Parse(generateInvoice());
                insertOrdersData(id_mobil, invoice_number);
            }
            else if (dialogResult == DialogResult.No)
            {
                //                this.panel1.Hide();
                panelPayment.Hide();
            }          
        }

        private void insertOrdersData(int car_id, int invoice_number)
        {
         //   try
           // {
                using (db_rental_mobilEntities ctx = new db_rental_mobilEntities())
                {

                    var member = ctx.members.Where(m => m.username == LoginInfo.UserID ).FirstOrDefault<members>();
                    var car = ctx.cars.Where(c => c.id_mobil == car_id).FirstOrDefault<cars>();

                    int id_member = member.id_member;

                    var total_price = car.harga_sewa * this.jumlah_hari;
                    var order_date = Order.order_date;
                    var id_admin = 1;
                    var status = "UNPAID";


                        var insertOrder = ctx.Database.ExecuteSqlCommand("INSERT INTO orders(id_member, total_price, invoice_number, tgl_order, id_admin, status) VALUES(@id_member, @total_price, @invoice_number, @order_date, @admin_id, @status)",
                            new SqlParameter("id_member", id_member), new SqlParameter("total_price", total_price),
                            new SqlParameter("invoice_number", invoice_number), new SqlParameter("order_date", order_date),
                            new SqlParameter("admin_id", id_admin), new SqlParameter("status", status)
                        );
                    
                        if ( insertOrder == 1) 
                        {
                            var cari_oder_record = ctx.orders.Where(o => o.invoice_number == invoice_number.ToString()).FirstOrDefault<orders>();

                            var jumlah = 1;
                            var waktu_kembali = Order.waktu_kembali;
                            var waktu_ambil = Order.waktu_ambil;

                            var insertCarOrder = ctx.Database.ExecuteSqlCommand("INSERT INTO order_car(id_order, id_car, jumlah, waktu_ambil, waktu_kembali) VALUES(@id_order, @id_car, @jumlah, @waktu_ambil, @waktu_kembali)",
                                new SqlParameter("id_order", cari_oder_record.id_order), new SqlParameter("id_car", car_id),
                                new SqlParameter("jumlah", jumlah), new SqlParameter("waktu_kembali", waktu_kembali),
                                new SqlParameter("waktu_ambil", waktu_ambil)
                                );

                            var insertToPayment = ctx.Database.ExecuteSqlCommand("INSERT INTO payments(id_admin, id_member, id_order) VALUES(@id_admin, @id_member, @id_order)",
                                new SqlParameter("id_admin", id_admin), 
                                new SqlParameter("id_member", id_member),
                                new SqlParameter("id_order", cari_oder_record.id_order)
                            );
                        }
                    }
            
          //  catch {};
        }

        private void pencarian_mobil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dp_ambil_search.Value = DateTime.Now;
            dp_kembali_search.Value = DateTime.Now.AddDays(1);
        }

//        FormHomeMembers formMember;
        private void FormSearchReadyCars_Load_1(object sender, EventArgs e)
        {
            this.panelPayment.Visible = false;
            this.panel1.Show();

            using (db_rental_mobilEntities context = new db_rental_mobilEntities())
            {

                var result = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status != 'READY')").ToList();

                searchMobil(result);
            }
        }

        private void searchMobil(List<CarsReadyForRent> mobil_ready)
        {
            FLP_list_mobil_ready.Controls.Clear();

            try
            {               
                    foreach (var item in mobil_ready.ToList())
                    {
                        String value = item.id_mobil.ToString();

                        Panel panel = new Panel();
                        PictureBox pb = new PictureBox();
                        Label nama = new Label();
                        Label vendor = new Label();
                        Label harga_sewavendor = new Label();
                        Label transmisi = new Label();
                        Label bagasi = new Label();
                        Label deskripsi = new Label();
                        Label deskripsi_value = new Label();


                        panel.Name = value + "panel";
                        panel.Size = new Size(840, 150);
                        panel.BackColor = Color.WhiteSmoke;
                        panel.Margin = new Padding(1);
                        panel.Dock = System.Windows.Forms.DockStyle.None;

                        pb.Name = value + "pb";
                        pb.Size = new Size(150, 150);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Dock = System.Windows.Forms.DockStyle.None;
                        if (item.image != null)
                        {
                            pb.Image = ConverByteToImage((byte[])item.image);
                        }

                        nama.Name = value + "lb";
                        nama.Text = item.nama;
                        nama.ForeColor = Color.DarkSlateGray;
                        nama.Left = 170;
                        nama.Top = 15;
                        nama.AutoSize = true;
                        nama.Font = new Font(nama.Font.FontFamily, 11, FontStyle.Bold);


                        vendor.Name = value + "vendor";
                        vendor.Text = "Vendor : " + item.vendor;
                        vendor.ForeColor = Color.DarkSlateGray;
                        vendor.Left = 170;
                        vendor.AutoSize = true;
                        vendor.Top = 60;
                        vendor.Font = new Font(vendor.Font, FontStyle.Bold);

                        transmisi.Name = value + "transmisi";
                        transmisi.Text = "Transmisi : " + item.transmisi;
                        transmisi.ForeColor = Color.DarkSlateGray;
                        transmisi.Width = 200;
                        transmisi.Left = 170;
                        transmisi.AutoSize = true;
                        transmisi.Top = 80;
                        transmisi.Font = new Font(transmisi.Font, FontStyle.Bold);

                        bagasi.Name = value + "bagasi";
                        bagasi.Text = "Bagasi : " + item.bagasi;
                        bagasi.ForeColor = Color.DarkSlateGray;
                        bagasi.Left = 170;
                        bagasi.AutoSize = true;
                        bagasi.Top = 100;
                        bagasi.Font = new Font(bagasi.Font, FontStyle.Bold);

                        deskripsi.Name = value + "deskripsi";
                        deskripsi.Text = "Deskripsi : ";
                        deskripsi.ForeColor = Color.DarkSlateGray;
                        deskripsi.Left = 400;
                        deskripsi.Top = 50;
                        deskripsi.AutoSize = true;
                        deskripsi.Font = new Font(deskripsi.Font, FontStyle.Bold);

                        FlowLayoutPanel deskripsi_box = new FlowLayoutPanel();
                        deskripsi_box.Controls.Clear();
                        deskripsi_box.Name = "deskripsi_box" + value;
                        deskripsi_box.Left = 400;
                        deskripsi_box.Top = 80;
                        deskripsi_box.Width = 250;
                        deskripsi_box.Height = 100;

                        deskripsi_value.Name = value + "deskripsi_value";
                        deskripsi_value.Text = item.deskripsi;
                        deskripsi_value.ForeColor = Color.DarkSlateGray;
                        deskripsi_value.Left = 10;
                        deskripsi_value.Top = 10;
                        deskripsi_value.AutoSize = true;
                        deskripsi_value.Font = new Font(deskripsi_value.Font, FontStyle.Regular);


                        Label harga_sewa = new Label();
                        harga_sewa.Name = value + "harga_sewa";
                        harga_sewa.Text = "Rp. " + item.harga_sewa.ToString() + "/Hari";
                        harga_sewa.ForeColor = Color.DarkSlateGray;
                        harga_sewa.Left = 710;
                        harga_sewa.AutoSize = true;
                        harga_sewa.Top = 70;
                        harga_sewa.Font = new Font(harga_sewa.Font, FontStyle.Bold);

                        Button button = new Button();

                        button.Name = item.id_mobil.ToString();
                        button.Size = new Size(100, 30);
                        button.Text = "Pilih";
                        button.BackColor = Color.ForestGreen;
                        button.Font = new Font(button.Font.FontFamily, 11);
                        button.ForeColor = Color.WhiteSmoke;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Left = 720;
                        button.Top = 95;


                    //MessageBox.Show("Sampai sini : " + item.status);

                    //Console.WriteLine(item.status);

                    //if (item.status == "UNPAID")
                    //    {
                           
                    //        button.Enabled = false;
                    //        button.BackColor = Color.Gray;
                    //    }

                        button.Click += pilihMobilButton_Click;

                        panel.Controls.Add(harga_sewa);
                        panel.Controls.Add(nama);
                        panel.Controls.Add(vendor);
                        panel.Controls.Add(pb);
                        panel.Controls.Add(bagasi);
                        panel.Controls.Add(deskripsi);
                        panel.Controls.Add(transmisi);
                        panel.Controls.Add(button);
                        panel.Controls.Add(deskripsi_box);
                        deskripsi_box.Controls.Add(deskripsi_value);
                        FLP_list_mobil_ready.Controls.Add(panel);

                }
            }
            catch
            {
                MessageBox.Show("Gagal Menampilkan");
            }

        }

        private void btn_car_mobil_by_filter_Click(object sender, EventArgs e)
        {
            String transmisi = cb_transmisi_mobil.Text;
            String vendor = tb_vendor_search.Text;
            String nama = tb_nama_search.Text;

            List<CarsReadyForRent>  c = cari_mobil(nama, vendor, transmisi);
            
            if(c != null)
            {
                searchMobil(c);
            }
        }

        protected List<CarsReadyForRent> cari_mobil(String nama, String vendor, String transmisi)
        {
            using (db_rental_mobilEntities context = new db_rental_mobilEntities() )
            {
                if (nama != "" && vendor != "" && transmisi != "")
                {
                    var mobil_ready = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where nama LIKE '%'+@nama+ '%' AND vendor LIKE '%'+@vendor+ '%' AND transmisi LIKE '%'+@transmisi+ '%' AND id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status = 'READY')", new SqlParameter("@vendor", vendor), new SqlParameter("@nama", nama), new SqlParameter("@transmisi", transmisi)).ToList();
                    return mobil_ready;
                }

            if (nama != "" && vendor != "")
            {
                var mobil_ready = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where vendor LIKE '%'+@vendor+ '%' AND nama LIKE '%'+@nama+ '%' AND id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status = 'READY')", new SqlParameter("@nama", nama), new SqlParameter("@vendor", vendor)).ToList();
                    return mobil_ready;
            }

            if (nama != "" && transmisi != "")
            {
                var mobil_ready = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where nama LIKE '%'+@nama+ '%' AND transmisi LIKE '%'+@transmisi+ '%' AND id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status = 'READY')", new SqlParameter("@nama", nama), new SqlParameter("@transmisi", transmisi)).ToList();
                    return mobil_ready;
            }

            if (vendor != "" && transmisi != "")
            {
                var mobil_ready = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where vendor LIKE '%'+@vendor+ '%' AND transmisi LIKE '%'+@transmisi+ '%' AND id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status = 'READY')", new SqlParameter("@vendor", vendor), new SqlParameter("@transmisi", transmisi)).ToList();
                    return mobil_ready;
            }

            if (vendor != "")
            {
                var mobil_ready = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where vendor LIKE '%'+@vendor+ '%' AND id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status = 'READY')", new SqlParameter("@vendor", vendor)).ToList();
                    return mobil_ready;
            }

            if (nama != "")
            {
                var mobil_ready = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where nama LIKE '%'+@nama+ '%' AND id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status = 'READY')", new SqlParameter("@nama", nama)).ToList();
                    return mobil_ready;
            }

            if (transmisi != "")
            {
                var mobil_ready = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where transmisi LIKE '%'+@transmisi+ '%' AND id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status = 'READY')", new SqlParameter("@transmisi", transmisi)).ToList();

                    return mobil_ready;
            }
            else
            {
                var mobil_ready = context.Database.SqlQuery<CarsReadyForRent>("SELECT * FROM cars where id_mobil NOT IN(SELECT oc.id_car from order_car oc left join orders o on oc.id_order = o.id_order where o.status = 'READY')").ToList();
                    return mobil_ready;
            }
            }

        }

        private void dp_ambil_search_onValueChanged(object sender, EventArgs e)
        {

        }

        private void menu_ke_home_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;

            this.enableElement();

        }

        private string generateInvoice()
        {
            Random generator = new Random();
            String r = generator.Next(0, 999999).ToString("D6");

            return r;
        }
        private void panelPayment_Paint(object sender, PaintEventArgs e)
        {
            this.lb_invoice.Text = invoice_number.ToString();
            this.lb_tgl_order.Text = DateTime.Now.ToString();

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void menu_ke_payment_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;

        }
    }
}
