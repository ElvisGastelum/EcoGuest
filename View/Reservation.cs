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
    public partial class Reservation : Form
    {
        private PrincipalMenu principalMenu;
        private ReservationController reservationController = new ReservationController();
        private int daysReserved;
        private Client selectedClient;
        public Reservation(PrincipalMenu principalMenu)
        {
            InitializeComponent();
            this.principalMenu = principalMenu;
            ConfigureClientField();
        }

        private void ConfigureClientField()
        {
            clientBindingSource.DataSource = typeof(Client);
            cmb_cliente.DataBindings.Add(new Binding("SelectedValue", clientBindingSource, "Nombre", true));
            var list = reservationController.GetListOfClients();
            clientBindingSource.Clear();
            clientBindingSource.Add(new Client());
            clientBindingSource.Add(list.ElementAt(0));
            foreach (var client in list)
            {
                if (client != list.First())
                {
                    clientBindingSource.Add(client);
                }

            }
            cmb_cliente.DataSource = clientBindingSource;
            cmb_cliente.DisplayMember = "Nombre";
            cmb_cliente.ValueMember = "Nombre";
            cmb_cliente.SelectedIndex = 0;
        }

        private void DayReserved(object sender, EventArgs e)
        {
            DifferenceDays();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            DifferenceDays();
            
            cmb_tipoRoom.SelectedIndex = 0;
            reservationController.SetPrice(cmb_tipoRoom.Text, txt_precio);
            CalculatePrice();
        }

        private void DifferenceDays()
        {
            DateTime fecharegistro = dtp_dateIn.Value;
            daysReserved = Convert.ToInt32((dtp_dateOut.Value - fecharegistro).TotalDays);
            txt_daysIn.Text = daysReserved.ToString();
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

        private void ExitForm(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void txt_daysIn_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            try
            {
                int numberOfAdults = Convert.ToInt32(txt_noAdult.Text);
                int price = Convert.ToInt32(txt_precio.Text);
                if (daysReserved < 1)
                {
                    daysReserved = 1;
                }
                double total;
                if (numberOfAdults > 4)
                {
                    total = ((numberOfAdults * 10) + price)*daysReserved;
                    txt_total.Text = total.ToString();
                }
                else
                {
                    total = price * daysReserved;
                    txt_total.Text = total.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void cmb_tipoRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            reservationController.SetPrice(cmb_tipoRoom.Text, txt_precio);
            CalculatePrice();
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var List = reservationController.GetListOfClients();

            foreach (var client in List)
            {
                if (client.Nombre.Equals(cmb_cliente.Text))
                {
                    selectedClient = client;
                }
            }

            try
            {
                Console.WriteLine(selectedClient.Nombre);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            reservationController.SaveReservation(
                new ReservationModel(
                    FormUtils.DateToString(dtp_dateIn.Value),
                    FormUtils.DateToString(dtp_dateIn.Value),
                    txt_daysIn.Text,
                    txt_noAdult.Text,
                    txt_noKids.Text,
                    cmb_tipoRoom.Text,
                    txt_noRoom.Text,
                    txt_precio.Text,
                    selectedClient,
                    txt_total.Text
                )
                );
        }
    }
}
