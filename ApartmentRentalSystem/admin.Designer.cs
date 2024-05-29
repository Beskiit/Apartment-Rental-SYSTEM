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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminDashboardScreen1 = new ApartmentRentalSystem.adminDashboardScreen();
            this.adminUnitScreen1 = new ApartmentRentalSystem.adminUnitScreen();
            this.adminPaymentScreen1 = new ApartmentRentalSystem.adminPaymentScreen();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dashboardIcon = new System.Windows.Forms.Button();
            this.unitsIcon = new System.Windows.Forms.Button();
            this.tenantIcon = new System.Windows.Forms.Button();
            this.paymentIcon = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(40)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1313, 74);
            this.panel2.TabIndex = 1;
            // 
            // adminDashboardScreen1
            // 
            this.adminDashboardScreen1.AutoSize = true;
            this.adminDashboardScreen1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboardScreen1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminDashboardScreen1.Name = "adminDashboardScreen1";
            this.adminDashboardScreen1.Size = new System.Drawing.Size(1369, 638);
            this.adminDashboardScreen1.TabIndex = 0;
            this.adminDashboardScreen1.Load += new System.EventHandler(this.adminDashboardScreen1_Load);
            // 
            // adminUnitScreen1
            // 
            this.adminUnitScreen1.Location = new System.Drawing.Point(0, 0);
            this.adminUnitScreen1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminUnitScreen1.Name = "adminUnitScreen1";
            this.adminUnitScreen1.Size = new System.Drawing.Size(1067, 615);
            this.adminUnitScreen1.TabIndex = 1;
            // 
            // adminPaymentScreen1
            // 
            this.adminPaymentScreen1.Location = new System.Drawing.Point(0, 0);
            this.adminPaymentScreen1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminPaymentScreen1.Name = "adminPaymentScreen1";
            this.adminPaymentScreen1.Size = new System.Drawing.Size(1067, 615);
            this.adminPaymentScreen1.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.adminDashboardScreen1);
            this.mainPanel.Controls.Add(this.adminPaymentScreen1);
            this.mainPanel.Controls.Add(this.adminUnitScreen1);
            this.mainPanel.Location = new System.Drawing.Point(244, 74);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1069, 615);
            this.mainPanel.TabIndex = 2;
            // 
            // dashboardIcon
            // 
            this.dashboardIcon.AutoSize = true;
            this.dashboardIcon.FlatAppearance.BorderSize = 0;
            this.dashboardIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardIcon.Image = ((System.Drawing.Image)(resources.GetObject("dashboardIcon.Image")));
            this.dashboardIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardIcon.Location = new System.Drawing.Point(16, 7);
            this.dashboardIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashboardIcon.Name = "dashboardIcon";
            this.dashboardIcon.Size = new System.Drawing.Size(224, 49);
            this.dashboardIcon.TabIndex = 2;
            this.dashboardIcon.Text = "Dashboard";
            this.dashboardIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardIcon.UseVisualStyleBackColor = true;
            this.dashboardIcon.Click += new System.EventHandler(this.dashboardIcon_Click);
            // 
            // unitsIcon
            // 
            this.unitsIcon.AutoSize = true;
            this.unitsIcon.FlatAppearance.BorderSize = 0;
            this.unitsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitsIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsIcon.Image = ((System.Drawing.Image)(resources.GetObject("unitsIcon.Image")));
            this.unitsIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unitsIcon.Location = new System.Drawing.Point(16, 74);
            this.unitsIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unitsIcon.Name = "unitsIcon";
            this.unitsIcon.Size = new System.Drawing.Size(224, 49);
            this.unitsIcon.TabIndex = 2;
            this.unitsIcon.Text = "Units";
            this.unitsIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unitsIcon.UseVisualStyleBackColor = true;
            this.unitsIcon.Click += new System.EventHandler(this.unitsIcon_Click);
            // 
            // tenantIcon
            // 
            this.tenantIcon.AutoSize = true;
            this.tenantIcon.FlatAppearance.BorderSize = 0;
            this.tenantIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenantIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantIcon.Image = ((System.Drawing.Image)(resources.GetObject("tenantIcon.Image")));
            this.tenantIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tenantIcon.Location = new System.Drawing.Point(16, 140);
            this.tenantIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenantIcon.Name = "tenantIcon";
            this.tenantIcon.Size = new System.Drawing.Size(224, 49);
            this.tenantIcon.TabIndex = 2;
            this.tenantIcon.Text = "Tenants";
            this.tenantIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tenantIcon.UseVisualStyleBackColor = true;
            this.tenantIcon.Click += new System.EventHandler(this.tenantIcon_Click);
            // 
            // paymentIcon
            // 
            this.paymentIcon.AutoSize = true;
            this.paymentIcon.FlatAppearance.BorderSize = 0;
            this.paymentIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentIcon.Image = ((System.Drawing.Image)(resources.GetObject("paymentIcon.Image")));
            this.paymentIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentIcon.Location = new System.Drawing.Point(16, 207);
            this.paymentIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paymentIcon.Name = "paymentIcon";
            this.paymentIcon.Size = new System.Drawing.Size(224, 49);
            this.paymentIcon.TabIndex = 2;
            this.paymentIcon.Text = "Payments";
            this.paymentIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentIcon.UseVisualStyleBackColor = true;
            this.paymentIcon.Click += new System.EventHandler(this.paymentIcon_Click);
            // 
            // userIcon
            // 
            this.userIcon.AutoSize = true;
            this.userIcon.FlatAppearance.BorderSize = 0;
            this.userIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userIcon.Location = new System.Drawing.Point(16, 273);
            this.userIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(224, 49);
            this.userIcon.TabIndex = 2;
            this.userIcon.Text = "Users";
            this.userIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userIcon.UseVisualStyleBackColor = true;
            this.userIcon.Click += new System.EventHandler(this.userIcon_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(40)))), ((int)(((byte)(17)))));
            this.panel3.Location = new System.Drawing.Point(0, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 49);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.userIcon);
            this.panel1.Controls.Add(this.paymentIcon);
            this.panel1.Controls.Add(this.tenantIcon);
            this.panel1.Controls.Add(this.unitsIcon);
            this.panel1.Controls.Add(this.dashboardIcon);
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 615);
            this.panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1070, 30);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "button1";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.panel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
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
        private System.Windows.Forms.Button userIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
    }
}