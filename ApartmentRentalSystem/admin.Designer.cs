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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userIcon = new System.Windows.Forms.Button();
            this.paymentIcon = new System.Windows.Forms.Button();
            this.tenantIcon = new System.Windows.Forms.Button();
            this.unitsIcon = new System.Windows.Forms.Button();
            this.dashboardIcon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.adminDashboardScreen1 = new ApartmentRentalSystem.adminDashboardScreen();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.userIcon);
            this.panel1.Controls.Add(this.paymentIcon);
            this.panel1.Controls.Add(this.tenantIcon);
            this.panel1.Controls.Add(this.unitsIcon);
            this.panel1.Controls.Add(this.dashboardIcon);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 500);
            this.panel1.TabIndex = 0;
            // 
            // userIcon
            // 
            this.userIcon.AutoSize = true;
            this.userIcon.FlatAppearance.BorderSize = 0;
            this.userIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userIcon.Location = new System.Drawing.Point(3, 222);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(177, 40);
            this.userIcon.TabIndex = 2;
            this.userIcon.Text = "Users";
            this.userIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userIcon.UseVisualStyleBackColor = true;
            this.userIcon.Click += new System.EventHandler(this.userIcon_Click);
            // 
            // paymentIcon
            // 
            this.paymentIcon.AutoSize = true;
            this.paymentIcon.FlatAppearance.BorderSize = 0;
            this.paymentIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentIcon.Image = ((System.Drawing.Image)(resources.GetObject("paymentIcon.Image")));
            this.paymentIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentIcon.Location = new System.Drawing.Point(0, 168);
            this.paymentIcon.Name = "paymentIcon";
            this.paymentIcon.Size = new System.Drawing.Size(177, 40);
            this.paymentIcon.TabIndex = 2;
            this.paymentIcon.Text = "Payments";
            this.paymentIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paymentIcon.UseVisualStyleBackColor = true;
            this.paymentIcon.Click += new System.EventHandler(this.paymentIcon_Click);
            // 
            // tenantIcon
            // 
            this.tenantIcon.AutoSize = true;
            this.tenantIcon.FlatAppearance.BorderSize = 0;
            this.tenantIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenantIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantIcon.Image = ((System.Drawing.Image)(resources.GetObject("tenantIcon.Image")));
            this.tenantIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tenantIcon.Location = new System.Drawing.Point(3, 114);
            this.tenantIcon.Name = "tenantIcon";
            this.tenantIcon.Size = new System.Drawing.Size(177, 40);
            this.tenantIcon.TabIndex = 2;
            this.tenantIcon.Text = "Tenants";
            this.tenantIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tenantIcon.UseVisualStyleBackColor = true;
            this.tenantIcon.Click += new System.EventHandler(this.tenantIcon_Click);
            // 
            // unitsIcon
            // 
            this.unitsIcon.AutoSize = true;
            this.unitsIcon.FlatAppearance.BorderSize = 0;
            this.unitsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitsIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsIcon.Image = ((System.Drawing.Image)(resources.GetObject("unitsIcon.Image")));
            this.unitsIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unitsIcon.Location = new System.Drawing.Point(3, 60);
            this.unitsIcon.Name = "unitsIcon";
            this.unitsIcon.Size = new System.Drawing.Size(177, 40);
            this.unitsIcon.TabIndex = 2;
            this.unitsIcon.Text = "Units";
            this.unitsIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unitsIcon.UseVisualStyleBackColor = true;
            this.unitsIcon.Click += new System.EventHandler(this.unitsIcon_Click);
            // 
            // dashboardIcon
            // 
            this.dashboardIcon.AutoSize = true;
            this.dashboardIcon.FlatAppearance.BorderSize = 0;
            this.dashboardIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardIcon.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardIcon.Image = ((System.Drawing.Image)(resources.GetObject("dashboardIcon.Image")));
            this.dashboardIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardIcon.Location = new System.Drawing.Point(3, 6);
            this.dashboardIcon.Name = "dashboardIcon";
            this.dashboardIcon.Size = new System.Drawing.Size(177, 40);
            this.dashboardIcon.TabIndex = 2;
            this.dashboardIcon.Text = "Dashboard";
            this.dashboardIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardIcon.UseVisualStyleBackColor = true;
            this.dashboardIcon.Click += new System.EventHandler(this.dashboardIcon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(40)))), ((int)(((byte)(17)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 60);
            this.panel2.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.adminDashboardScreen1);
            this.mainPanel.Location = new System.Drawing.Point(183, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(802, 500);
            this.mainPanel.TabIndex = 2;
            // 
            // adminDashboardScreen1
            // 
            this.adminDashboardScreen1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboardScreen1.Name = "adminDashboardScreen1";
            this.adminDashboardScreen1.Size = new System.Drawing.Size(800, 500);
            this.adminDashboardScreen1.TabIndex = 0;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dashboardIcon;
        private System.Windows.Forms.Button unitsIcon;
        private System.Windows.Forms.Button tenantIcon;
        private System.Windows.Forms.Button userIcon;
        private System.Windows.Forms.Button paymentIcon;
        private System.Windows.Forms.Panel mainPanel;
        private adminDashboardScreen adminDashboardScreen1;
    }
}