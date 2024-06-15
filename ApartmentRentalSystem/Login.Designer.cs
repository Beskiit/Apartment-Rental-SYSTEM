namespace ApartmentRentalSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.userInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.clerkButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordInput
            // 
            this.passwordInput.AutoRoundedCorners = true;
            this.passwordInput.BorderRadius = 26;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordInput.ForeColor = System.Drawing.Color.Black;
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Location = new System.Drawing.Point(76, 318);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.PlaceholderText = "";
            this.passwordInput.SelectedText = "";
            this.passwordInput.Size = new System.Drawing.Size(300, 55);
            this.passwordInput.TabIndex = 2;
            // 
            // userInput
            // 
            this.userInput.AutoRoundedCorners = true;
            this.userInput.BorderRadius = 26;
            this.userInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userInput.DefaultText = "";
            this.userInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userInput.ForeColor = System.Drawing.Color.Black;
            this.userInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userInput.Location = new System.Drawing.Point(76, 198);
            this.userInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userInput.Name = "userInput";
            this.userInput.PasswordChar = '\0';
            this.userInput.PlaceholderText = "";
            this.userInput.SelectedText = "";
            this.userInput.Size = new System.Drawing.Size(300, 55);
            this.userInput.TabIndex = 1;
            // 
            // clerkButton
            // 
            this.clerkButton.Animated = true;
            this.clerkButton.AutoRoundedCorners = true;
            this.clerkButton.BorderRadius = 23;
            this.clerkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clerkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clerkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clerkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clerkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clerkButton.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.clerkButton.ForeColor = System.Drawing.Color.White;
            this.clerkButton.Location = new System.Drawing.Point(156, 442);
            this.clerkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clerkButton.Name = "clerkButton";
            this.clerkButton.Size = new System.Drawing.Size(142, 49);
            this.clerkButton.TabIndex = 3;
            this.clerkButton.Text = "Login";
            this.clerkButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(471, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(527, 625);
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(210)))), ((int)(((byte)(186)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(950, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 40);
            this.closeButton.TabIndex = 10;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(40)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(996, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.clerkButton);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.passwordInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private Guna.UI2.WinForms.Guna2Button clerkButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox userInput;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

