using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaEletricaAPI.Models
{
    public class ClientModel
    {
        public int ClientCode { get; set; }
        public string ZipCode { get; set; }
        public string AddressNumber { get; set; }
        public string Complement { get; set; }
        public List<EnergyMeterModel> EnergyData { get; set; }

    }
}
