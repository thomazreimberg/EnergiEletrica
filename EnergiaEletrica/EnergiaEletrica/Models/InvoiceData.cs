
namespace EnergiaEletrica
{
    public class InvoiceData
    {
        public string Cliente { get; set; } // mudei int para string
        public string Cep { get; set; } // mudei int para string
        public string Numero { get; set; }
        public string Complemento{ get; set; }
        public string  Regiao{ get; set; }
        public string Dia { get; set; } // mudei int para string
        public string Mes { get; set; }
        public int Ano { get; set; }
        public string Hora { get; set; } // mudei int para string
        public string Minuto { get; set; } // mudei int para string
        public string Segundo { get; set; } // mudei int para string
        public string Medidor { get; set; }
        public string Aparelho { get; set; } // mudei int para string
        public string KiloWatts { get; set; } // mudei int para string
        public string Custo { get; set; } // mudei decimal para string
    }
}
