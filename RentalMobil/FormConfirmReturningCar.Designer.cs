namespace RentalMobil
{
    partial class FormConfirmReturningCar
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmReturningCar));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelBayar = new System.Windows.Forms.Panel();
            this.nominal_denda = new System.Windows.Forms.Label();
            this.pilih_bank = new System.Windows.Forms.Label();
            this.btn_cancel_payment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_simpan_payment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tanggal_konfirmasi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBayar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBayar
            // 
            this.panelBayar.Controls.Add(this.label1);
            this.panelBayar.Controls.Add(this.tanggal_konfirmasi);
            this.panelBayar.Controls.Add(this.bunifuButton1);
            this.panelBayar.Controls.Add(this.nominal_denda);
            this.panelBayar.Controls.Add(this.pilih_bank);
            this.panelBayar.Controls.Add(this.btn_cancel_payment);
            this.panelBayar.Controls.Add(this.btn_simpan_payment);
            this.panelBayar.Location = new System.Drawing.Point(12, 12);
            this.panelBayar.Name = "panelBayar";
            this.panelBayar.Size = new System.Drawing.Size(1163, 577);
            this.panelBayar.TabIndex = 50;
            // 
            // nominal_denda
            // 
            this.nominal_denda.AutoSize = true;
            this.nominal_denda.Location = new System.Drawing.Point(167, 75);
            this.nominal_denda.Name = "nominal_denda";
            this.nominal_denda.Size = new System.Drawing.Size(16, 17);
            this.nominal_denda.TabIndex = 27;
            this.nominal_denda.Text = "0";
            // 
            // pilih_bank
            // 
            this.pilih_bank.AutoSize = true;
            this.pilih_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilih_bank.Location = new System.Drawing.Point(21, 21);
            this.pilih_bank.Name = "pilih_bank";
            this.pilih_bank.Size = new System.Drawing.Size(124, 17);
            this.pilih_bank.TabIndex = 24;
            this.pilih_bank.Text = "Tanggal Hari ini";
            // 
            // btn_cancel_payment
            // 
            this.btn_cancel_payment.AllowToggling = false;
            this.btn_cancel_payment.AnimationSpeed = 200;
            this.btn_cancel_payment.AutoGenerateColors = false;
            this.btn_cancel_payment.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel_payment.BackColor1 = System.Drawing.Color.BlanchedAlmond;
            this.btn_cancel_payment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel_payment.BackgroundImage")));
            this.btn_cancel_payment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_cancel_payment.ButtonText = "Cancel";
            this.btn_cancel_payment.ButtonTextMarginLeft = 0;
            this.btn_cancel_payment.ColorContrastOnClick = 45;
            this.btn_cancel_payment.ColorContrastOnHover = 45;
            this.btn_cancel_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_cancel_payment.CustomizableEdges = borderEdges5;
            this.btn_cancel_payment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cancel_payment.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_cancel_payment.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_cancel_payment.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_cancel_payment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_cancel_payment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_cancel_payment.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cancel_payment.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_payment.IconMarginLeft = 11;
            this.btn_cancel_payment.IconPadding = 10;
            this.btn_cancel_payment.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_payment.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_cancel_payment.IdleBorderRadius = 3;
            this.btn_cancel_payment.IdleBorderThickness = 1;
            this.btn_cancel_payment.IdleFillColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_cancel_payment.IdleIconLeftImage = null;
            this.btn_cancel_payment.IdleIconRightImage = null;
            this.btn_cancel_payment.IndicateFocus = false;
            this.btn_cancel_payment.Location = new System.Drawing.Point(822, 517);
            this.btn_cancel_payment.Name = "btn_cancel_payment";
            this.btn_cancel_payment.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_cancel_payment.onHoverState.BorderRadius = 3;
            this.btn_cancel_payment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_cancel_payment.onHoverState.BorderThickness = 1;
            this.btn_cancel_payment.onHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel_payment.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cancel_payment.onHoverState.IconLeftImage = null;
            this.btn_cancel_payment.onHoverState.IconRightImage = null;
            this.btn_cancel_payment.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_cancel_payment.OnIdleState.BorderRadius = 3;
            this.btn_cancel_payment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_cancel_payment.OnIdleState.BorderThickness = 1;
            this.btn_cancel_payment.OnIdleState.FillColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_cancel_payment.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cancel_payment.OnIdleState.IconLeftImage = null;
            this.btn_cancel_payment.OnIdleState.IconRightImage = null;
            this.btn_cancel_payment.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_cancel_payment.OnPressedState.BorderRadius = 3;
            this.btn_cancel_payment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_cancel_payment.OnPressedState.BorderThickness = 1;
            this.btn_cancel_payment.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_cancel_payment.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_cancel_payment.OnPressedState.IconLeftImage = null;
            this.btn_cancel_payment.OnPressedState.IconRightImage = null;
            this.btn_cancel_payment.Size = new System.Drawing.Size(136, 32);
            this.btn_cancel_payment.TabIndex = 22;
            this.btn_cancel_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel_payment.TextMarginLeft = 0;
            this.btn_cancel_payment.UseDefaultRadiusAndThickness = true;
            // 
            // btn_simpan_payment
            // 
            this.btn_simpan_payment.AllowToggling = false;
            this.btn_simpan_payment.AnimationSpeed = 200;
            this.btn_simpan_payment.AutoGenerateColors = false;
            this.btn_simpan_payment.BackColor = System.Drawing.Color.Transparent;
            this.btn_simpan_payment.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_simpan_payment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_simpan_payment.BackgroundImage")));
            this.btn_simpan_payment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_simpan_payment.ButtonText = "Confirm";
            this.btn_simpan_payment.ButtonTextMarginLeft = 0;
            this.btn_simpan_payment.ColorContrastOnClick = 45;
            this.btn_simpan_payment.ColorContrastOnHover = 45;
            this.btn_simpan_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btn_simpan_payment.CustomizableEdges = borderEdges6;
            this.btn_simpan_payment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_simpan_payment.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_simpan_payment.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_simpan_payment.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_simpan_payment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_simpan_payment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_simpan_payment.ForeColor = System.Drawing.Color.White;
            this.btn_simpan_payment.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpan_payment.IconMarginLeft = 11;
            this.btn_simpan_payment.IconPadding = 10;
            this.btn_simpan_payment.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpan_payment.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_simpan_payment.IdleBorderRadius = 3;
            this.btn_simpan_payment.IdleBorderThickness = 1;
            this.btn_simpan_payment.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_simpan_payment.IdleIconLeftImage = null;
            this.btn_simpan_payment.IdleIconRightImage = null;
            this.btn_simpan_payment.IndicateFocus = false;
            this.btn_simpan_payment.Location = new System.Drawing.Point(680, 517);
            this.btn_simpan_payment.Name = "btn_simpan_payment";
            this.btn_simpan_payment.onHoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_simpan_payment.onHoverState.BorderRadius = 3;
            this.btn_simpan_payment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_simpan_payment.onHoverState.BorderThickness = 1;
            this.btn_simpan_payment.onHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_simpan_payment.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.btn_simpan_payment.onHoverState.IconLeftImage = null;
            this.btn_simpan_payment.onHoverState.IconRightImage = null;
            this.btn_simpan_payment.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_simpan_payment.OnIdleState.BorderRadius = 3;
            this.btn_simpan_payment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_simpan_payment.OnIdleState.BorderThickness = 1;
            this.btn_simpan_payment.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_simpan_payment.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_simpan_payment.OnIdleState.IconLeftImage = null;
            this.btn_simpan_payment.OnIdleState.IconRightImage = null;
            this.btn_simpan_payment.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_simpan_payment.OnPressedState.BorderRadius = 3;
            this.btn_simpan_payment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_simpan_payment.OnPressedState.BorderThickness = 1;
            this.btn_simpan_payment.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_simpan_payment.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_simpan_payment.OnPressedState.IconLeftImage = null;
            this.btn_simpan_payment.OnPressedState.IconRightImage = null;
            this.btn_simpan_payment.Size = new System.Drawing.Size(136, 32);
            this.btn_simpan_payment.TabIndex = 21;
            this.btn_simpan_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_simpan_payment.TextMarginLeft = 0;
            this.btn_simpan_payment.UseDefaultRadiusAndThickness = true;
            this.btn_simpan_payment.Click += new System.EventHandler(this.btn_simpan_payment_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.PaleTurquoise;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Cek Denda";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges4;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(24, 64);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 3;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.BorderRadius = 3;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 3;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(105, 28);
            this.bunifuButton1.TabIndex = 28;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click_1);
            // 
            // tanggal_konfirmasi
            // 
            this.tanggal_konfirmasi.Location = new System.Drawing.Point(170, 21);
            this.tanggal_konfirmasi.Name = "tanggal_konfirmasi";
            this.tanggal_konfirmasi.Size = new System.Drawing.Size(200, 22);
            this.tanggal_konfirmasi.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1071, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "-";
            // 
            // FormConfirmReturningCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 602);
            this.Controls.Add(this.panelBayar);
            this.Location = new System.Drawing.Point(400, 160);
            this.Name = "FormConfirmReturningCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Konfirmasi Pengembalian";
            this.Load += new System.EventHandler(this.FormConfirmReturningCar_Load);
            this.panelBayar.ResumeLayout(false);
            this.panelBayar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBayar;
        private System.Windows.Forms.Label nominal_denda;
        private System.Windows.Forms.Label pilih_bank;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_cancel_payment;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_simpan_payment;
        private System.Windows.Forms.DateTimePicker tanggal_konfirmasi;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label1;
    }
}