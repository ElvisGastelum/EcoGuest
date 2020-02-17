using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class Client
    {
        public string VIP { get; set; }
        public string Nombre { get; set; }
        public string ID { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public long Celular { get; set; }
        public string FormaDePago { get; set; }
        public long NumeroDeTarjeta { get; set; }
        public string VencimientoDeTarjeta { get; set; }
        public string CVC { get; set; }
        public int Deuda { get; set; }

        public Client(string vip,
            string nombre,
            string id,
            string fechaDeNacimiento,
            string sexo,
            string nacionalidad,
            int celular,
            string formaDePago,
            int numeroDeTarjeta,
            string vencimientoDeTarjeta,
            string cvc)
        {
            VIP = vip;
            Nombre = nombre;
            ID = id;
            FechaDeNacimiento = fechaDeNacimiento;
            Sexo = sexo;
            Nacionalidad = nacionalidad;
            Celular = celular;
            FormaDePago = formaDePago;
            NumeroDeTarjeta = numeroDeTarjeta;
            VencimientoDeTarjeta = vencimientoDeTarjeta;
            CVC = cvc;
            Deuda = 0;
        }

        public Client()
        {
        }
    }
}
