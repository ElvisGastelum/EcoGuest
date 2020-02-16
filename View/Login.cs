using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class Login : Form
    {
        LoginController loginController = new LoginController();
        private PrincipalMenu principalMenu;
        public Login()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            FormUtils.CleanAllTextBox(this);
            Show();
        }

        private void EnterPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && 
                loginController.Login(
                    txt_usuario.Text,
                    txt_contraseña.Text
                ))
            {
                principalMenu = new PrincipalMenu(this, txt_usuario.Text);
                Hide();
                principalMenu.Show();

            }
        }
    }
}
