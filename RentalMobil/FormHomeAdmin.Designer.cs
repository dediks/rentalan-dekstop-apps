namespace RentalMobil
{
    partial class FormHomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeAdmin));
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
            this.dATAMASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_mobil_data_master = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_member_data_master = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_home = new System.Windows.Forms.Panel();
            this.tab_admin = new System.Windows.Forms.TabControl();
            this.tab_incoming_order = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_incoming_order = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.invoicenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuambilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktukembaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_review = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewforpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_rental_mobil_payments_new = new RentalMobil.db_rental_mobil_payments_new();
            this.tab_order_history = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dg_order_history = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_order_history = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_for_paymentsTableAdapter = new RentalMobil.db_rental_mobil_payments_newTableAdapters.view_for_paymentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStripAdmin.SuspendLayout();
            this.tab_admin.SuspendLayout();
            this.tab_incoming_order.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_incoming_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewforpaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_payments_new)).BeginInit();
            this.tab_order_history.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_order_history)).BeginInit();
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
            this.btn_orders_history.Location = new System.Drawing.Point(-1, 252);
            this.btn_orders_history.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_orders_history.Name = "btn_orders_history";
            this.btn_orders_history.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_orders_history.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_orders_history.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_orders_history.selected = false;
            this.btn_orders_history.Size = new System.Drawing.Size(249, 143);
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
            this.btn_incoming_orders.Location = new System.Drawing.Point(-1, 88);
            this.btn_incoming_orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_incoming_orders.Name = "btn_incoming_orders";
            this.btn_incoming_orders.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_incoming_orders.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_incoming_orders.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_incoming_orders.selected = false;
            this.btn_incoming_orders.Size = new System.Drawing.Size(249, 143);
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
            this.btn_payments.Location = new System.Drawing.Point(-1, 403);
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
            this.btn_logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_logout.Iconimage")));
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
            this.btn_logout.Size = new System.Drawing.Size(175, 53);
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
            this.dATAMASTERToolStripMenuItem,
            this.pROFILToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(300, 27);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(401, 37);
            this.menuStripAdmin.TabIndex = 8;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(99, 33);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // dATAMASTERToolStripMenuItem
            // 
            this.dATAMASTERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_mobil_data_master,
            this.ms_member_data_master});
            this.dATAMASTERToolStripMenuItem.Name = "dATAMASTERToolStripMenuItem";
            this.dATAMASTERToolStripMenuItem.Size = new System.Drawing.Size(187, 33);
            this.dATAMASTERToolStripMenuItem.Text = "DATA MASTER";
            // 
            // ms_mobil_data_master
            // 
            this.ms_mobil_data_master.Name = "ms_mobil_data_master";
            this.ms_mobil_data_master.Size = new System.Drawing.Size(197, 34);
            this.ms_mobil_data_master.Text = "MOBIL";
            this.ms_mobil_data_master.Click += new System.EventHandler(this.mOBILToolStripMenuItem_Click);
            // 
            // ms_member_data_master
            // 
            this.ms_member_data_master.Name = "ms_member_data_master";
            this.ms_member_data_master.Size = new System.Drawing.Size(197, 34);
            this.ms_member_data_master.Text = "MEMBER";
            this.ms_member_data_master.Click += new System.EventHandler(this.ms_member_data_master_Click);
            // 
            // pROFILToolStripMenuItem
            // 
            this.pROFILToolStripMenuItem.Name = "pROFILToolStripMenuItem";
            this.pROFILToolStripMenuItem.Size = new System.Drawing.Size(107, 33);
            this.pROFILToolStripMenuItem.Text = "PROFIL";
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.White;
            this.panel_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_home.BackgroundImage")));
            this.panel_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_home.Location = new System.Drawing.Point(300, 134);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(1228, 479);
            this.panel_home.TabIndex = 9;
            // 
            // tab_admin
            // 
            this.tab_admin.Controls.Add(this.tab_incoming_order);
            this.tab_admin.Controls.Add(this.tab_order_history);
            this.tab_admin.Location = new System.Drawing.Point(271, 100);
            this.tab_admin.Name = "tab_admin";
            this.tab_admin.SelectedIndex = 0;
            this.tab_admin.Size = new System.Drawing.Size(1254, 777);
            this.tab_admin.TabIndex = 0;
            // 
            // tab_incoming_order
            // 
            this.tab_incoming_order.Controls.Add(this.panel1);
            this.tab_incoming_order.Location = new System.Drawing.Point(4, 25);
            this.tab_incoming_order.Name = "tab_incoming_order";
            this.tab_incoming_order.Size = new System.Drawing.Size(1246, 748);
            this.tab_incoming_order.TabIndex = 2;
            this.tab_incoming_order.Text = "Incoming Order";
            this.tab_incoming_order.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg_incoming_order);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 741);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dg_incoming_order
            // 
            this.dg_incoming_order.AllowCustomTheming = false;
            this.dg_incoming_order.AllowUserToAddRows = false;
            this.dg_incoming_order.AllowUserToDeleteRows = false;
            this.dg_incoming_order.AllowUserToResizeColumns = false;
            this.dg_incoming_order.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dg_incoming_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_incoming_order.AutoGenerateColumns = false;
            this.dg_incoming_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_incoming_order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_incoming_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_incoming_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_incoming_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_incoming_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_incoming_order.ColumnHeadersHeight = 40;
            this.dg_incoming_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoicenumberDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.idmemberDataGridViewTextBoxColumn,
            this.waktuambilDataGridViewTextBoxColumn,
            this.waktukembaliDataGridViewTextBoxColumn,
            this.namamemberDataGridViewTextBoxColumn,
            this.tglorderDataGridViewTextBoxColumn,
            this.hargasewaDataGridViewTextBoxColumn,
            this.status_order,
            this.btn_review,
            this.totalpriceDataGridViewTextBoxColumn,
            this.idpaymentDataGridViewTextBoxColumn});
            this.dg_incoming_order.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dg_incoming_order.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dg_incoming_order.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dg_incoming_order.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dg_incoming_order.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_incoming_order.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dg_incoming_order.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dg_incoming_order.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dg_incoming_order.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dg_incoming_order.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_incoming_order.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dg_incoming_order.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dg_incoming_order.CurrentTheme.Name = null;
            this.dg_incoming_order.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_incoming_order.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dg_incoming_order.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dg_incoming_order.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dg_incoming_order.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_incoming_order.DataSource = this.viewforpaymentsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_incoming_order.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_incoming_order.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_incoming_order.EnableHeadersVisualStyles = false;
            this.dg_incoming_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dg_incoming_order.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dg_incoming_order.HeaderBgColor = System.Drawing.Color.Empty;
            this.dg_incoming_order.HeaderForeColor = System.Drawing.Color.White;
            this.dg_incoming_order.Location = new System.Drawing.Point(3, 3);
            this.dg_incoming_order.MultiSelect = false;
            this.dg_incoming_order.Name = "dg_incoming_order";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_incoming_order.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_incoming_order.RowHeadersVisible = false;
            this.dg_incoming_order.RowTemplate.Height = 40;
            this.dg_incoming_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_incoming_order.Size = new System.Drawing.Size(1230, 719);
            this.dg_incoming_order.TabIndex = 1;
            this.dg_incoming_order.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dg_incoming_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_incoming_order_CellContentClick);
            this.dg_incoming_order.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_incoming_order_CellContentDoubleClick);
            // 
            // invoicenumberDataGridViewTextBoxColumn
            // 
            this.invoicenumberDataGridViewTextBoxColumn.DataPropertyName = "invoice_number";
            this.invoicenumberDataGridViewTextBoxColumn.HeaderText = "IN";
            this.invoicenumberDataGridViewTextBoxColumn.Name = "invoicenumberDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Mobil";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // idmemberDataGridViewTextBoxColumn
            // 
            this.idmemberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idmemberDataGridViewTextBoxColumn.DataPropertyName = "id_member";
            this.idmemberDataGridViewTextBoxColumn.HeaderText = "ID Member";
            this.idmemberDataGridViewTextBoxColumn.Name = "idmemberDataGridViewTextBoxColumn";
            this.idmemberDataGridViewTextBoxColumn.Width = 142;
            // 
            // waktuambilDataGridViewTextBoxColumn
            // 
            this.waktuambilDataGridViewTextBoxColumn.DataPropertyName = "waktu_ambil";
            this.waktuambilDataGridViewTextBoxColumn.HeaderText = "Ambil";
            this.waktuambilDataGridViewTextBoxColumn.Name = "waktuambilDataGridViewTextBoxColumn";
            // 
            // waktukembaliDataGridViewTextBoxColumn
            // 
            this.waktukembaliDataGridViewTextBoxColumn.DataPropertyName = "waktu_kembali";
            this.waktukembaliDataGridViewTextBoxColumn.HeaderText = "Kembali";
            this.waktukembaliDataGridViewTextBoxColumn.Name = "waktukembaliDataGridViewTextBoxColumn";
            // 
            // namamemberDataGridViewTextBoxColumn
            // 
            this.namamemberDataGridViewTextBoxColumn.DataPropertyName = "nama_member";
            this.namamemberDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.namamemberDataGridViewTextBoxColumn.Name = "namamemberDataGridViewTextBoxColumn";
            // 
            // tglorderDataGridViewTextBoxColumn
            // 
            this.tglorderDataGridViewTextBoxColumn.DataPropertyName = "tgl_order";
            this.tglorderDataGridViewTextBoxColumn.HeaderText = "Tgl Order";
            this.tglorderDataGridViewTextBoxColumn.Name = "tglorderDataGridViewTextBoxColumn";
            // 
            // hargasewaDataGridViewTextBoxColumn
            // 
            this.hargasewaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hargasewaDataGridViewTextBoxColumn.DataPropertyName = "harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.HeaderText = "Harga Sewa";
            this.hargasewaDataGridViewTextBoxColumn.Name = "hargasewaDataGridViewTextBoxColumn";
            this.hargasewaDataGridViewTextBoxColumn.Width = 146;
            // 
            // status_order
            // 
            this.status_order.DataPropertyName = "status";
            this.status_order.HeaderText = "Status";
            this.status_order.Name = "status_order";
            // 
            // btn_review
            // 
            this.btn_review.DataPropertyName = "invoice_number";
            this.btn_review.HeaderText = "Action";
            this.btn_review.Name = "btn_review";
            this.btn_review.Text = "Review";
            this.btn_review.UseColumnTextForButtonValue = true;
            this.btn_review.Visible = false;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpaymentDataGridViewTextBoxColumn
            // 
            this.idpaymentDataGridViewTextBoxColumn.DataPropertyName = "id_payment";
            this.idpaymentDataGridViewTextBoxColumn.HeaderText = "id_payment";
            this.idpaymentDataGridViewTextBoxColumn.Name = "idpaymentDataGridViewTextBoxColumn";
            this.idpaymentDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewforpaymentsBindingSource
            // 
            this.viewforpaymentsBindingSource.DataMember = "view_for_payments";
            this.viewforpaymentsBindingSource.DataSource = this.db_rental_mobil_payments_new;
            // 
            // db_rental_mobil_payments_new
            // 
            this.db_rental_mobil_payments_new.DataSetName = "db_rental_mobil_payments_new";
            this.db_rental_mobil_payments_new.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_order_history
            // 
            this.tab_order_history.Controls.Add(this.panel2);
            this.tab_order_history.Location = new System.Drawing.Point(4, 25);
            this.tab_order_history.Name = "tab_order_history";
            this.tab_order_history.Padding = new System.Windows.Forms.Padding(3);
            this.tab_order_history.Size = new System.Drawing.Size(1246, 748);
            this.tab_order_history.TabIndex = 1;
            this.tab_order_history.Text = "Order History";
            this.tab_order_history.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dg_order_history);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 738);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dg_order_history
            // 
            this.dg_order_history.AllowCustomTheming = false;
            this.dg_order_history.AllowUserToAddRows = false;
            this.dg_order_history.AllowUserToDeleteRows = false;
            this.dg_order_history.AllowUserToResizeColumns = false;
            this.dg_order_history.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dg_order_history.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_order_history.AutoGenerateColumns = false;
            this.dg_order_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_order_history.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_order_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_order_history.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_order_history.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_order_history.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_order_history.ColumnHeadersHeight = 40;
            this.dg_order_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.status_order_history,
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dg_order_history.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dg_order_history.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dg_order_history.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dg_order_history.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dg_order_history.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_order_history.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dg_order_history.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dg_order_history.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dg_order_history.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dg_order_history.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_order_history.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dg_order_history.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dg_order_history.CurrentTheme.Name = null;
            this.dg_order_history.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_order_history.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dg_order_history.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dg_order_history.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dg_order_history.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_order_history.DataSource = this.viewforpaymentsBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_order_history.DefaultCellStyle = dataGridViewCellStyle7;
            this.dg_order_history.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_order_history.EnableHeadersVisualStyles = false;
            this.dg_order_history.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dg_order_history.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dg_order_history.HeaderBgColor = System.Drawing.Color.Empty;
            this.dg_order_history.HeaderForeColor = System.Drawing.Color.White;
            this.dg_order_history.Location = new System.Drawing.Point(3, 5);
            this.dg_order_history.MultiSelect = false;
            this.dg_order_history.Name = "dg_order_history";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_order_history.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dg_order_history.RowHeadersVisible = false;
            this.dg_order_history.RowTemplate.Height = 40;
            this.dg_order_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_order_history.Size = new System.Drawing.Size(1230, 719);
            this.dg_order_history.TabIndex = 2;
            this.dg_order_history.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invoice_number";
            this.dataGridViewTextBoxColumn1.HeaderText = "IN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mobil";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_member";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Member";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 142;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "waktu_ambil";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ambil";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "waktu_kembali";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kembali";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nama_member";
            this.dataGridViewTextBoxColumn6.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tgl_order";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tgl Order";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "harga_sewa";
            this.dataGridViewTextBoxColumn8.HeaderText = "Harga Sewa";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 146;
            // 
            // status_order_history
            // 
            this.status_order_history.DataPropertyName = "status";
            this.status_order_history.HeaderText = "Status";
            this.status_order_history.Name = "status_order_history";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "invoice_number";
            this.dataGridViewButtonColumn1.HeaderText = "Action";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Review";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "total_price";
            this.dataGridViewTextBoxColumn10.HeaderText = "total_price";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "id_payment";
            this.dataGridViewTextBoxColumn11.HeaderText = "id_payment";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // view_for_paymentsTableAdapter
            // 
            this.view_for_paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(1395, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tab_admin);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_payments);
            this.Controls.Add(this.btn_incoming_orders);
            this.Controls.Add(this.btn_orders_history);
            this.Controls.Add(this.menuStripAdmin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripAdmin;
            this.MaximizeBox = false;
            this.Name = "FormHomeAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomeAdmin";
            this.Load += new System.EventHandler(this.FormHomeAdmin_Load);
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.tab_admin.ResumeLayout(false);
            this.tab_incoming_order.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_incoming_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewforpaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_rental_mobil_payments_new)).EndInit();
            this.tab_order_history.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_order_history)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem dATAMASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_mobil_data_master;
        private System.Windows.Forms.ToolStripMenuItem ms_member_data_master;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.ToolStripMenuItem pROFILToolStripMenuItem;
        private System.Windows.Forms.TabControl tab_admin;
        private System.Windows.Forms.TabPage tab_order_history;
        private System.Windows.Forms.TabPage tab_incoming_order;
        private db_rental_mobil_payments_new db_rental_mobil_payments_new;
        private System.Windows.Forms.BindingSource viewforpaymentsBindingSource;
        private db_rental_mobil_payments_newTableAdapters.view_for_paymentsTableAdapter view_for_paymentsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dg_incoming_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuambilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktukembaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_order;
        private System.Windows.Forms.DataGridViewButtonColumn btn_review;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dg_order_history;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_order_history;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button1;
    }
}