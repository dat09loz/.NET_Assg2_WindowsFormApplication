namespace Assg2_WindowsFormApplication
{
    partial class NewUserWindow
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
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.DOB = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.Label();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(52, 87);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(75, 19);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(52, 120);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(74, 19);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(52, 217);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(71, 19);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(52, 254);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 19);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPassword.Location = new System.Drawing.Point(52, 288);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(120, 19);
            this.ConfirmPassword.TabIndex = 4;
            this.ConfirmPassword.Text = "Confirm Password";
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FNameTextBox.Location = new System.Drawing.Point(183, 81);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.PlaceholderText = "Firstname";
            this.FNameTextBox.Size = new System.Drawing.Size(203, 25);
            this.FNameTextBox.TabIndex = 5;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LNameTextBox.Location = new System.Drawing.Point(183, 116);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.PlaceholderText = "Lastname";
            this.LNameTextBox.Size = new System.Drawing.Size(203, 25);
            this.LNameTextBox.TabIndex = 6;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTextBox.Location = new System.Drawing.Point(183, 216);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PlaceholderText = "Username";
            this.UsernameTextBox.Size = new System.Drawing.Size(203, 25);
            this.UsernameTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.Location = new System.Drawing.Point(183, 250);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Enter Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(203, 25);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(183, 284);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PlaceholderText = "Re-enter Password";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(203, 25);
            this.ConfirmPasswordTextBox.TabIndex = 9;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(116, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(201, 30);
            this.Title.TabIndex = 10;
            this.Title.Text = "Create a new User";
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateUserBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateUserBtn.Location = new System.Drawing.Point(86, 339);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(118, 48);
            this.CreateUserBtn.TabIndex = 11;
            this.CreateUserBtn.Text = "Create User";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.CancelBtn.Location = new System.Drawing.Point(234, 339);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(118, 48);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DOBPicker
            // 
            this.DOBPicker.CustomFormat = "dd-MM-yyyy";
            this.DOBPicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBPicker.Location = new System.Drawing.Point(183, 147);
            this.DOBPicker.MaxDate = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            this.DOBPicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(203, 25);
            this.DOBPicker.TabIndex = 13;
            this.DOBPicker.Value = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOB.Location = new System.Drawing.Point(52, 151);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(87, 19);
            this.DOB.TabIndex = 14;
            this.DOB.Text = "Date of birth";
            // 
            // UserType
            // 
            this.UserType.AutoSize = true;
            this.UserType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserType.Location = new System.Drawing.Point(53, 183);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(69, 19);
            this.UserType.TabIndex = 15;
            this.UserType.Text = "User Type";
            // 
            // UserTypeComboBox
            // 
            this.UserTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserTypeComboBox.FormattingEnabled = true;
            this.UserTypeComboBox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.UserTypeComboBox.Location = new System.Drawing.Point(183, 182);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(203, 25);
            this.UserTypeComboBox.TabIndex = 16;
            this.UserTypeComboBox.Text = "Select Type";
            // 
            // NewUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 414);
            this.Controls.Add(this.UserTypeComboBox);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateUserBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LNameTextBox);
            this.Controls.Add(this.FNameTextBox);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "NewUserWindow";
            this.Text = "Create User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewUserWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FirstName;
        private Label LastName;
        private Label Username;
        private Label Password;
        private Label ConfirmPassword;
        private TextBox FNameTextBox;
        private TextBox LNameTextBox;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmPasswordTextBox;
        private Label Title;
        private Button CreateUserBtn;
        private Button CancelBtn;
        private DateTimePicker DOBPicker;
        private Label DOB;
        private Label UserType;
        private ComboBox UserTypeComboBox;
    }
}