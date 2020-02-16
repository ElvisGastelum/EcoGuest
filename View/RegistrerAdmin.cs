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
    public partial class RegisterAdmin : Form
    {
        RegisterAdminController registerAdmin = new RegisterAdminController();
        private PrincipalMenu principalMenu;
        public RegisterAdmin(PrincipalMenu principalMenu)
        {
            InitializeComponent();
            this.principalMenu = principalMenu;
        }

        private void Registrer(object sender, EventArgs e)
        {
            if (FormUtils.IsRequiredFieldsValid(this))
                MessageBox.Show(
                    "Favor de rellenar todos los campos.",
                    "Campos obligatorios"
                );
            else
                RegistrerNewAdmin();
        }

        private void RegistrerNewAdmin()
        {
            bool returnSaveAdminCode = registerAdmin.SaveAdmin(
                txt_usuario.Text,
                txt_contraseña.Text,
                txt_contraseñaRepetida.Text,
                txt_correoElectronico.Text
            );
            if (returnSaveAdminCode)
            {
                MessageBox.Show(
                    "Registro exitoso, cierre sesión para probarlo",
                    "Usuario Registrado"

                );
                ExitForm();
            }
            else
            {
                MessageBox.Show(
                    "Las contraseñas son diferentes",
                    "Ingreso de contraseña invalido"
                );
            }

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

        private void Return(object sender, EventArgs e)
        {
            ExitForm();
        }
    }
}
