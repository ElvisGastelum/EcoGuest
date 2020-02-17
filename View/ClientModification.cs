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
    public partial class ClientModification : Form
    {
        private ClientModificationController clientModificationController = new ClientModificationController();
        private Search search;
        private BindingList<Client> list;
        private int index;
        private Client client;

        public ClientModification(Search search, Client client, BindingList<Client> list, int index)
        {
            InitializeComponent();
            this.search = search;
            this.list = list;
            this.index = index;
            this.client = client;
            RefillFields();
        }

        private void RefillFields()
        {
            txt_noTarjeta.Text = client.NumeroDeTarjeta.ToString();
            txt_celular.Text = client.Celular.ToString();
            txt_cvc.Text = client.CVC;
            txt_cardFecha.Text = client.VencimientoDeTarjeta;
            txt_nation.Text = client.Nacionalidad;
            txt_nombre.Text = client.Nombre;
            txt_identif.Text = client.ID;
            dtp_nacimDate.Value = FormUtils.StringToDateTime(client.FechaDeNacimiento);
            if (client.Sexo.Equals("Masculino"))
            {
                cmb_sexo.SelectedIndex = 1;
            }
            else
            {
                cmb_sexo.SelectedIndex = 0;
            }
            if (client.VIP == "Si")
            {
                rbtn_vip.Checked = true;
                rbtn_noVip.Checked = false;
            }
            else
            {
                rbtn_vip.Checked = false;
                rbtn_noVip.Checked = true;
            }
            if (client.FormaDePago == "Efectivo")
            {
                txt_noTarjeta.ReadOnly = true;
                txt_noTarjeta.Text = "0000000000000000";
                txt_cardFecha.ReadOnly = true;
                txt_cardFecha.Text = "no necesario";
                txt_cvc.ReadOnly = false;
                txt_cvc.Text = "no necesario";
                cmb_formaPay.SelectedIndex = 0;
            }
            else
            {
                cmb_formaPay.SelectedIndex = 1;
            }

            
        }

        private void ExitForm(object sender, FormClosedEventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
        {
            Hide();
            search.Show();
        }

        private void CancelForm(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void ModificationClient(object sender, EventArgs e)
        {
            if (FormUtils.IsRequiredFieldsValidInGroupBox(this))
            {
                ModificationClient();
                return;
            }

            MessageBox.Show(
                "Favor de llenar todos los campos",
                "Campos requeridos"
            );

        }

        public void ModificationClient()
        {
            Client client = new Client();

            client.VIP = IsVIP();
            client.Nombre = txt_nombre.Text;
            client.ID = txt_identif.Text;
            client.FechaDeNacimiento = FormUtils.DateToString(dtp_nacimDate.Value);
            client.Sexo = cmb_sexo.Text;
            client.Nacionalidad = txt_nation.Text;
            if (IsValidNumber(txt_celular))
            {
                client.Celular = ConvertNumber(txt_celular);
            }
            client.FormaDePago = FormaDePago();
            if (IsValidNumber(txt_noTarjeta))
            {
                client.NumeroDeTarjeta = ConvertNumber(txt_noTarjeta);
            }
            client.VencimientoDeTarjeta = txt_cardFecha.Text;
            client.CVC = txt_cvc.Text;

            MessageBox.Show(
                "Modificación Exitosa", 
                "Estado del registro"
                );
            clientModificationController.ModificationClient(client, list, index);
            ExitForm();
            
        }

        private bool IsValidNumber(TextBox textBox)
        {
            try
            {
                long.Parse(textBox.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Numero de celular incorrecto",
                    "Ingreso Erróneo"
                );
                return false;
            }

            return true;
        }

        private long ConvertNumber(TextBox textBox)
        {
            try
            {
                long result = long.Parse(textBox.Text);
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Numero de celular incorrecto", 
                    "Ingreso Erróneo"
                    );
            }

            return 0;
        }

        private string IsVIP()
        {
            if (rbtn_vip.Checked)
            {
                return "Si";
            }

            return "No";
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void FormaDePago(object sender, EventArgs e)
        {
            if (cmb_formaPay.SelectedIndex == 0)
            {
                txt_noTarjeta.ReadOnly = true;
                txt_noTarjeta.Text = "0000000000000000";
                txt_cardFecha.ReadOnly = true;
                txt_cardFecha.Text = "no necesario";
                txt_cvc.ReadOnly = false;
                txt_cvc.Text = "no necesario";
            }
            if (cmb_formaPay.SelectedIndex == 1)
            {
                txt_noTarjeta.ReadOnly = false;
                txt_cardFecha.ReadOnly = false;
                txt_cvc.ReadOnly = false;
            }
        }

        private string FormaDePago()
        {
            if (cmb_formaPay.SelectedIndex == 0)
            {
                return "Efectivo";
            }
            return "Credito / Debito";
        }
    }
}
