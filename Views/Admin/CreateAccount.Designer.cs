﻿
namespace webTRON_Management_Software.Views.Admin
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.lblName = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSex = new System.Windows.Forms.Label();
            this.isMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.isFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.isOthers = new Guna.UI2.WinForms.Guna2RadioButton();
            this.contactNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.roleComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSIgnOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.Dragable = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.activeForm = new System.Windows.Forms.Label();
            this.activeUserPictureSidebar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.Location = new System.Drawing.Point(275, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 24);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name*:";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Animated = true;
            this.firstNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTxtBox.DefaultText = "";
            this.firstNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxtBox.DisabledState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTxtBox.FocusedState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTxtBox.HoverState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Location = new System.Drawing.Point(445, 155);
            this.firstNameTxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.PasswordChar = '\0';
            this.firstNameTxtBox.PlaceholderText = "First Name";
            this.firstNameTxtBox.SelectedText = "";
            this.firstNameTxtBox.ShadowDecoration.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Size = new System.Drawing.Size(226, 32);
            this.firstNameTxtBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Animated = true;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.DefaultText = "";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.FocusedState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.HoverState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Location = new System.Drawing.Point(694, 155);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PlaceholderText = "Last Name";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.ShadowDecoration.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Size = new System.Drawing.Size(219, 32);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmailAddress.Location = new System.Drawing.Point(275, 208);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(144, 24);
            this.lblEmailAddress.TabIndex = 21;
            this.lblEmailAddress.Text = "Email Address*:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.Parent = this.emailTextBox;
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.FocusedState.Parent = this.emailTextBox;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(445, 205);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Email Address";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(407, 32);
            this.emailTextBox.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(275, 309);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(122, 24);
            this.lblDateOfBirth.TabIndex = 23;
            this.lblDateOfBirth.Text = "Date of Birth*:";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthPicker.CheckedState.Parent = this.dateOfBirthPicker;
            this.dateOfBirthPicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateOfBirthPicker.ForeColor = System.Drawing.Color.White;
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthPicker.HoverState.Parent = this.dateOfBirthPicker;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(445, 305);
            this.dateOfBirthPicker.MaxDate = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            this.dateOfBirthPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.ShadowDecoration.Parent = this.dateOfBirthPicker;
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 36);
            this.dateOfBirthPicker.TabIndex = 5;
            this.dateOfBirthPicker.Value = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSex.Location = new System.Drawing.Point(275, 358);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(55, 24);
            this.lblSex.TabIndex = 25;
            this.lblSex.Text = "Sex*:";
            // 
            // isMale
            // 
            this.isMale.Animated = true;
            this.isMale.AutoSize = true;
            this.isMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isMale.CheckedState.BorderThickness = 0;
            this.isMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isMale.CheckedState.InnerOffset = -4;
            this.isMale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isMale.Location = new System.Drawing.Point(445, 359);
            this.isMale.Name = "isMale";
            this.isMale.Size = new System.Drawing.Size(62, 25);
            this.isMale.TabIndex = 6;
            this.isMale.TabStop = true;
            this.isMale.Text = "Male";
            this.isMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isMale.UncheckedState.BorderThickness = 2;
            this.isMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isMale.UseVisualStyleBackColor = true;
            // 
            // isFemale
            // 
            this.isFemale.Animated = true;
            this.isFemale.AutoSize = true;
            this.isFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isFemale.CheckedState.BorderThickness = 0;
            this.isFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isFemale.CheckedState.InnerOffset = -4;
            this.isFemale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isFemale.Location = new System.Drawing.Point(513, 359);
            this.isFemale.Name = "isFemale";
            this.isFemale.Size = new System.Drawing.Size(78, 25);
            this.isFemale.TabIndex = 7;
            this.isFemale.TabStop = true;
            this.isFemale.Text = "Female";
            this.isFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isFemale.UncheckedState.BorderThickness = 2;
            this.isFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isFemale.UseVisualStyleBackColor = true;
            // 
            // isOthers
            // 
            this.isOthers.Animated = true;
            this.isOthers.AutoSize = true;
            this.isOthers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isOthers.CheckedState.BorderThickness = 0;
            this.isOthers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isOthers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isOthers.CheckedState.InnerOffset = -4;
            this.isOthers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isOthers.Location = new System.Drawing.Point(609, 357);
            this.isOthers.Name = "isOthers";
            this.isOthers.Size = new System.Drawing.Size(75, 25);
            this.isOthers.TabIndex = 8;
            this.isOthers.TabStop = true;
            this.isOthers.Text = "Others";
            this.isOthers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isOthers.UncheckedState.BorderThickness = 2;
            this.isOthers.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isOthers.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isOthers.UseVisualStyleBackColor = true;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Animated = true;
            this.contactNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactNumberTextBox.DefaultText = "";
            this.contactNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNumberTextBox.DisabledState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactNumberTextBox.FocusedState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contactNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.contactNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactNumberTextBox.HoverState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Location = new System.Drawing.Point(445, 398);
            this.contactNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.PasswordChar = '\0';
            this.contactNumberTextBox.PlaceholderText = "Contact Number";
            this.contactNumberTextBox.SelectedText = "";
            this.contactNumberTextBox.ShadowDecoration.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Size = new System.Drawing.Size(239, 32);
            this.contactNumberTextBox.TabIndex = 9;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblContactNumber.Location = new System.Drawing.Point(275, 401);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(159, 24);
            this.lblContactNumber.TabIndex = 29;
            this.lblContactNumber.Text = "Contact Number*:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Animated = true;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.DefaultText = "";
            this.addressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.DisabledState.Parent = this.addressTextBox;
            this.addressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.FocusedState.Parent = this.addressTextBox;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.HoverState.Parent = this.addressTextBox;
            this.addressTextBox.Location = new System.Drawing.Point(445, 257);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PlaceholderText = "Address";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.ShadowDecoration.Parent = this.addressTextBox;
            this.addressTextBox.Size = new System.Drawing.Size(239, 32);
            this.addressTextBox.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.Location = new System.Drawing.Point(275, 257);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(92, 24);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "Address*:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRole.Location = new System.Drawing.Point(275, 110);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(61, 24);
            this.lblRole.TabIndex = 33;
            this.lblRole.Text = "Role*:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.roleComboBox.FocusedState.Parent = this.roleComboBox;
            this.roleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.HoverState.Parent = this.roleComboBox;
            this.roleComboBox.ItemHeight = 30;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Accountant",
            "Others"});
            this.roleComboBox.ItemsAppearance.Parent = this.roleComboBox;
            this.roleComboBox.Location = new System.Drawing.Point(447, 103);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.ShadowDecoration.Parent = this.roleComboBox;
            this.roleComboBox.Size = new System.Drawing.Size(140, 36);
            this.roleComboBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Enter employee information to create new account ";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSIgnOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnUsers);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(-1, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(68, 532);
            this.sidebarPanel.TabIndex = 36;
            // 
            // btnSIgnOut
            // 
            this.btnSIgnOut.Animated = true;
            this.btnSIgnOut.CheckedState.Parent = this.btnSIgnOut;
            this.btnSIgnOut.CustomImages.Parent = this.btnSIgnOut;
            this.btnSIgnOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSIgnOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIgnOut.ForeColor = System.Drawing.Color.White;
            this.btnSIgnOut.HoverState.Parent = this.btnSIgnOut;
            this.btnSIgnOut.Image = global::webTRON_Management_Software.Properties.Resources.exit_icon;
            this.btnSIgnOut.ImageOffset = new System.Drawing.Point(10, -10);
            this.btnSIgnOut.Location = new System.Drawing.Point(0, 468);
            this.btnSIgnOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSIgnOut.Name = "btnSIgnOut";
            this.btnSIgnOut.ShadowDecoration.Parent = this.btnSIgnOut;
            this.btnSIgnOut.Size = new System.Drawing.Size(68, 48);
            this.btnSIgnOut.TabIndex = 24;
            this.btnSIgnOut.Text = "Sign Out";
            this.btnSIgnOut.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSIgnOut.Click += new System.EventHandler(this.SignOut);
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::webTRON_Management_Software.Properties.Resources.settings_icon;
            this.btnSettings.ImageOffset = new System.Drawing.Point(10, -12);
            this.btnSettings.Location = new System.Drawing.Point(0, 272);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(68, 48);
            this.btnSettings.TabIndex = 23;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(228)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::webTRON_Management_Software.Properties.Resources.user_icon;
            this.btnUsers.ImageOffset = new System.Drawing.Point(6, -12);
            this.btnUsers.Location = new System.Drawing.Point(0, 195);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(68, 48);
            this.btnUsers.TabIndex = 22;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::webTRON_Management_Software.Properties.Resources.dashboard_icon;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(15, -12);
            this.btnDashboard.Location = new System.Drawing.Point(0, 115);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(68, 48);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(-6, 10);
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // Dragable
            // 
            this.Dragable.TargetControl = null;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(911, 20);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 38;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(960, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 37;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::webTRON_Management_Software.Properties.Resources.webTRONLogoWithSlogan;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-1, 544);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(173, 69);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_medium;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Controls.Add(this.activeForm);
            this.guna2Panel2.Controls.Add(this.activeUserPictureSidebar);
            this.guna2Panel2.Controls.Add(this.activeUserName);
            this.guna2Panel2.Location = new System.Drawing.Point(60, -1);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(172, 80);
            this.guna2Panel2.TabIndex = 16;
            // 
            // activeForm
            // 
            this.activeForm.AutoSize = true;
            this.activeForm.BackColor = System.Drawing.Color.Transparent;
            this.activeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.activeForm.ForeColor = System.Drawing.Color.White;
            this.activeForm.Location = new System.Drawing.Point(51, 38);
            this.activeForm.Name = "activeForm";
            this.activeForm.Size = new System.Drawing.Size(120, 20);
            this.activeForm.TabIndex = 2;
            this.activeForm.Text = "Create Account";
            // 
            // activeUserPictureSidebar
            // 
            this.activeUserPictureSidebar.BackColor = System.Drawing.Color.Transparent;
            this.activeUserPictureSidebar.Image = global::webTRON_Management_Software.Properties.Resources.man_picture;
            this.activeUserPictureSidebar.Location = new System.Drawing.Point(4, 17);
            this.activeUserPictureSidebar.Name = "activeUserPictureSidebar";
            this.activeUserPictureSidebar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPictureSidebar.ShadowDecoration.Parent = this.activeUserPictureSidebar;
            this.activeUserPictureSidebar.Size = new System.Drawing.Size(49, 45);
            this.activeUserPictureSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPictureSidebar.TabIndex = 1;
            this.activeUserPictureSidebar.TabStop = false;
            // 
            // activeUserName
            // 
            this.activeUserName.AutoSize = true;
            this.activeUserName.BackColor = System.Drawing.Color.Transparent;
            this.activeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserName.ForeColor = System.Drawing.Color.White;
            this.activeUserName.Location = new System.Drawing.Point(53, 11);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(59, 25);
            this.activeUserName.TabIndex = 0;
            this.activeUserName.Text = "John";
            // 
            // btnSubmit
            // 
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(733, 505);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(180, 45);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.isOthers);
            this.Controls.Add(this.isFemale);
            this.Controls.Add(this.isMale);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private System.Windows.Forms.Label lblEmailAddress;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label lblDateOfBirth;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label lblSex;
        private Guna.UI2.WinForms.Guna2RadioButton isMale;
        private Guna.UI2.WinForms.Guna2RadioButton isFemale;
        private Guna.UI2.WinForms.Guna2RadioButton isOthers;
        private Guna.UI2.WinForms.Guna2TextBox contactNumberTextBox;
        private System.Windows.Forms.Label lblContactNumber;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2ComboBox roleComboBox;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnSIgnOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label activeForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPictureSidebar;
        private Guna.UI2.WinForms.Guna2DragControl Dragable;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
    }
}