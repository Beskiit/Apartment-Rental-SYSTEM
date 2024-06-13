namespace ApartmentRentalSystem
{
    partial class admin
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dashboardIcon = new System.Windows.Forms.Button();
            this.unitsIcon = new System.Windows.Forms.Button();
            this.tenantIcon = new System.Windows.Forms.Button();
            this.paymentIcon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lease = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(40)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1731, 92);
            this.panel2.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(1461, 20);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(161, 42);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Hello , Admin!";
            // 
            // logoutButton
            // 
            this.guna2Transition1.SetDecoration(this.logoutButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.Location = new System.Drawing.Point(18, 846);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(138, 58);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.mainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mainPanel.Location = new System.Drawing.Point(274, 92);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1424, 924);
            this.mainPanel.TabIndex = 2;
            // 
            // dashboardIcon
            // 
            this.dashboardIcon.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.dashboardIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dashboardIcon.FlatAppearance.BorderSize = 0;
            this.dashboardIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardIcon.Image = ((System.Drawing.Image)(resources.GetObject("dashboardIcon.Image")));
            this.dashboardIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardIcon.Location = new System.Drawing.Point(18, 9);
            this.dashboardIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboardIcon.Name = "dashboardIcon";
            this.dashboardIcon.Size = new System.Drawing.Size(286, 77);
            this.dashboardIcon.TabIndex = 2;
            this.dashboardIcon.Text = "Dashboard";
            this.dashboardIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardIcon.UseVisualStyleBackColor = true;
            this.dashboardIcon.Click += new System.EventHandler(this.dashboardIcon_Click);
            // 
            // unitsIcon
            // 
            this.unitsIcon.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.unitsIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.unitsIcon.FlatAppearance.BorderSize = 0;
            this.unitsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitsIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsIcon.Image = ((System.Drawing.Image)(resources.GetObject("unitsIcon.Image")));
            this.unitsIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unitsIcon.Location = new System.Drawing.Point(18, 85);
            this.unitsIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unitsIcon.Name = "unitsIcon";
            this.unitsIcon.Size = new System.Drawing.Size(252, 77);
            this.unitsIcon.TabIndex = 2;
            this.unitsIcon.Text = "Units";
            this.unitsIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unitsIcon.UseVisualStyleBackColor = true;
            this.unitsIcon.Click += new System.EventHandler(this.unitsIcon_Click);
            // 
            // tenantIcon
            // 
            this.tenantIcon.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.tenantIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tenantIcon.FlatAppearance.BorderSize = 0;
            this.tenantIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenantIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantIcon.Image = ((System.Drawing.Image)(resources.GetObject("tenantIcon.Image")));
            this.tenantIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tenantIcon.Location = new System.Drawing.Point(18, 160);
            this.tenantIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tenantIcon.Name = "tenantIcon";
            this.tenantIcon.Size = new System.Drawing.Size(252, 77);
            this.tenantIcon.TabIndex = 2;
            this.tenantIcon.Text = "Tenants";
            this.tenantIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tenantIcon.UseVisualStyleBackColor = true;
            this.tenantIcon.Click += new System.EventHandler(this.tenantIcon_Click);
            // 
            // paymentIcon
            // 
            this.paymentIcon.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.paymentIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.paymentIcon.FlatAppearance.BorderSize = 0;
            this.paymentIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentIcon.Image = ((System.Drawing.Image)(resources.GetObject("paymentIcon.Image")));
            this.paymentIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentIcon.Location = new System.Drawing.Point(18, 235);
            this.paymentIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentIcon.Name = "paymentIcon";
            this.paymentIcon.Size = new System.Drawing.Size(267, 77);
            this.paymentIcon.TabIndex = 2;
            this.paymentIcon.Text = "Payments";
            this.paymentIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentIcon.UseVisualStyleBackColor = true;
            this.paymentIcon.Click += new System.EventHandler(this.paymentIcon_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(40)))), ((int)(((byte)(17)))));
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 62);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.Lease);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.paymentIcon);
            this.panel1.Controls.Add(this.tenantIcon);
            this.panel1.Controls.Add(this.unitsIcon);
            this.panel1.Controls.Add(this.dashboardIcon);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 1002);
            this.panel1.TabIndex = 0;
            // 
            // Lease
            // 
            this.guna2Transition1.SetDecoration(this.Lease, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Lease.FlatAppearance.BorderSize = 0;
            this.Lease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lease.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lease.Image = ((System.Drawing.Image)(resources.GetObject("Lease.Image")));
            this.Lease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lease.Location = new System.Drawing.Point(18, 386);
            this.Lease.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lease.Name = "Lease";
            this.Lease.Size = new System.Drawing.Size(252, 62);
            this.Lease.TabIndex = 4;
            this.Lease.Text = "Lease";
            this.Lease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Lease.UseVisualStyleBackColor = true;
            this.Lease.Click += new System.EventHandler(this.Lease_Click);
            // 
            // button1
            // 
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(18, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Transactions";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1701, 1017);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arsenia Apartment Rental System";
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private adminDashboardScreen adminDashboardScreen1;
        private adminUnitScreen adminUnitScreen1;
        private adminPaymentScreen adminPaymentScreen1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button dashboardIcon;
        private System.Windows.Forms.Button unitsIcon;
        private System.Windows.Forms.Button tenantIcon;
        private System.Windows.Forms.Button paymentIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Button Lease;
    }
}