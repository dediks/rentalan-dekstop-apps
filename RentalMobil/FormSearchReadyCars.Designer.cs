namespace RentalMobil
{
    partial class FormSearchReadyCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchReadyCars));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_control_list_mobil_ready = new System.Windows.Forms.TabControl();
            this.pencarian_mobil = new System.Windows.Forms.TabPage();
            this.FLP_list_mobil_ready = new System.Windows.Forms.FlowLayoutPanel();
            this.dp_ambil_search = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dp_kembali_search = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tb_nama_search = new System.Windows.Forms.TextBox();
            this.tb_vendor_search = new System.Windows.Forms.TextBox();
            this.btn_car_mobil_by_filter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_transmisi_mobil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.lb_tgl_order = new System.Windows.Forms.Label();
            this.lb_invoice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu_ke_payment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_ke_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.tab_control_list_mobil_ready.SuspendLayout();
            this.pencarian_mobil.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tab_control_list_mobil_ready);
            this.panel1.Location = new System.Drawing.Point(186, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 628);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tab_control_list_mobil_ready
            // 
            this.tab_control_list_mobil_ready.Controls.Add(this.pencarian_mobil);
            this.tab_control_list_mobil_ready.Location = new System.Drawing.Point(4, 3);
            this.tab_control_list_mobil_ready.Name = "tab_control_list_mobil_ready";
            this.tab_control_list_mobil_ready.SelectedIndex = 0;
            this.tab_control_list_mobil_ready.Size = new System.Drawing.Size(1165, 682);
            this.tab_control_list_mobil_ready.TabIndex = 13;
            // 
            // pencarian_mobil
            // 
            this.pencarian_mobil.Controls.Add(this.FLP_list_mobil_ready);
            this.pencarian_mobil.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_mobil.Location = new System.Drawing.Point(4, 25);
            this.pencarian_mobil.Name = "pencarian_mobil";
            this.pencarian_mobil.Padding = new System.Windows.Forms.Padding(3);
            this.pencarian_mobil.Size = new System.Drawing.Size(1157, 653);
            this.pencarian_mobil.TabIndex = 0;
            this.pencarian_mobil.Text = "Hasil Pencarian";
            this.pencarian_mobil.UseVisualStyleBackColor = true;
            // 
            // FLP_list_mobil_ready
            // 
            this.FLP_list_mobil_ready.AutoScroll = true;
            this.FLP_list_mobil_ready.Location = new System.Drawing.Point(6, 6);
            this.FLP_list_mobil_ready.Name = "FLP_list_mobil_ready";
            this.FLP_list_mobil_ready.Size = new System.Drawing.Size(1152, 594);
            this.FLP_list_mobil_ready.TabIndex = 0;
            this.FLP_list_mobil_ready.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // dp_ambil_search
            // 
            this.dp_ambil_search.BackColor = System.Drawing.Color.White;
            this.dp_ambil_search.BorderRadius = 0;
            this.dp_ambil_search.Font = new System.Drawing.Font("Lato", 4F);
            this.dp_ambil_search.ForeColor = System.Drawing.Color.Black;
            this.dp_ambil_search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_ambil_search.FormatCustom = "dd/MM";
            this.dp_ambil_search.Location = new System.Drawing.Point(3, 33);
            this.dp_ambil_search.Margin = new System.Windows.Forms.Padding(4);
            this.dp_ambil_search.Name = "dp_ambil_search";
            this.dp_ambil_search.Size = new System.Drawing.Size(159, 36);
            this.dp_ambil_search.TabIndex = 15;
            this.dp_ambil_search.Value = new System.DateTime(2019, 11, 8, 16, 33, 23, 941);
            this.dp_ambil_search.onValueChanged += new System.EventHandler(this.dp_ambil_search_onValueChanged);
            // 
            // dp_kembali_search
            // 
            this.dp_kembali_search.BackColor = System.Drawing.Color.White;
            this.dp_kembali_search.BorderRadius = 0;
            this.dp_kembali_search.Font = new System.Drawing.Font("Lato", 4F);
            this.dp_kembali_search.ForeColor = System.Drawing.Color.Black;
            this.dp_kembali_search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_kembali_search.FormatCustom = "dd/MM";
            this.dp_kembali_search.Location = new System.Drawing.Point(3, 104);
            this.dp_kembali_search.Margin = new System.Windows.Forms.Padding(4);
            this.dp_kembali_search.Name = "dp_kembali_search";
            this.dp_kembali_search.Size = new System.Drawing.Size(159, 30);
            this.dp_kembali_search.TabIndex = 16;
            this.dp_kembali_search.Value = new System.DateTime(2019, 11, 8, 0, 0, 0, 0);
            // 
            // tb_nama_search
            // 
            this.tb_nama_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nama_search.Font = new System.Drawing.Font("Lato", 7.8F);
            this.tb_nama_search.Location = new System.Drawing.Point(12, 186);
            this.tb_nama_search.Multiline = true;
            this.tb_nama_search.Name = "tb_nama_search";
            this.tb_nama_search.Size = new System.Drawing.Size(149, 30);
            this.tb_nama_search.TabIndex = 17;
            // 
            // tb_vendor_search
            // 
            this.tb_vendor_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_vendor_search.Font = new System.Drawing.Font("Lato", 7.8F);
            this.tb_vendor_search.Location = new System.Drawing.Point(13, 256);
            this.tb_vendor_search.Multiline = true;
            this.tb_vendor_search.Name = "tb_vendor_search";
            this.tb_vendor_search.Size = new System.Drawing.Size(149, 33);
            this.tb_vendor_search.TabIndex = 18;
            // 
            // btn_car_mobil_by_filter
            // 
            this.btn_car_mobil_by_filter.Active = false;
            this.btn_car_mobil_by_filter.Activecolor = System.Drawing.Color.Transparent;
            this.btn_car_mobil_by_filter.BackColor = System.Drawing.Color.Transparent;
            this.btn_car_mobil_by_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_car_mobil_by_filter.BorderRadius = 0;
            this.btn_car_mobil_by_filter.ButtonText = "";
            this.btn_car_mobil_by_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_car_mobil_by_filter.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_car_mobil_by_filter.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_car_mobil_by_filter.Iconimage = null;
            this.btn_car_mobil_by_filter.Iconimage_right = null;
            this.btn_car_mobil_by_filter.Iconimage_right_Selected = null;
            this.btn_car_mobil_by_filter.Iconimage_Selected = null;
            this.btn_car_mobil_by_filter.IconMarginLeft = 0;
            this.btn_car_mobil_by_filter.IconMarginRight = 0;
            this.btn_car_mobil_by_filter.IconRightVisible = true;
            this.btn_car_mobil_by_filter.IconRightZoom = 0D;
            this.btn_car_mobil_by_filter.IconVisible = true;
            this.btn_car_mobil_by_filter.IconZoom = 90D;
            this.btn_car_mobil_by_filter.IsTab = false;
            this.btn_car_mobil_by_filter.Location = new System.Drawing.Point(45, 383);
            this.btn_car_mobil_by_filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_car_mobil_by_filter.Name = "btn_car_mobil_by_filter";
            this.btn_car_mobil_by_filter.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_car_mobil_by_filter.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_car_mobil_by_filter.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_car_mobil_by_filter.selected = false;
            this.btn_car_mobil_by_filter.Size = new System.Drawing.Size(89, 33);
            this.btn_car_mobil_by_filter.TabIndex = 20;
            this.btn_car_mobil_by_filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_car_mobil_by_filter.Textcolor = System.Drawing.Color.Black;
            this.btn_car_mobil_by_filter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car_mobil_by_filter.Click += new System.EventHandler(this.btn_car_mobil_by_filter_Click);
            // 
            // cb_transmisi_mobil
            // 
            this.cb_transmisi_mobil.BackColor = System.Drawing.Color.White;
            this.cb_transmisi_mobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_transmisi_mobil.FormattingEnabled = true;
            this.cb_transmisi_mobil.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.cb_transmisi_mobil.Location = new System.Drawing.Point(13, 321);
            this.cb_transmisi_mobil.Name = "cb_transmisi_mobil";
            this.cb_transmisi_mobil.Size = new System.Drawing.Size(149, 24);
            this.cb_transmisi_mobil.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "NB : Item yang tidak bisa diklik adalah item yang sedang dalam tahap pemesanan.";
            // 
            // panelPayment
            // 
            this.panelPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPayment.BackgroundImage")));
            this.panelPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPayment.Controls.Add(this.lb_tgl_order);
            this.panelPayment.Controls.Add(this.lb_invoice);
            this.panelPayment.Controls.Add(this.label2);
            this.panelPayment.Controls.Add(this.menu_ke_payment);
            this.panelPayment.Controls.Add(this.menu_ke_home);
            this.panelPayment.Location = new System.Drawing.Point(185, 12);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(1166, 653);
            this.panelPayment.TabIndex = 23;
            this.panelPayment.Visible = false;
            this.panelPayment.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPayment_Paint);
            // 
            // lb_tgl_order
            // 
            this.lb_tgl_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_tgl_order.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tgl_order.Location = new System.Drawing.Point(960, 21);
            this.lb_tgl_order.Name = "lb_tgl_order";
            this.lb_tgl_order.Size = new System.Drawing.Size(183, 22);
            this.lb_tgl_order.TabIndex = 27;
            this.lb_tgl_order.Text = "12/11/2019";
            this.lb_tgl_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_invoice
            // 
            this.lb_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_invoice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoice.Location = new System.Drawing.Point(498, 431);
            this.lb_invoice.Name = "lb_invoice";
            this.lb_invoice.Size = new System.Drawing.Size(170, 58);
            this.lb_invoice.TabIndex = 26;
            this.lb_invoice.Text = "904383";
            this.lb_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Invoice Number";
            // 
            // menu_ke_payment
            // 
            this.menu_ke_payment.Active = false;
            this.menu_ke_payment.Activecolor = System.Drawing.Color.Transparent;
            this.menu_ke_payment.BackColor = System.Drawing.Color.Transparent;
            this.menu_ke_payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_ke_payment.BorderRadius = 0;
            this.menu_ke_payment.ButtonText = "";
            this.menu_ke_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_ke_payment.DisabledColor = System.Drawing.Color.Transparent;
            this.menu_ke_payment.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_ke_payment.Iconimage = null;
            this.menu_ke_payment.Iconimage_right = null;
            this.menu_ke_payment.Iconimage_right_Selected = null;
            this.menu_ke_payment.Iconimage_Selected = null;
            this.menu_ke_payment.IconMarginLeft = 0;
            this.menu_ke_payment.IconMarginRight = 0;
            this.menu_ke_payment.IconRightVisible = true;
            this.menu_ke_payment.IconRightZoom = 0D;
            this.menu_ke_payment.IconVisible = true;
            this.menu_ke_payment.IconZoom = 90D;
            this.menu_ke_payment.IsTab = false;
            this.menu_ke_payment.Location = new System.Drawing.Point(603, 521);
            this.menu_ke_payment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu_ke_payment.Name = "menu_ke_payment";
            this.menu_ke_payment.Normalcolor = System.Drawing.Color.Transparent;
            this.menu_ke_payment.OnHovercolor = System.Drawing.Color.Transparent;
            this.menu_ke_payment.OnHoverTextColor = System.Drawing.Color.Black;
            this.menu_ke_payment.selected = false;
            this.menu_ke_payment.Size = new System.Drawing.Size(128, 41);
            this.menu_ke_payment.TabIndex = 24;
            this.menu_ke_payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_ke_payment.Textcolor = System.Drawing.Color.Black;
            this.menu_ke_payment.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ke_payment.Click += new System.EventHandler(this.menu_ke_payment_Click);
            // 
            // menu_ke_home
            // 
            this.menu_ke_home.Active = false;
            this.menu_ke_home.Activecolor = System.Drawing.Color.Transparent;
            this.menu_ke_home.BackColor = System.Drawing.Color.Transparent;
            this.menu_ke_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_ke_home.BorderRadius = 0;
            this.menu_ke_home.ButtonText = "";
            this.menu_ke_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_ke_home.DisabledColor = System.Drawing.Color.Transparent;
            this.menu_ke_home.Iconcolor = System.Drawing.Color.Transparent;
            this.menu_ke_home.Iconimage = null;
            this.menu_ke_home.Iconimage_right = null;
            this.menu_ke_home.Iconimage_right_Selected = null;
            this.menu_ke_home.Iconimage_Selected = null;
            this.menu_ke_home.IconMarginLeft = 0;
            this.menu_ke_home.IconMarginRight = 0;
            this.menu_ke_home.IconRightVisible = true;
            this.menu_ke_home.IconRightZoom = 0D;
            this.menu_ke_home.IconVisible = true;
            this.menu_ke_home.IconZoom = 90D;
            this.menu_ke_home.IsTab = false;
            this.menu_ke_home.Location = new System.Drawing.Point(437, 521);
            this.menu_ke_home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu_ke_home.Name = "menu_ke_home";
            this.menu_ke_home.Normalcolor = System.Drawing.Color.Transparent;
            this.menu_ke_home.OnHovercolor = System.Drawing.Color.Transparent;
            this.menu_ke_home.OnHoverTextColor = System.Drawing.Color.Black;
            this.menu_ke_home.selected = false;
            this.menu_ke_home.Size = new System.Drawing.Size(122, 41);
            this.menu_ke_home.TabIndex = 23;
            this.menu_ke_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_ke_home.Textcolor = System.Drawing.Color.Black;
            this.menu_ke_home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ke_home.Click += new System.EventHandler(this.menu_ke_home_Click);
            // 
            // FormSearchReadyCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 677);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_transmisi_mobil);
            this.Controls.Add(this.btn_car_mobil_by_filter);
            this.Controls.Add(this.tb_vendor_search);
            this.Controls.Add(this.tb_nama_search);
            this.Controls.Add(this.dp_kembali_search);
            this.Controls.Add(this.dp_ambil_search);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(280, 160);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1205, 649);
            this.Name = "FormSearchReadyCars";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search Ready Cars for Rent";
            this.Load += new System.EventHandler(this.FormSearchReadyCars_Load_1);
            this.panel1.ResumeLayout(false);
            this.tab_control_list_mobil_ready.ResumeLayout(false);
            this.pencarian_mobil.ResumeLayout(false);
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tab_control_list_mobil_ready;
        private System.Windows.Forms.TabPage pencarian_mobil;
        private System.Windows.Forms.FlowLayoutPanel FLP_list_mobil_ready;
        private Bunifu.Framework.UI.BunifuDatepicker dp_ambil_search;
        private Bunifu.Framework.UI.BunifuDatepicker dp_kembali_search;
        private System.Windows.Forms.TextBox tb_nama_search;
        private System.Windows.Forms.TextBox tb_vendor_search;
        private Bunifu.Framework.UI.BunifuFlatButton btn_car_mobil_by_filter;
        private System.Windows.Forms.ComboBox cb_transmisi_mobil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPayment;
        private Bunifu.Framework.UI.BunifuFlatButton menu_ke_payment;
        private Bunifu.Framework.UI.BunifuFlatButton menu_ke_home;
        private System.Windows.Forms.Label lb_invoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tgl_order;
    }
}