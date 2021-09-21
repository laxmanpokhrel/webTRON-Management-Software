﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Admin
{
    public partial class Dashboard : Form
    {
        //Instantiate Employee Class
        Employee employee;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }
        //Load event on admin dashboard
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //Initialize Total Online and Offline Status
            InitializeUserStatus();
            //Initialize activeUserDetails
            InitializeActiverUserDetails();
            
        }
        
        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //Click event on Users button
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            Users userForm = new Users(employee);
            userForm.Show();
            this.Hide();

        }

        //Click event on Settings button
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Settings settingForm = new Settings(employee);
            settingForm.Show();
            this.Hide();

        }
        //Initialize total online and offline user count status
        private void InitializeUserStatus()
        {
            (int countOfTotalOfflineUser, int countOfTotalOnlineUser) = Employee.GetTotalUserStatus();
            onlineUser.Text = countOfTotalOnlineUser.ToString();
            offlineUser.Text = countOfTotalOfflineUser.ToString();
        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            activeUserName.Text = employee.FirstName;
            if (employee.img != null)
            {
                //Change active user picture
                MemoryStream ms = new MemoryStream(employee.img);
                activeUserPicture.Image = Image.FromStream(ms);
            }
        }
        //Click event on signout and exit button
        private void SignOut(object sender, EventArgs e)
        {
             //WARNING:To check which element has clicked          
            string elementType = sender.GetType().ToString();
            var value = MessageBox.Show("Are you sure?", "Sign out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (value.ToString() == "Yes")
            {
                Employee.SetStatus(employee.UserID, "Offline");
                //It ensures sign out has clicked
                if (elementType == "Guna.UI2.WinForms.Guna2Button")
                {
                    LandingWindow landingWindow = new LandingWindow();
                    landingWindow.Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }


            }
        }

        private void activeUserPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
