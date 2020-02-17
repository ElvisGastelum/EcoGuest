using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace Controller
{
    public class ReservationController
    {
        private SearchController searchController;
        public ReservationController()
        {
            searchController = new SearchController();
        }

        public BindingList<Client> GetListOfClients()
        {
            return searchController.GetList();
        }

        public void SetPrice(string room, TextBox priceField)
        {
            switch (room)
            {
                case "Suite":
                    priceField.Text = "2500";
                    break;
                case "Doble":
                    priceField.Text = "1800";
                    break;
                case "Sencilla":
                    priceField.Text = "1000";
                    break;
            }
        }

        public void SaveReservation(ReservationModel reservation)
        {
            List<ReservationModel> list = GetReservations();
            List<Client> listClient = GetClients();

            
            listClient.ForEach(c =>
            {
                if (c.Nombre.Equals(reservation.cliente.Nombre))
                {
                    c.Deuda += Convert.ToInt32(reservation.Total);
                }
            });

            list.Add(reservation);
            Writer.Save(list, Directory.Reservations);
            Writer.Save(listClient, Directory.Clients);

        }

        private List<Client> GetClients()
        {
            return Reader.Load<List<Client>>(Directory.Clients);
        }

        private List<ReservationModel> GetReservations()
        {
            return Reader.Load<List<ReservationModel>>(Directory.Reservations);
        }
    }
}