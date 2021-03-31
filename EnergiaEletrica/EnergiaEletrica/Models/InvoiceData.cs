
namespace EnergiaEletrica
{
    public class InvoiceData
    {
        public string Cliente { get; set; } 
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento{ get; set; }
        public string  Regiao{ get; set; }
        public string Dia { get; set; }
        public string Mes { get; set; }
        public int Ano { get; set; }
        public string Hora { get; set; }
        public string Minuto { get; set; }
        public string Segundo { get; set; }
        public string Medidor { get; set; }
        public string Aparelho { get; set; }
        public string KiloWatts { get; set; }
        public string Custo { get; set; }
    }
}
