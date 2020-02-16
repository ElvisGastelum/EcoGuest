using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public abstract class Client
    {
        public bool VIP { get; set; }
        public string NumeroDeCliente { get; set; }
        public string Nombre { get; set; }
        public string ID { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public int Celular { get; set; }
        public string FormaDePago { get; set; }
        public int NumeroDeTarjeta { get; set; }
        public string VencimientoDeTarjeta { get; set; }
        public string CVC { get; set; }

        public Client(bool vip, string numeroDeCliente, string nombre, string id, string fechaDeNacimiento, string sexo, string nacionalidad, int celular, string formaDePago, int numeroDeTarjeta, string vencimientoDeTarjeta, string cvc)
        {
            VIP = vip;
            NumeroDeCliente = numeroDeCliente;
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
        }

        public Client()
        {
        }
    }
}
