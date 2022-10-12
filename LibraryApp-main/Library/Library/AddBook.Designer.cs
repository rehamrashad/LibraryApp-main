
namespace Library
{
    partial class AddBookPage
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
            this.addBookLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.publichDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.availableLable = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.publishDate = new System.Windows.Forms.DateTimePicker();
            this.availableUpDown = new System.Windows.Forms.NumericUpDown();
            this.autherIdLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.availableUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBookLabel
            // 
            this.addBookLabel.AutoSize = true;
            this.addBookLabel.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookLabel.ForeColor = System.Drawing.Color.White;
            this.addBookLabel.Location = new System.Drawing.Point(313, 26);
            this.addBookLabel.Name = "addBookLabel";
            this.addBookLabel.Size = new System.Drawing.Size(175, 38);
            this.addBookLabel.TabIndex = 0;
            this.addBookLabel.Text = "Add Book";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(68, 148);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(72, 32);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // publichDateLabel
            // 
            this.publichDateLabel.AutoSize = true;
            this.publichDateLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.publichDateLabel.ForeColor = System.Drawing.Color.White;
            this.publichDateLabel.Location = new System.Drawing.Point(68, 342);
            this.publichDateLabel.Name = "publichDateLabel";
            this.publichDateLabel.Size = new System.Drawing.Size(176, 32);
            this.publichDateLabel.TabIndex = 2;
            this.publichDateLabel.Text = "Publish Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 4;
            // 
            // availableLable
            // 
            this.availableLable.AutoSize = true;
            this.availableLable.Font = new System.Drawing.Font("Georgia", 14F);
            this.availableLable.ForeColor = System.Drawing.Color.White;
            this.availableLable.Location = new System.Drawing.Point(63, 448);
            this.availableLable.Name = "availableLable";
            this.availableLable.Size = new System.Drawing.Size(130, 32);
            this.availableLable.TabIndex = 7;
            this.availableLable.Text = "Available";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(68, 400);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(78, 32);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // titleInput
            // 
            this.titleInput.AcceptsTab = true;
            this.titleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.titleInput.Location = new System.Drawing.Point(278, 148);
            this.titleInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(360, 32);
            this.titleInput.TabIndex = 10;
            this.titleInput.TextChanged += new System.EventHandler(this.titleInput_TextChanged);
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.priceInput.Location = new System.Drawing.Point(280, 400);
            this.priceInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(208, 32);
            this.priceInput.TabIndex = 12;
            // 
            // publishDate
            // 
            this.publishDate.Location = new System.Drawing.Point(278, 342);
            this.publishDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publishDate.Name = "publishDate";
            this.publishDate.Size = new System.Drawing.Size(301, 26);
            this.publishDate.TabIndex = 15;
            this.publishDate.Value = new System.DateTime(2022, 5, 27, 8, 33, 51, 0);
            // 
            // availableUpDown
            // 
            this.availableUpDown.Location = new System.Drawing.Point(280, 454);
            this.availableUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableUpDown.Name = "availableUpDown";
            this.availableUpDown.Size = new System.Drawing.Size(148, 26);
            this.availableUpDown.TabIndex = 16;
            // 
            // autherIdLabel
            // 
            this.autherIdLabel.AutoSize = true;
            this.autherIdLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.autherIdLabel.ForeColor = System.Drawing.Color.White;
            this.autherIdLabel.Location = new System.Drawing.Point(68, 282);
            this.autherIdLabel.Name = "autherIdLabel";
            this.autherIdLabel.Size = new System.Drawing.Size(117, 32);
            this.autherIdLabel.TabIndex = 9;
            this.autherIdLabel.Text = "Book ID";
            this.autherIdLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Georgia", 14F);
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(63, 218);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(76, 32);
            this.typeLabel.TabIndex = 20;
            this.typeLabel.Text = "Type";
            this.typeLabel.Click += new System.EventHandler(this.typeLabel_Click);
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Action",
            "Classic",
            "Mystery",
            "Fantasy",
            "Historical",
            "Romance",
            "Science Fiction",
            "Cook",
            "Essay",
            "Magazine",
            "Article",
            "Poetry",
            "Comedy"});
            this.typeBox.Location = new System.Drawing.Point(280, 218);
            this.typeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(299, 28);
            this.typeBox.TabIndex = 21;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.Font = new System.Drawing.Font("Georgia", 16F);
            this.addBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addBtn.Location = new System.Drawing.Point(334, 566);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(154, 50);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.backBtn.Location = new System.Drawing.Point(756, 26);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(70, 38);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(280, 282);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(148, 26);
            this.numericUpDown1.TabIndex = 24;
            // 
            // AddBookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(861, 680);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.availableUpDown);
            this.Controls.Add(this.publishDate);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.autherIdLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.availableLable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.publichDateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addBookLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddBookPage";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBookPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addBookLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label publichDateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label availableLable;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.DateTimePicker publishDate;
        private System.Windows.Forms.NumericUpDown availableUpDown;
        private System.Windows.Forms.Label autherIdLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}