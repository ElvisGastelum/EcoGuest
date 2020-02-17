using System;

namespace Model
{
    [Serializable]
    public class ReservationModel
    {
        public string FechaDeIngreso { get; set; }
        public string FechaDeEgreso { get; set; }
        public string DiasReservados { get; set; }
        public string NumeroDeAdultos { get; set; }
        public string NumeroDeNiños { get; set; }
        public string TipoDeHabitacion { get; set; }
        public string NumeroDeHabitacion { get; set; }
        public string Precio { get; set; }
        public Client cliente { get; set; }
        public string Total { get; set; }

        public ReservationModel(string fechaDeIngreso,
            string fechaDeEgreso,
            string diasReservados,
            string numeroDeAdultos,
            string numeroDeNiños,
            string tipoDeHabitacion,
            string numeroDeHabitacion,
            string precio,
            Client cliente,
            string total)
        {
            FechaDeIngreso = fechaDeIngreso;
            FechaDeEgreso = fechaDeEgreso;
            DiasReservados = diasReservados;
            NumeroDeAdultos = numeroDeAdultos;
            NumeroDeNiños = numeroDeNiños;
            TipoDeHabitacion = tipoDeHabitacion;
            NumeroDeHabitacion = numeroDeHabitacion;
            Precio = precio;
            this.cliente = cliente;
            Total = total;
        }

        public ReservationModel()
        {
        }
    }
}