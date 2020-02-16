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
            Console.WriteLine(FormUtils.DateToString(dtp_nacimDate.Value));
        }
    }
}
