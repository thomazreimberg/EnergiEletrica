using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaEletrica
{
    class InvoiceData
    {
        //Molde
        public int Cliente { get; set; }
        public int Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento{ get; set; }
        public string  Regiao{ get; set; }
        public int Dia { get; set; }
        public string Mes { get; set; }
        public int Ano { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }
        public string Medidor { get; set; }
        public int Apararelho { get; set; }
        public int KiloWatts { get; set; }
        public decimal Custo { get; set; }
    }
}
