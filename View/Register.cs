using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class Register : Form
    {
        private RegisterController registerController = new RegisterController();
        private PrincipalMenu principalMenu;
        public Register(PrincipalMenu principalMenu)
        {
            InitializeComponent();
            this.principalMenu = principalMenu;
        }

        private void ExitForm(object sender, FormClosedEventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
        {
            Hide();
            principalMenu.Show();
        }

        private void CancelForm(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void RegisterNewClient(object sender, EventArgs e)
        {
            if (FormUtils.IsRequiredFieldsValidInGroupBox(this))
            {
                RegisterNewClient();
            }
            else
            {
                Console.WriteLine(":(");
            }
            
        }

        public void RegisterNewClient()
        {
            if (registerController.NewClient())
            {
                MessageBox.Show(
                    "Registro Exitoso",
                    "Estado del registro"
                );
                ExitForm();
                return;
            }

            MessageBox.Show(
                "Registro incorrecto",
                "Estado del registro"
            );
        }
    }
}
