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
using Model;

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
                return;
            }

            MessageBox.Show(
                "Favor de llenar todos los campos",
                "Campos requeridos"
            );

        }

        public void RegisterNewClient()
        {
            Client client = new Client();

            client.VIP = IsVIP();


            registerController.NewClient(client);
            MessageBox.Show(
                "Registro Exitoso", 
                "Estado del registro"
                );
            ExitForm();
            
        }

        private bool IsVIP()
        {
            if (rbtn_vip.Checked)
            {
                return true;
            }

            return false;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cmb_sexo.SelectedIndex = 1;
        }
    }
}
