﻿
namespace webTRON_Management_Software.Views.Admin
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.DragableChangePassword = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.activeUserPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.activeForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.currentPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.verificationCodePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.verificationCodeTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.lblEnterVerificationCode = new System.Windows.Forms.Label();
            this.verificationCodeTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanel.SuspendLayout();
            this.activeUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.verificationCodePanel.SuspendLayout();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DragableChangePassword
            // 
            this.DragableChangePassword.TargetControl = this;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSignOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnUsers);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.alertTransition.SetDecoration(this.sidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(-1, -2);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(68, 532);
            this.sidebarPanel.TabIndex = 32;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Animated = true;
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.alertTransition.SetDecoration(this.btnSignOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.HoverState.Parent = this.btnSignOut;
            this.btnSignOut.Image = global::webTRON_Management_Software.Properties.Resources.exit_icon;
            this.btnSignOut.ImageOffset = new System.Drawing.Point(10, -10);
            this.btnSignOut.Location = new System.Drawing.Point(0, 468);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(68, 48);
            this.btnSignOut.TabIndex = 24;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSignOut.Click += new System.EventHandler(this.SignOut);
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.alertTransition.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(228)))));
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
            this.alertTransition.SetDecoration(this.btnUsers, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
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
            this.alertTransition.SetDecoration(this.btnDashboard, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // activeUserPanel
            // 
            this.activeUserPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activeUserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activeUserPanel.Controls.Add(this.activeForm);
            this.activeUserPanel.Controls.Add(this.activeUserPicture);
            this.activeUserPanel.Controls.Add(this.activeUserName);
            this.alertTransition.SetDecoration(this.activeUserPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPanel.Location = new System.Drawing.Point(60, -3);
            this.activeUserPanel.Name = "activeUserPanel";
            this.activeUserPanel.ShadowDecoration.Parent = this.activeUserPanel;
            this.activeUserPanel.Size = new System.Drawing.Size(165, 80);
            this.activeUserPanel.TabIndex = 31;
            // 
            // activeForm
            // 
            this.activeForm.AutoSize = true;
            this.activeForm.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeForm.ForeColor = System.Drawing.Color.White;
            this.activeForm.Location = new System.Drawing.Point(62, 44);
            this.activeForm.Name = "activeForm";
            this.activeForm.Size = new System.Drawing.Size(68, 20);
            this.activeForm.TabIndex = 21;
            this.activeForm.Text = "Settings";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.man_picture;
            this.activeUserPicture.Location = new System.Drawing.Point(9, 17);
            this.activeUserPicture.Name = "activeUserPicture";
            this.activeUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPicture.ShadowDecoration.Parent = this.activeUserPicture;
            this.activeUserPicture.Size = new System.Drawing.Size(49, 45);
            this.activeUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPicture.TabIndex = 0;
            this.activeUserPicture.TabStop = false;
            // 
            // activeUserName
            // 
            this.activeUserName.AutoSize = true;
            this.activeUserName.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserName.ForeColor = System.Drawing.Color.White;
            this.activeUserName.Location = new System.Drawing.Point(60, 13);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(52, 24);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(911, 21);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 34;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(960, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 33;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.SignOut);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblConfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(371, 288);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(167, 24);
            this.lblConfirmPassword.TabIndex = 39;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Animated = true;
            this.confirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.confirmPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.confirmPasswordTextBox.DefaultText = "";
            this.confirmPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.DisabledState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.FocusedState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.confirmPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.HoverState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(376, 326);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '\0';
            this.confirmPasswordTextBox.PlaceholderText = "Confirm Password";
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.ShadowDecoration.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.confirmPasswordTextBox.TabIndex = 2;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Animated = true;
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.newPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.newPasswordTextBox.DefaultText = "";
            this.newPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.DisabledState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.FocusedState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.newPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.HoverState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Location = new System.Drawing.Point(375, 243);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '\0';
            this.newPasswordTextBox.PlaceholderText = "New Password";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.ShadowDecoration.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.newPasswordTextBox.TabIndex = 1;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblNewPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNewPassword.Location = new System.Drawing.Point(372, 202);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(141, 24);
            this.lblNewPassword.TabIndex = 36;
            this.lblNewPassword.Text = "New Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.CheckedState.Parent = this.btnChangePassword;
            this.btnChangePassword.CustomImages.Parent = this.btnChangePassword;
            this.alertTransition.SetDecoration(this.btnChangePassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.Parent = this.btnChangePassword;
            this.btnChangePassword.Location = new System.Drawing.Point(376, 401);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShadowDecoration.Parent = this.btnChangePassword;
            this.btnChangePassword.Size = new System.Drawing.Size(258, 53);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Animated = true;
            this.currentPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.currentPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.currentPasswordTextBox.DefaultText = "";
            this.currentPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPasswordTextBox.DisabledState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPasswordTextBox.FocusedState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.currentPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPasswordTextBox.HoverState.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Location = new System.Drawing.Point(374, 152);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '\0';
            this.currentPasswordTextBox.PlaceholderText = "Current Password";
            this.currentPasswordTextBox.SelectedText = "";
            this.currentPasswordTextBox.ShadowDecoration.Parent = this.currentPasswordTextBox;
            this.currentPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.currentPasswordTextBox.TabIndex = 0;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblCurrentPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(371, 111);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(164, 24);
            this.lblCurrentPassword.TabIndex = 41;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // verificationCodePanel
            // 
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox2);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox3);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox4);
            this.verificationCodePanel.Controls.Add(this.btnVerify);
            this.verificationCodePanel.Controls.Add(this.lblEnterVerificationCode);
            this.verificationCodePanel.Controls.Add(this.verificationCodeTextBox1);
            this.alertTransition.SetDecoration(this.verificationCodePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodePanel.Location = new System.Drawing.Point(231, 41);
            this.verificationCodePanel.Name = "verificationCodePanel";
            this.verificationCodePanel.ShadowDecoration.Parent = this.verificationCodePanel;
            this.verificationCodePanel.Size = new System.Drawing.Size(561, 480);
            this.verificationCodePanel.TabIndex = 42;
            this.verificationCodePanel.Visible = false;
            this.verificationCodePanel.Enter += new System.EventHandler(this.VerificationCodePanel_Enter);
            // 
            // verificationCodeTextBox2
            // 
            this.verificationCodeTextBox2.Animated = true;
            this.verificationCodeTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.verificationCodeTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox2.DefaultText = "";
            this.verificationCodeTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox2.DisabledState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox2.FocusedState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox2.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox2.HoverState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Location = new System.Drawing.Point(220, 189);
            this.verificationCodeTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox2.Name = "verificationCodeTextBox2";
            this.verificationCodeTextBox2.PasswordChar = '\0';
            this.verificationCodeTextBox2.PlaceholderText = "";
            this.verificationCodeTextBox2.SelectedText = "";
            this.verificationCodeTextBox2.ShadowDecoration.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox2.TabIndex = 1;
            this.verificationCodeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox2.TextChanged += new System.EventHandler(this.VerificationCodeTextBox2_TextChanged);
            // 
            // verificationCodeTextBox3
            // 
            this.verificationCodeTextBox3.Animated = true;
            this.verificationCodeTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.verificationCodeTextBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox3.DefaultText = "";
            this.verificationCodeTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox3.DisabledState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox3.FocusedState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox3.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox3.HoverState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Location = new System.Drawing.Point(278, 189);
            this.verificationCodeTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox3.Name = "verificationCodeTextBox3";
            this.verificationCodeTextBox3.PasswordChar = '\0';
            this.verificationCodeTextBox3.PlaceholderText = "";
            this.verificationCodeTextBox3.SelectedText = "";
            this.verificationCodeTextBox3.ShadowDecoration.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox3.TabIndex = 2;
            this.verificationCodeTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox3.TextChanged += new System.EventHandler(this.VerificationCodeTextBox3_TextChanged);
            // 
            // verificationCodeTextBox4
            // 
            this.verificationCodeTextBox4.Animated = true;
            this.verificationCodeTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.verificationCodeTextBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox4.DefaultText = "";
            this.verificationCodeTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox4.DisabledState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox4.FocusedState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox4.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox4.HoverState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Location = new System.Drawing.Point(329, 189);
            this.verificationCodeTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox4.Name = "verificationCodeTextBox4";
            this.verificationCodeTextBox4.PasswordChar = '\0';
            this.verificationCodeTextBox4.PlaceholderText = "";
            this.verificationCodeTextBox4.SelectedText = "";
            this.verificationCodeTextBox4.ShadowDecoration.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox4.TabIndex = 3;
            this.verificationCodeTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox4.TextChanged += new System.EventHandler(this.VerificationCodeTextBox4_TextChanged);
            // 
            // btnVerify
            // 
            this.btnVerify.Animated = true;
            this.btnVerify.CheckedState.Parent = this.btnVerify;
            this.btnVerify.CustomImages.Parent = this.btnVerify;
            this.alertTransition.SetDecoration(this.btnVerify, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(165, 288);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.ShadowDecoration.Parent = this.btnVerify;
            this.btnVerify.Size = new System.Drawing.Size(203, 53);
            this.btnVerify.TabIndex = 14;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // lblEnterVerificationCode
            // 
            this.lblEnterVerificationCode.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblEnterVerificationCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEnterVerificationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEnterVerificationCode.Location = new System.Drawing.Point(160, 145);
            this.lblEnterVerificationCode.Name = "lblEnterVerificationCode";
            this.lblEnterVerificationCode.Size = new System.Drawing.Size(208, 24);
            this.lblEnterVerificationCode.TabIndex = 13;
            this.lblEnterVerificationCode.Text = "Enter Verification Code:";
            // 
            // verificationCodeTextBox1
            // 
            this.verificationCodeTextBox1.Animated = true;
            this.verificationCodeTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alertTransition.SetDecoration(this.verificationCodeTextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox1.DefaultText = "";
            this.verificationCodeTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox1.DisabledState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox1.FocusedState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox1.ForeColor = System.Drawing.Color.Black;
            this.verificationCodeTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox1.HoverState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Location = new System.Drawing.Point(165, 189);
            this.verificationCodeTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox1.Name = "verificationCodeTextBox1";
            this.verificationCodeTextBox1.PasswordChar = '\0';
            this.verificationCodeTextBox1.PlaceholderText = "";
            this.verificationCodeTextBox1.SelectedText = "";
            this.verificationCodeTextBox1.ShadowDecoration.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox1.TabIndex = 0;
            this.verificationCodeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verificationCodeTextBox1.TextChanged += new System.EventHandler(this.VerificationCodeTextBox1_TextChanged);
            // 
            // alertTransition
            // 
            this.alertTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.alertTransition.Cursor = null;
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
            this.alertTransition.DefaultAnimation = animation1;
            this.alertTransition.MaxAnimationTime = 5000;
            // 
            // alertPanel
            // 
            this.alertPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.alert_danger_background;
            this.alertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPanel.Controls.Add(this.alertText);
            this.alertPanel.Controls.Add(this.alertCloseBtn);
            this.alertPanel.Controls.Add(this.alertImage);
            this.alertTransition.SetDecoration(this.alertPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertPanel.Location = new System.Drawing.Point(691, 558);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(306, 55);
            this.alertPanel.TabIndex = 43;
            this.alertPanel.Visible = false;
            // 
            // alertText
            // 
            this.alertText.AutoSize = true;
            this.alertTransition.SetDecoration(this.alertText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.alertText.ForeColor = System.Drawing.Color.Red;
            this.alertText.Location = new System.Drawing.Point(56, 17);
            this.alertText.Name = "alertText";
            this.alertText.Size = new System.Drawing.Size(90, 20);
            this.alertText.TabIndex = 2;
            this.alertText.Text = "{{alertText}}";
            // 
            // alertCloseBtn
            // 
            this.alertCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.alertCloseBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertCloseBtn.Image = global::webTRON_Management_Software.Properties.Resources.alert_close_icon;
            this.alertCloseBtn.Location = new System.Drawing.Point(269, 17);
            this.alertCloseBtn.Name = "alertCloseBtn";
            this.alertCloseBtn.ShadowDecoration.Parent = this.alertCloseBtn;
            this.alertCloseBtn.Size = new System.Drawing.Size(20, 20);
            this.alertCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertCloseBtn.TabIndex = 1;
            this.alertCloseBtn.TabStop = false;
            this.alertCloseBtn.Click += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // alertImage
            // 
            this.alertTransition.SetDecoration(this.alertImage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertImage.Image = global::webTRON_Management_Software.Properties.Resources.alert_danger_icon;
            this.alertImage.Location = new System.Drawing.Point(22, 17);
            this.alertImage.Name = "alertImage";
            this.alertImage.ShadowDecoration.Parent = this.alertImage;
            this.alertImage.Size = new System.Drawing.Size(20, 20);
            this.alertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertImage.TabIndex = 0;
            this.alertImage.TabStop = false;
            // 
            // alertTimer
            // 
            this.alertTimer.Enabled = true;
            this.alertTimer.Interval = 5000;
            this.alertTimer.Tick += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.verificationCodePanel);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.activeUserPanel);
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.activeUserPanel.ResumeLayout(false);
            this.activeUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.verificationCodePanel.ResumeLayout(false);
            this.verificationCodePanel.PerformLayout();
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl DragableChangePassword;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel activeUserPanel;
        private System.Windows.Forms.Label activeForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordTextBox;
        private System.Windows.Forms.Label lblNewPassword;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2Panel verificationCodePanel;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox3;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox4;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private System.Windows.Forms.Label lblEnterVerificationCode;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox1;
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
        private System.Windows.Forms.Timer alertTimer;
    }
}