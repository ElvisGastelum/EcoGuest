﻿using System;
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


            registerController.NewClient(client);
            MessageBox.Show(
                "Registro Exitoso", 
                "Estado del registro"
                );
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
            cmb_sexo.SelectedIndex = 0;
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
                txt_noTarjeta.Text = "";
                txt_cardFecha.ReadOnly = false;
                txt_cardFecha.Text = "";
                txt_cvc.ReadOnly = false;
                txt_cvc.Text = "";
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
