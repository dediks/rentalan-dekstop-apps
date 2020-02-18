namespace RentalMobil
{
    partial class FormHomeMembers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeMembers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_orders_history = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_incoming_orders = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_payments = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_home = new System.Windows.Forms.Panel();
            this.jumlah_hari = new System.Windows.Forms.Label();
            this.btn_cari_mobil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dp_kembali = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dp_ambil = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.make_rents_tab_control = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_control_list_mobil = new System.Windows.Forms.TabControl();
            this.tab_control_payments = new System.Windows.Forms.TabPage();
            this.panel_rents_history = new System.Windows.Forms.Panel();
            this.dg_payments = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.in_dg_payments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_payment_dg_payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktukembaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuambilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_payments = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewforpaymentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_rental_mobil_payments_new = new RentalMobil.db_rental_mobil_payments_new();
            this.tab_control_rents_history = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_rents = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.invoicenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_ambil_mobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_kembali_mobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_sewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_konifirmasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewforpaymentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_rental_mobil_payments1 = new RentalMobil.Dataset.db_rental_mobil_payments();
            this.view_for_paymentsTableAdapter1 = new RentalMobil.Dataset.db_rental_mobil_paymentsTableAdapters.view_for_paymentsTableAdapter();
            this.view_for_paymentsTableAdapter2 = new RentalMobil.db_rental_mobil_payments_newTableAdapters.view_for_paymentsTableAdapter();
            this.vieworderfullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_rental_mobil_rents_history = new RentalMobil.db_rental_mobil_rents_history();
            this.viewforpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_rental_mobil_payments = new RentalMobil.db_rental_mobil_payments();
            this.dataset_rental_mobil_member = new RentalMobil.dataset_rental_mobil_member();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new RentalMobil.dataset_rental_mobil_memberTableAdapters.membersTableAdapter();
            this.viewcarsreadyfororderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_rental_mobilDataSet3 = new RentalMobil.db_rental_mobilDataSet3();
            this.view_cars_ready_for_orderTableAdapter = new RentalMobil.db_rental_mobilDataSet3TableAdapters.view_cars_ready_for_orderTableAdapter();
            this.view_order_fullTableAdapter = new RentalMobil.db_rental_mobil_rents_historyTableAdapters.view_order_fullTableAdapter();
            this.view_for_paymentsTableAdapter = new RentalMobil.db_rental_mobil_paymentsTableAdapters.view_for_paymentsTableAdapter();
            this.db_rental_mobil_SEMUA_TABLE = new RentalMobil.db_rental_mobil_SEMUA_TABLE();
            this.carsTableAdapter = new RentalMobil.db_rental_mobil_SEMUA_TABLETableAdapters.carsTableAdapter();
            this.tableAdapterManager = new RentalMobil.db_rental_mobil_SEMUA_TABLETableAdapters.TableAdapterManager();
            this.db_rental_mobilDataSet2 = new RentalMobil.db_rental_mobilDataSet2();
            this.carsTableAdapter1 = new RentalMobil.db_rental_mobilDataSet2TableAdapters.carsTableAdapter();
            this.tableAdapterManager1 = new RentalMobil.db_rental_mobilDataSet2TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStripAdmin.SuspendLayout();
            this.panel_home.SuspendLayout();
            this.make_rents_tab_control.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tab_control_list_mobil.SuspendLayout();
            this.tab_control_payments.SuspendLayout();
            this.panel_rents_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_payments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewforpaymentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_payments_new)).BeginInit();
            this.tab_control_rents_history.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewforpaymentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_payments1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vieworderfullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_rents_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewforpaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_payments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_rental_mobil_member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcarsreadyfororderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobilDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_SEMUA_TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobilDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_orders_history
            // 
            this.btn_orders_history.Active = false;
            this.btn_orders_history.Activecolor = System.Drawing.Color.Transparent;
            this.btn_orders_history.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_orders_history.BorderRadius = 0;
            this.btn_orders_history.ButtonText = "";
            this.btn_orders_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orders_history.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_orders_history.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_orders_history.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_orders_history.Iconimage")));
            this.btn_orders_history.Iconimage_right = null;
            this.btn_orders_history.Iconimage_right_Selected = null;
            this.btn_orders_history.Iconimage_Selected = null;
            this.btn_orders_history.IconMarginLeft = 0;
            this.btn_orders_history.IconMarginRight = 0;
            this.btn_orders_history.IconRightVisible = true;
            this.btn_orders_history.IconRightZoom = 0D;
            this.btn_orders_history.IconVisible = true;
            this.btn_orders_history.IconZoom = 90D;
            this.btn_orders_history.IsTab = false;
            this.btn_orders_history.Location = new System.Drawing.Point(24, 316);
            this.btn_orders_history.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_orders_history.Name = "btn_orders_history";
            this.btn_orders_history.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_orders_history.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_orders_history.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_orders_history.selected = false;
            this.btn_orders_history.Size = new System.Drawing.Size(255, 167);
            this.btn_orders_history.TabIndex = 1;
            this.btn_orders_history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders_history.Textcolor = System.Drawing.Color.White;
            this.btn_orders_history.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders_history.Click += new System.EventHandler(this.btn_orders_history_Click);
            // 
            // btn_incoming_orders
            // 
            this.btn_incoming_orders.Active = false;
            this.btn_incoming_orders.Activecolor = System.Drawing.Color.Transparent;
            this.btn_incoming_orders.BackColor = System.Drawing.Color.Transparent;
            this.btn_incoming_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_incoming_orders.BorderRadius = 0;
            this.btn_incoming_orders.ButtonText = "";
            this.btn_incoming_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_incoming_orders.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_incoming_orders.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_incoming_orders.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_incoming_orders.Iconimage")));
            this.btn_incoming_orders.Iconimage_right = null;
            this.btn_incoming_orders.Iconimage_right_Selected = null;
            this.btn_incoming_orders.Iconimage_Selected = null;
            this.btn_incoming_orders.IconMarginLeft = 0;
            this.btn_incoming_orders.IconMarginRight = 0;
            this.btn_incoming_orders.IconRightVisible = true;
            this.btn_incoming_orders.IconRightZoom = 0D;
            this.btn_incoming_orders.IconVisible = true;
            this.btn_incoming_orders.IconZoom = 90D;
            this.btn_incoming_orders.IsTab = false;
            this.btn_incoming_orders.Location = new System.Drawing.Point(24, 143);
            this.btn_incoming_orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_incoming_orders.Name = "btn_incoming_orders";
            this.btn_incoming_orders.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_incoming_orders.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_incoming_orders.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_incoming_orders.selected = false;
            this.btn_incoming_orders.Size = new System.Drawing.Size(251, 153);
            this.btn_incoming_orders.TabIndex = 2;
            this.btn_incoming_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_incoming_orders.Textcolor = System.Drawing.Color.White;
            this.btn_incoming_orders.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incoming_orders.Click += new System.EventHandler(this.btn_incoming_orders_Click);
            // 
            // btn_payments
            // 
            this.btn_payments.Active = false;
            this.btn_payments.Activecolor = System.Drawing.Color.Transparent;
            this.btn_payments.BackColor = System.Drawing.Color.Transparent;
            this.btn_payments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_payments.BorderRadius = 0;
            this.btn_payments.ButtonText = "";
            this.btn_payments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_payments.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_payments.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_payments.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_payments.Iconimage")));
            this.btn_payments.Iconimage_right = null;
            this.btn_payments.Iconimage_right_Selected = null;
            this.btn_payments.Iconimage_Selected = null;
            this.btn_payments.IconMarginLeft = 0;
            this.btn_payments.IconMarginRight = 0;
            this.btn_payments.IconRightVisible = true;
            this.btn_payments.IconRightZoom = 0D;
            this.btn_payments.IconVisible = true;
            this.btn_payments.IconZoom = 90D;
            this.btn_payments.IsTab = false;
            this.btn_payments.Location = new System.Drawing.Point(30, 509);
            this.btn_payments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_payments.Name = "btn_payments";
            this.btn_payments.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_payments.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_payments.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_payments.selected = false;
            this.btn_payments.Size = new System.Drawing.Size(249, 143);
            this.btn_payments.TabIndex = 3;
            this.btn_payments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payments.Textcolor = System.Drawing.Color.White;
            this.btn_payments.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payments.Click += new System.EventHandler(this.btn_payments_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Active = false;
            this.btn_logout.Activecolor = System.Drawing.Color.Transparent;
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_logout.BorderRadius = 0;
            this.btn_logout.ButtonText = "";
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_logout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_logout.Iconimage = null;
            this.btn_logout.Iconimage_right = null;
            this.btn_logout.Iconimage_right_Selected = null;
            this.btn_logout.Iconimage_Selected = null;
            this.btn_logout.IconMarginLeft = 0;
            this.btn_logout.IconMarginRight = 0;
            this.btn_logout.IconRightVisible = true;
            this.btn_logout.IconRightZoom = 0D;
            this.btn_logout.IconVisible = true;
            this.btn_logout.IconZoom = 90D;
            this.btn_logout.IsTab = false;
            this.btn_logout.Location = new System.Drawing.Point(1421, 13);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_logout.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_logout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_logout.selected = false;
            this.btn_logout.Size = new System.Drawing.Size(175, 72);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Textcolor = System.Drawing.Color.White;
            this.btn_logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 900);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripAdmin.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.pROFILToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(300, 27);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(214, 37);
            this.menuStripAdmin.TabIndex = 8;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(99, 33);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // pROFILToolStripMenuItem
            // 
            this.pROFILToolStripMenuItem.Name = "pROFILToolStripMenuItem";
            this.pROFILToolStripMenuItem.Size = new System.Drawing.Size(107, 33);
            this.pROFILToolStripMenuItem.Text = "PROFIL";
            this.pROFILToolStripMenuItem.Click += new System.EventHandler(this.pROFILToolStripMenuItem_Click);
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.White;
            this.panel_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_home.BackgroundImage")));
            this.panel_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_home.Controls.Add(this.jumlah_hari);
            this.panel_home.Controls.Add(this.btn_cari_mobil);
            this.panel_home.Controls.Add(this.dp_kembali);
            this.panel_home.Controls.Add(this.dp_ambil);
            this.panel_home.Location = new System.Drawing.Point(3, 3);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(1158, 555);
            this.panel_home.TabIndex = 9;
            this.panel_home.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_home_Paint);
            // 
            // jumlah_hari
            // 
            this.jumlah_hari.BackColor = System.Drawing.Color.Transparent;
            this.jumlah_hari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jumlah_hari.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah_hari.Location = new System.Drawing.Point(576, 238);
            this.jumlah_hari.Name = "jumlah_hari";
            this.jumlah_hari.Size = new System.Drawing.Size(19, 24);
            this.jumlah_hari.TabIndex = 11;
            this.jumlah_hari.Text = "0";
            this.jumlah_hari.Click += new System.EventHandler(this.jumlah_hari_Click);
            // 
            // btn_cari_mobil
            // 
            this.btn_cari_mobil.Active = false;
            this.btn_cari_mobil.Activecolor = System.Drawing.Color.Transparent;
            this.btn_cari_mobil.BackColor = System.Drawing.Color.Transparent;
            this.btn_cari_mobil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cari_mobil.BorderRadius = 0;
            this.btn_cari_mobil.ButtonText = "";
            this.btn_cari_mobil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cari_mobil.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_cari_mobil.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cari_mobil.Iconimage = null;
            this.btn_cari_mobil.Iconimage_right = null;
            this.btn_cari_mobil.Iconimage_right_Selected = null;
            this.btn_cari_mobil.Iconimage_Selected = null;
            this.btn_cari_mobil.IconMarginLeft = 0;
            this.btn_cari_mobil.IconMarginRight = 0;
            this.btn_cari_mobil.IconRightVisible = false;
            this.btn_cari_mobil.IconRightZoom = 0D;
            this.btn_cari_mobil.IconVisible = false;
            this.btn_cari_mobil.IconZoom = 90D;
            this.btn_cari_mobil.IsTab = false;
            this.btn_cari_mobil.Location = new System.Drawing.Point(494, 481);
            this.btn_cari_mobil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cari_mobil.Name = "btn_cari_mobil";
            this.btn_cari_mobil.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_cari_mobil.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_cari_mobil.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_cari_mobil.selected = false;
            this.btn_cari_mobil.Size = new System.Drawing.Size(173, 52);
            this.btn_cari_mobil.TabIndex = 10;
            this.btn_cari_mobil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari_mobil.Textcolor = System.Drawing.Color.White;
            this.btn_cari_mobil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari_mobil.Click += new System.EventHandler(this.btn_cari_mobil_Click);
            // 
            // dp_kembali
            // 
            this.dp_kembali.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dp_kembali.BorderRadius = 0;
            this.dp_kembali.Font = new System.Drawing.Font("Lato Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_kembali.ForeColor = System.Drawing.Color.Black;
            this.dp_kembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_kembali.FormatCustom = "dd/MM/yyyy";
            this.dp_kembali.Location = new System.Drawing.Point(651, 213);
            this.dp_kembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_kembali.Name = "dp_kembali";
            this.dp_kembali.Size = new System.Drawing.Size(290, 71);
            this.dp_kembali.TabIndex = 3;
            this.dp_kembali.Value = new System.DateTime(2019, 11, 7, 0, 0, 0, 0);
            this.dp_kembali.onValueChanged += new System.EventHandler(this.dp_kembali_onValueChanged);
            // 
            // dp_ambil
            // 
            this.dp_ambil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dp_ambil.BorderRadius = 0;
            this.dp_ambil.Font = new System.Drawing.Font("Lato Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_ambil.ForeColor = System.Drawing.Color.Black;
            this.dp_ambil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_ambil.FormatCustom = "dd/MM/yyyy";
            this.dp_ambil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dp_ambil.Location = new System.Drawing.Point(232, 213);
            this.dp_ambil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_ambil.Name = "dp_ambil";
            this.dp_ambil.Size = new System.Drawing.Size(290, 71);
            this.dp_ambil.TabIndex = 1;
            this.dp_ambil.Value = new System.DateTime(2019, 11, 7, 0, 0, 0, 0);
            this.dp_ambil.onValueChanged += new System.EventHandler(this.dp_ambil_onValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1390, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // make_rents_tab_control
            // 
            this.make_rents_tab_control.Controls.Add(this.flowLayoutPanel1);
            this.make_rents_tab_control.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_rents_tab_control.Location = new System.Drawing.Point(4, 25);
            this.make_rents_tab_control.Name = "make_rents_tab_control";
            this.make_rents_tab_control.Padding = new System.Windows.Forms.Padding(3);
            this.make_rents_tab_control.Size = new System.Drawing.Size(1190, 708);
            this.make_rents_tab_control.TabIndex = 0;
            this.make_rents_tab_control.Text = "Make Rents";
            this.make_rents_tab_control.UseVisualStyleBackColor = true;
            this.make_rents_tab_control.Click += new System.EventHandler(this.pencarian_mobil_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel_home);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1172, 653);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tab_control_list_mobil
            // 
            this.tab_control_list_mobil.Controls.Add(this.make_rents_tab_control);
            this.tab_control_list_mobil.Controls.Add(this.tab_control_payments);
            this.tab_control_list_mobil.Controls.Add(this.tab_control_rents_history);
            this.tab_control_list_mobil.Location = new System.Drawing.Point(327, 126);
            this.tab_control_list_mobil.Name = "tab_control_list_mobil";
            this.tab_control_list_mobil.SelectedIndex = 0;
            this.tab_control_list_mobil.Size = new System.Drawing.Size(1198, 737);
            this.tab_control_list_mobil.TabIndex = 12;
            this.tab_control_list_mobil.SelectedIndexChanged += new System.EventHandler(this.tab_control_list_mobil_SelectedIndexChanged);
            this.tab_control_list_mobil.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_control_list_mobil_Selected);
            // 
            // tab_control_payments
            // 
            this.tab_control_payments.AutoScroll = true;
            this.tab_control_payments.Controls.Add(this.panel_rents_history);
            this.tab_control_payments.Location = new System.Drawing.Point(4, 25);
            this.tab_control_payments.Name = "tab_control_payments";
            this.tab_control_payments.Size = new System.Drawing.Size(1190, 708);
            this.tab_control_payments.TabIndex = 1;
            this.tab_control_payments.Text = "Payments";
            this.tab_control_payments.UseVisualStyleBackColor = true;
            this.tab_control_payments.Click += new System.EventHandler(this.tab_control_payments_Click);
            // 
            // panel_rents_history
            // 
            this.panel_rents_history.BackColor = System.Drawing.Color.Silver;
            this.panel_rents_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rents_history.Controls.Add(this.dg_payments);
            this.panel_rents_history.Location = new System.Drawing.Point(3, 3);
            this.panel_rents_history.Name = "panel_rents_history";
            this.panel_rents_history.Size = new System.Drawing.Size(1189, 609);
            this.panel_rents_history.TabIndex = 10;
            this.panel_rents_history.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_rents_history_Paint_1);
            // 
            // dg_payments
            // 
            this.dg_payments.AllowUserToAddRows = false;
            this.dg_payments.AllowUserToDeleteRows = false;
            this.dg_payments.AllowUserToResizeColumns = false;
            this.dg_payments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            this.dg_payments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_payments.AutoGenerateColumns = false;
            this.dg_payments.BackgroundColor = System.Drawing.Color.White;
            this.dg_payments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_payments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_payments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_payments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_payments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.in_dg_payments,
            this.id_payment_dg_payment,
            this.tglorderDataGridViewTextBoxColumn,
            this.waktukembaliDataGridViewTextBoxColumn,
            this.waktuambilDataGridViewTextBoxColumn,
            this.hargasewaDataGridViewTextBoxColumn,
            this.status_order,
            this.action_payments});
            this.dg_payments.DataSource = this.viewforpaymentsBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_payments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_payments.DoubleBuffered = true;
            this.dg_payments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_payments.EnableHeadersVisualStyles = false;
            this.dg_payments.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_payments.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.dg_payments.HeaderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dg_payments.Location = new System.Drawing.Point(-7, -3);
            this.dg_payments.MultiSelect = false;
            this.dg_payments.Name = "dg_payments";
            this.dg_payments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_payments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_payments.RowTemplate.Height = 24;
            this.dg_payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_payments.Size = new System.Drawing.Size(1191, 609);
            this.dg_payments.TabIndex = 4;
            this.dg_payments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_payments_CellContentClick);
            this.dg_payments.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_payments_CellContentDoubleClick);
            this.dg_payments.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dg_payments_RowsAdded);
            this.dg_payments.Paint += new System.Windows.Forms.PaintEventHandler(this.dg_payments_Paint);
            // 
            // in_dg_payments
            // 
            this.in_dg_payments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.in_dg_payments.DataPropertyName = "invoice_number";
            this.in_dg_payments.HeaderText = "I_N";
            this.in_dg_payments.Name = "in_dg_payments";
            this.in_dg_payments.ReadOnly = true;
            // 
            // id_payment_dg_payment
            // 
            this.id_payment_dg_payment.DataPropertyName = "id_payment";
            this.id_payment_dg_payment.HeaderText = "ID PAYMENT";
            this.id_payment_dg_payment.Name = "id_payment_dg_payment";
            this.id_payment_dg_payment.ReadOnly = true;
            this.id_payment_dg_payment.Visible = false;
            // 
            // tglorderDataGridViewTextBoxColumn
            // 
            this.tglorderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tglorderDataGridViewTextBoxColumn.DataPropertyName = "tgl_order";
            this.tglorderDataGridViewTextBoxColumn.HeaderText = "TGL ORDER";
            this.tglorderDataGridViewTextBoxColumn.Name = "tglorderDataGridViewTextBoxColumn";
            this.tglorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waktukembaliDataGridViewTextBoxColumn
            // 
            this.waktukembaliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waktukembaliDataGridViewTextBoxColumn.DataPropertyName = "waktu_kembali";
            this.waktukembaliDataGridViewTextBoxColumn.HeaderText = "KEMBALI";
            this.waktukembaliDataGridViewTextBoxColumn.Name = "waktukembaliDataGridViewTextBoxColumn";
            this.waktukembaliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waktuambilDataGridViewTextBoxColumn
            // 
            this.waktuambilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waktuambilDataGridViewTextBoxColumn.DataPropertyName = "waktu_ambil";
            this.waktuambilDataGridViewTextBoxColumn.HeaderText = "AMBIL";
            this.waktuambilDataGridViewTextBoxColumn.Name = "waktuambilDataGridViewTextBoxColumn";
            this.waktuambilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargasewaDataGridViewTextBoxColumn
            // 
            this.hargasewaDataGridViewTextBoxColumn.DataPropertyName = "harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.HeaderText = "HARGA";
            this.hargasewaDataGridViewTextBoxColumn.Name = "hargasewaDataGridViewTextBoxColumn";
            this.hargasewaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // status_order
            // 
            this.status_order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_order.DataPropertyName = "status";
            this.status_order.HeaderText = "STATUS";
            this.status_order.Name = "status_order";
            this.status_order.ReadOnly = true;
            // 
            // action_payments
            // 
            this.action_payments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.action_payments.DataPropertyName = "id_payment";
            this.action_payments.HeaderText = "ACTION";
            this.action_payments.Name = "action_payments";
            this.action_payments.ReadOnly = true;
            this.action_payments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action_payments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.action_payments.Text = "Bayar";
            this.action_payments.ToolTipText = "Bayar";
            this.action_payments.UseColumnTextForButtonValue = true;
            this.action_payments.Visible = false;
            // 
            // viewforpaymentsBindingSource2
            // 
            this.viewforpaymentsBindingSource2.DataMember = "view_for_payments";
            this.viewforpaymentsBindingSource2.DataSource = this.db_rental_mobil_payments_new;
            // 
            // db_rental_mobil_payments_new
            // 
            this.db_rental_mobil_payments_new.DataSetName = "db_rental_mobil_payments_new";
            this.db_rental_mobil_payments_new.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_control_rents_history
            // 
            this.tab_control_rents_history.Controls.Add(this.panel1);
            this.tab_control_rents_history.Location = new System.Drawing.Point(4, 25);
            this.tab_control_rents_history.Name = "tab_control_rents_history";
            this.tab_control_rents_history.Size = new System.Drawing.Size(1190, 708);
            this.tab_control_rents_history.TabIndex = 2;
            this.tab_control_rents_history.Text = "Rents History";
            this.tab_control_rents_history.UseVisualStyleBackColor = true;
            this.tab_control_rents_history.Click += new System.EventHandler(this.tab_control_rents_history_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dg_rents);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 609);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dg_rents
            // 
            this.dg_rents.AllowUserToAddRows = false;
            this.dg_rents.AllowUserToDeleteRows = false;
            this.dg_rents.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            this.dg_rents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_rents.AutoGenerateColumns = false;
            this.dg_rents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_rents.BackgroundColor = System.Drawing.Color.White;
            this.dg_rents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_rents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_rents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lato", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_rents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_rents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoicenumberDataGridViewTextBoxColumn,
            this.nama,
            this.tgl_order,
            this.waktu_ambil_mobil,
            this.waktu_kembali_mobil,
            this.harga_sewa,
            this.status_konifirmasi,
            this.total_price,
            this.id_payment});
            this.dg_rents.DataSource = this.viewforpaymentsBindingSource2;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_rents.DefaultCellStyle = dataGridViewCellStyle7;
            this.dg_rents.DoubleBuffered = true;
            this.dg_rents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_rents.EnableHeadersVisualStyles = false;
            this.dg_rents.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_rents.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.dg_rents.HeaderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dg_rents.Location = new System.Drawing.Point(-7, 0);
            this.dg_rents.MultiSelect = false;
            this.dg_rents.Name = "dg_rents";
            this.dg_rents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_rents.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dg_rents.RowTemplate.Height = 24;
            this.dg_rents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_rents.Size = new System.Drawing.Size(1198, 664);
            this.dg_rents.TabIndex = 4;
            this.dg_rents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rents_CellContentClick);
            this.dg_rents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rents_CellDoubleClick);
            // 
            // invoicenumberDataGridViewTextBoxColumn
            // 
            this.invoicenumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invoicenumberDataGridViewTextBoxColumn.DataPropertyName = "invoice_number";
            this.invoicenumberDataGridViewTextBoxColumn.HeaderText = "Invoice Number";
            this.invoicenumberDataGridViewTextBoxColumn.Name = "invoicenumberDataGridViewTextBoxColumn";
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Mobil";
            this.nama.Name = "nama";
            this.nama.Width = 74;
            // 
            // tgl_order
            // 
            this.tgl_order.DataPropertyName = "tgl_order";
            this.tgl_order.HeaderText = "Tgl Order";
            this.tgl_order.Name = "tgl_order";
            this.tgl_order.Width = 88;
            // 
            // waktu_ambil_mobil
            // 
            this.waktu_ambil_mobil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waktu_ambil_mobil.DataPropertyName = "waktu_ambil";
            this.waktu_ambil_mobil.HeaderText = "Waktu Ambil";
            this.waktu_ambil_mobil.Name = "waktu_ambil_mobil";
            // 
            // waktu_kembali_mobil
            // 
            this.waktu_kembali_mobil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waktu_kembali_mobil.DataPropertyName = "waktu_kembali";
            this.waktu_kembali_mobil.HeaderText = "Waktu Kembali";
            this.waktu_kembali_mobil.Name = "waktu_kembali_mobil";
            // 
            // harga_sewa
            // 
            this.harga_sewa.DataPropertyName = "harga_sewa";
            this.harga_sewa.HeaderText = "Harga Sewa";
            this.harga_sewa.Name = "harga_sewa";
            this.harga_sewa.Width = 104;
            // 
            // status_konifirmasi
            // 
            this.status_konifirmasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_konifirmasi.DataPropertyName = "status";
            this.status_konifirmasi.HeaderText = "Status";
            this.status_konifirmasi.Name = "status_konifirmasi";
            // 
            // total_price
            // 
            this.total_price.DataPropertyName = "total_price";
            this.total_price.HeaderText = "total_price";
            this.total_price.Name = "total_price";
            this.total_price.Visible = false;
            this.total_price.Width = 103;
            // 
            // id_payment
            // 
            this.id_payment.DataPropertyName = "id_payment";
            this.id_payment.HeaderText = "id_payment";
            this.id_payment.Name = "id_payment";
            this.id_payment.Visible = false;
            this.id_payment.Width = 110;
            // 
            // viewforpaymentsBindingSource1
            // 
            this.viewforpaymentsBindingSource1.DataMember = "view_for_payments";
            this.viewforpaymentsBindingSource1.DataSource = this.db_rental_mobil_payments1;
            // 
            // db_rental_mobil_payments1
            // 
            this.db_rental_mobil_payments1.DataSetName = "db_rental_mobil_payments";
            this.db_rental_mobil_payments1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_for_paymentsTableAdapter1
            // 
            this.view_for_paymentsTableAdapter1.ClearBeforeFill = true;
            // 
            // view_for_paymentsTableAdapter2
            // 
            this.view_for_paymentsTableAdapter2.ClearBeforeFill = true;
            // 
            // vieworderfullBindingSource
            // 
            this.vieworderfullBindingSource.DataMember = "view_order_full";
            this.vieworderfullBindingSource.DataSource = this.db_rental_mobil_rents_history;
            // 
            // db_rental_mobil_rents_history
            // 
            this.db_rental_mobil_rents_history.DataSetName = "db_rental_mobil_rents_history";
            this.db_rental_mobil_rents_history.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewforpaymentsBindingSource
            // 
            this.viewforpaymentsBindingSource.DataMember = "view_for_payments";
            this.viewforpaymentsBindingSource.DataSource = this.db_rental_mobil_payments;
            // 
            // db_rental_mobil_payments
            // 
            this.db_rental_mobil_payments.DataSetName = "db_rental_mobil_payments";
            this.db_rental_mobil_payments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataset_rental_mobil_member
            // 
            this.dataset_rental_mobil_member.DataSetName = "dataset_rental_mobil_member";
            this.dataset_rental_mobil_member.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.dataset_rental_mobil_member;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // viewcarsreadyfororderBindingSource
            // 
            this.viewcarsreadyfororderBindingSource.DataMember = "view_cars_ready_for_order";
            this.viewcarsreadyfororderBindingSource.DataSource = this.db_rental_mobilDataSet3;
            // 
            // db_rental_mobilDataSet3
            // 
            this.db_rental_mobilDataSet3.DataSetName = "db_rental_mobilDataSet3";
            this.db_rental_mobilDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_cars_ready_for_orderTableAdapter
            // 
            this.view_cars_ready_for_orderTableAdapter.ClearBeforeFill = true;
            // 
            // view_order_fullTableAdapter
            // 
            this.view_order_fullTableAdapter.ClearBeforeFill = true;
            // 
            // view_for_paymentsTableAdapter
            // 
            this.view_for_paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // db_rental_mobil_SEMUA_TABLE
            // 
            this.db_rental_mobil_SEMUA_TABLE.DataSetName = "db_rental_mobil_SEMUA_TABLE";
            this.db_rental_mobil_SEMUA_TABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.membersTableAdapter = null;
            this.tableAdapterManager.order_carTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.paymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentalMobil.db_rental_mobil_SEMUA_TABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_rental_mobilDataSet2
            // 
            this.db_rental_mobilDataSet2.DataSetName = "db_rental_mobilDataSet2";
            this.db_rental_mobilDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter1
            // 
            this.carsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.carsTableAdapter = this.carsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = RentalMobil.db_rental_mobilDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(1311, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHomeMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_payments);
            this.Controls.Add(this.btn_incoming_orders);
            this.Controls.Add(this.btn_orders_history);
            this.Controls.Add(this.menuStripAdmin);
            this.Controls.Add(this.tab_control_list_mobil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripAdmin;
            this.MaximizeBox = false;
            this.Name = "FormHomeMembers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomeMembers";
            this.Load += new System.EventHandler(this.FormHomeMembers_Load);
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.panel_home.ResumeLayout(false);
            this.make_rents_tab_control.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tab_control_list_mobil.ResumeLayout(false);
            this.tab_control_payments.ResumeLayout(false);
            this.panel_rents_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_payments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewforpaymentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_payments_new)).EndInit();
            this.tab_control_rents_history.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_rents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewforpaymentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_payments1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vieworderfullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_rents_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewforpaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_payments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_rental_mobil_member)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcarsreadyfororderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobilDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_SEMUA_TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobilDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btn_orders_history;
        private Bunifu.Framework.UI.BunifuFlatButton btn_incoming_orders;
        private Bunifu.Framework.UI.BunifuFlatButton btn_payments;
        private Bunifu.Framework.UI.BunifuFlatButton btn_logout;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.ToolStripMenuItem pROFILToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuDatepicker dp_ambil;
        private Bunifu.Framework.UI.BunifuDatepicker dp_kembali;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cari_mobil;
        private System.Windows.Forms.Label jumlah_hari;
        private dataset_rental_mobil_member dataset_rental_mobil_member;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private dataset_rental_mobil_memberTableAdapters.membersTableAdapter membersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage make_rents_tab_control;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tab_control_list_mobil;
        private System.Windows.Forms.TabPage tab_control_payments;
        private System.Windows.Forms.TabPage tab_control_rents_history;
        private System.Windows.Forms.Panel panel_rents_history;
        private db_rental_mobilDataSet3 db_rental_mobilDataSet3;
        private System.Windows.Forms.BindingSource viewcarsreadyfororderBindingSource;
        private db_rental_mobilDataSet3TableAdapters.view_cars_ready_for_orderTableAdapter view_cars_ready_for_orderTableAdapter;
        private db_rental_mobil_rents_history db_rental_mobil_rents_history;
        private System.Windows.Forms.BindingSource vieworderfullBindingSource;
        private db_rental_mobil_rents_historyTableAdapters.view_order_fullTableAdapter view_order_fullTableAdapter;
        private db_rental_mobil_payments db_rental_mobil_payments;
        private System.Windows.Forms.BindingSource viewforpaymentsBindingSource;
        private db_rental_mobil_paymentsTableAdapters.view_for_paymentsTableAdapter view_for_paymentsTableAdapter;
        private db_rental_mobil_SEMUA_TABLE db_rental_mobil_SEMUA_TABLE;
        private db_rental_mobil_SEMUA_TABLETableAdapters.carsTableAdapter carsTableAdapter;
        private db_rental_mobil_SEMUA_TABLETableAdapters.TableAdapterManager tableAdapterManager;
        private db_rental_mobilDataSet2 db_rental_mobilDataSet2;
        private db_rental_mobilDataSet2TableAdapters.carsTableAdapter carsTableAdapter1;
        private db_rental_mobilDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dg_payments;
        private System.Windows.Forms.Panel panel1;
        private Dataset.db_rental_mobil_payments db_rental_mobil_payments1;
        private System.Windows.Forms.BindingSource viewforpaymentsBindingSource1;
        private Dataset.db_rental_mobil_paymentsTableAdapters.view_for_paymentsTableAdapter view_for_paymentsTableAdapter1;
        private db_rental_mobil_payments_new db_rental_mobil_payments_new;
        private System.Windows.Forms.BindingSource viewforpaymentsBindingSource2;
        private db_rental_mobil_payments_newTableAdapters.view_for_paymentsTableAdapter view_for_paymentsTableAdapter2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dg_rents;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_dg_payments;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_payment_dg_payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktukembaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuambilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_order;
        private System.Windows.Forms.DataGridViewButtonColumn action_payments;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_ambil_mobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_kembali_mobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_sewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_konifirmasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_payment;
        private System.Windows.Forms.Button button1;
    }
}