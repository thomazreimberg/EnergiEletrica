using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EnergiaEletricaAPI.API.Controllers;
using EnergiaEletricaAPI.Models;

namespace EnergiaEletricaAPI.Services
{
    public class ServiceConverter
    {
        public void GenerateFileConverted ()
        {
            StreamWriter invoiceData = new StreamWriter("C:\\Users\\treim\\OneDrive\\Documentos\\Utils\\invoice.data");

            EnergyMeterController controller = new EnergyMeterController();
            List<ClientModel> list = controller.ModelConverter();

            Console.WriteLine("Gravando registros no arquivo invoice.data");

            foreach (ClientModel client in list)
            {
                foreach (EnergyMeterModel energy in client.EnergyData)
                {
                    invoiceData.WriteLine(client.ClientCode.ToString().Trim() +
                                            client.ZipCode.ToString().Trim().Replace("-", "") +
                                            client.AddressNumber.ToString().Trim() +
                                            client.Complement.ToString().Trim() +
                                            energy.EnergyMeterCode.ToString().Trim() +
                                            energy.MeasureDate.ToString().Trim().Replace("/", "").Replace(" ", "").Replace(":", "") +
                                            energy.Device.ToString().Trim() +
                                            energy.KiloWatts.ToString().Trim());
                }
            }
            invoiceData.Close();
        }
    }
}
