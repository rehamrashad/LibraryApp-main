
namespace Library
{
    partial class UpdateProfile
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
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.confirmPasswordInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.signUpPage = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInput.Location = new System.Drawing.Point(387, 256);
            this.lastNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(303, 32);
            this.lastNameInput.TabIndex = 54;
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordInput.Location = new System.Drawing.Point(387, 470);
            this.confirmPasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.Size = new System.Drawing.Size(303, 32);
            this.confirmPasswordInput.TabIndex = 53;
            // 
            // phoneInput
            // 
            this.phoneInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneInput.Location = new System.Drawing.Point(387, 328);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneInput.Multiline = true;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(303, 26);
            this.phoneInput.TabIndex = 52;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(387, 395);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(303, 32);
            this.passwordInput.TabIndex = 50;
            this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(142, 330);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(92, 29);
            this.phoneLabel.TabIndex = 49;
            this.phoneLabel.Text = "Phone";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(142, 396);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(132, 29);
            this.passwordLabel.TabIndex = 48;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold);
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(142, 472);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(221, 27);
            this.confirmPasswordLabel.TabIndex = 47;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(142, 259);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(143, 29);
            this.lastNameLabel.TabIndex = 45;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(142, 182);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(149, 29);
            this.firstNameLabel.TabIndex = 43;
            this.firstNameLabel.Text = "First Name";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updateBtn.Location = new System.Drawing.Point(417, 554);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(172, 58);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInput.Location = new System.Drawing.Point(387, 182);
            this.firstNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(303, 32);
            this.firstNameInput.TabIndex = 40;
            this.firstNameInput.TextChanged += new System.EventHandler(this.firstNameInput_TextChanged);
            // 
            // signUpPage
            // 
            this.signUpPage.AutoSize = true;
            this.signUpPage.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPage.ForeColor = System.Drawing.Color.White;
            this.signUpPage.Location = new System.Drawing.Point(457, -78);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Size = new System.Drawing.Size(126, 32);
            this.signUpPage.TabIndex = 38;
            this.signUpPage.Text = "Sign Up";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.updateLabel.ForeColor = System.Drawing.Color.White;
            this.updateLabel.Location = new System.Drawing.Point(356, 68);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(256, 38);
            this.updateLabel.TabIndex = 55;
            this.updateLabel.Text = "Update Profile";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.backBtn.Location = new System.Drawing.Point(801, 22);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(76, 41);
            this.backBtn.TabIndex = 56;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(904, 680);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.signUpPage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "UpdateProfile";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox confirmPasswordInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label signUpPage;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Button backBtn;
    }
}