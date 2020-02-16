﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PrincipalMenu : Form
    {
        private Login login;
        private string adminUsername;
        public PrincipalMenu(Login login, string adminUsername)
        {
            InitializeComponent();
            this.login = login;
            this.adminUsername = adminUsername;
        }

        private void NewAdmin(object sender, EventArgs e)
        {
            RegisterAdmin registerAdmin = new RegisterAdmin(this);
            Hide();
            registerAdmin.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            Hide();
            login.ShowForm();
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void PrincipalMenu_Load(object sender, EventArgs e)
        {
            lbl_bienvenida.Text = "Bienvenid(o / a), " + adminUsername;
        }
    }
}