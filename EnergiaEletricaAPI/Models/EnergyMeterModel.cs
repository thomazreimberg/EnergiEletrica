using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaEletricaAPI.Models
{
    public class EnergyMeterModel
    {
        public string EnergyMeterCode { get; set; }
        public DateTime MeasureDate { get; set; }
        public int Device { get; set; }
        public int KiloWatts { get; set; }
    }
}
