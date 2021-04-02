﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webTRON_Management_Software.Views.Admin
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        //Click event on exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }
        //Click event on minimize button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click event on new account button
        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            //Instantiating create account form
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Instantiating Settings form
            var setting = new Settings();
            setting.Show();
            this.Hide();
        }
    }
}