
namespace Library
{
    partial class singUpPage
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
            this.signUpPage = new System.Windows.Forms.Label();
            this.signInLink = new System.Windows.Forms.LinkLabel();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.usernmeLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.haveAccountLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.confirmPasswordInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpPage
            // 
            this.signUpPage.AutoSize = true;
            this.signUpPage.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPage.ForeColor = System.Drawing.Color.White;
            this.signUpPage.Location = new System.Drawing.Point(318, 18);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Size = new System.Drawing.Size(126, 32);
            this.signUpPage.TabIndex = 0;
            this.signUpPage.Text = "Sign Up";
            // 
            // signInLink
            // 
            this.signInLink.AutoSize = true;
            this.signInLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLink.LinkColor = System.Drawing.Color.White;
            this.signInLink.Location = new System.Drawing.Point(438, 598);
            this.signInLink.Name = "signInLink";
            this.signInLink.Size = new System.Drawing.Size(73, 25);
            this.signInLink.TabIndex = 7;
            this.signInLink.TabStop = true;
            this.signInLink.Text = "Sign In";
            this.signInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signInLink_LinkClicked);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInput.Location = new System.Drawing.Point(249, 96);
            this.firstNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(328, 32);
            this.firstNameInput.TabIndex = 13;
            this.firstNameInput.TextChanged += new System.EventHandler(this.firstNameInput_TextChanged);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.White;
            this.signUpBtn.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signUpBtn.Location = new System.Drawing.Point(276, 510);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(177, 58);
            this.signUpBtn.TabIndex = 14;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Reader",
            "Auther",
            "Admin"});
            this.typeBox.Location = new System.Drawing.Point(249, 298);
            this.typeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(328, 28);
            this.typeBox.TabIndex = 15;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(34, 96);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(149, 29);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // usernmeLabel
            // 
            this.usernmeLabel.AutoSize = true;
            this.usernmeLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.usernmeLabel.ForeColor = System.Drawing.Color.White;
            this.usernmeLabel.Location = new System.Drawing.Point(37, 202);
            this.usernmeLabel.Name = "usernmeLabel";
            this.usernmeLabel.Size = new System.Drawing.Size(140, 29);
            this.usernmeLabel.TabIndex = 26;
            this.usernmeLabel.Text = "Username";
            this.usernmeLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(34, 148);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(143, 29);
            this.lastNameLabel.TabIndex = 27;
            this.lastNameLabel.Text = "Last Name";
            // 
            // haveAccountLabel
            // 
            this.haveAccountLabel.AutoSize = true;
            this.haveAccountLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.haveAccountLabel.ForeColor = System.Drawing.Color.White;
            this.haveAccountLabel.Location = new System.Drawing.Point(196, 602);
            this.haveAccountLabel.Name = "haveAccountLabel";
            this.haveAccountLabel.Size = new System.Drawing.Size(236, 21);
            this.haveAccountLabel.TabIndex = 28;
            this.haveAccountLabel.Text = "Aready Have Account ??";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold);
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(12, 404);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(221, 27);
            this.confirmPasswordLabel.TabIndex = 29;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(34, 348);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(132, 29);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Password";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(37, 251);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(92, 29);
            this.phoneLabel.TabIndex = 31;
            this.phoneLabel.Text = "Phone";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(249, 348);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(328, 32);
            this.passwordInput.TabIndex = 32;
            this.passwordInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(249, 202);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(328, 32);
            this.usernameInput.TabIndex = 33;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
            // 
            // phoneInput
            // 
            this.phoneInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneInput.Location = new System.Drawing.Point(249, 248);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(328, 32);
            this.phoneInput.TabIndex = 34;
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordInput.Location = new System.Drawing.Point(249, 404);
            this.confirmPasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.Size = new System.Drawing.Size(328, 32);
            this.confirmPasswordInput.TabIndex = 35;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInput.Location = new System.Drawing.Point(249, 148);
            this.lastNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(328, 32);
            this.lastNameInput.TabIndex = 36;
            this.lastNameInput.TextChanged += new System.EventHandler(this.lastNameInput_TextChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(37, 298);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(72, 29);
            this.typeLabel.TabIndex = 37;
            this.typeLabel.Text = "Type";
            // 
            // singUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(752, 666);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.haveAccountLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.usernmeLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.signInLink);
            this.Controls.Add(this.signUpPage);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "singUpPage";
            this.Text = "Sign UP";
            this.Load += new System.EventHandler(this.singUpPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpPage;
        private System.Windows.Forms.LinkLabel signInLink;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label usernmeLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label haveAccountLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox confirmPasswordInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label typeLabel;
    }
}