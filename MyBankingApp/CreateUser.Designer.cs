
namespace MyBankingApp
{
    partial class CreateUser
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
            this.backLogin = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateAcctLabel = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.FNameField = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.LNameField = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backLogin
            // 
            this.backLogin.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.backLogin.AutoSize = true;
            this.backLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backLogin.LinkColor = System.Drawing.Color.RoyalBlue;
            this.backLogin.Location = new System.Drawing.Point(390, 626);
            this.backLogin.Name = "backLogin";
            this.backLogin.Size = new System.Drawing.Size(73, 32);
            this.backLogin.TabIndex = 15;
            this.backLogin.TabStop = true;
            this.backLogin.Text = "Login";
            this.backLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLogin_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alredy have an account? ";
            // 
            // CreateAcctLabel
            // 
            this.CreateAcctLabel.AutoSize = true;
            this.CreateAcctLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateAcctLabel.Location = new System.Drawing.Point(102, 65);
            this.CreateAcctLabel.Name = "CreateAcctLabel";
            this.CreateAcctLabel.Size = new System.Drawing.Size(471, 32);
            this.CreateAcctLabel.TabIndex = 13;
            this.CreateAcctLabel.Text = "A new User account will be created for you";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnCreateUser.Location = new System.Drawing.Point(102, 559);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(153, 41);
            this.btnCreateUser.TabIndex = 12;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordField.Location = new System.Drawing.Point(102, 495);
            this.passwordField.Name = "passwordField";
            this.passwordField.PlaceholderText = "password";
            this.passwordField.Size = new System.Drawing.Size(454, 39);
            this.passwordField.TabIndex = 11;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(102, 452);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(113, 32);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailField.Location = new System.Drawing.Point(102, 397);
            this.emailField.Name = "emailField";
            this.emailField.PlaceholderText = "email address, e.g, example@domain.com";
            this.emailField.Size = new System.Drawing.Size(454, 39);
            this.emailField.TabIndex = 9;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(102, 346);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 32);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "email";
            // 
            // FNameField
            // 
            this.FNameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FNameField.Location = new System.Drawing.Point(102, 176);
            this.FNameField.Name = "FNameField";
            this.FNameField.PlaceholderText = "First name. e.g, John";
            this.FNameField.Size = new System.Drawing.Size(454, 39);
            this.FNameField.TabIndex = 17;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(102, 131);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(129, 32);
            this.firstName.TabIndex = 16;
            this.firstName.Text = "First Name";
            // 
            // LNameField
            // 
            this.LNameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LNameField.Location = new System.Drawing.Point(102, 288);
            this.LNameField.Name = "LNameField";
            this.LNameField.PlaceholderText = "Last name. e.g, Doe";
            this.LNameField.Size = new System.Drawing.Size(454, 39);
            this.LNameField.TabIndex = 19;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(102, 243);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(126, 32);
            this.lastName.TabIndex = 18;
            this.lastName.Text = "Last Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyBankingApp.Properties.Resources.Bank11;
            this.pictureBox1.Location = new System.Drawing.Point(625, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 629);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 706);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LNameField);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.FNameField);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.backLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateAcctLabel);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.emailLabel);
            this.Name = "CreateUser";
            this.Text = "Create an Account";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel backLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CreateAcctLabel;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox FNameField;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox LNameField;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}