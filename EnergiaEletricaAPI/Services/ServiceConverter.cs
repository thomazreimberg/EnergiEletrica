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
            //StreamWriter invoiceData = new StreamWriter("C:\\Users\\Public\\Desafio\\invoice.data");


            EnergyMeterController controller = new EnergyMeterController();
            List<ClientModel> list = controller.ModelConverter();

            Console.WriteLine("Gravando registros no arquivo invoice.data");

            foreach (ClientModel client in list)
            {
                foreach (EnergyMeterModel energy in client.EnergyData)
                {
                    double custo = energy.KiloWatts * 0.2;
                    invoiceData.WriteLine(client.ClientCode.ToString().Trim().PadLeft(10, '0') +
                                            client.ZipCode.ToString().Trim().Replace("-", "") +
                                            client.AddressNumber.ToString().Trim().PadLeft(5, '0') +
                                            client.Complement.ToString().Trim().PadRight(20, ' ') +
                                            "##SSP" +
                                            energy.MeasureDate.ToString("dd") +
                                            "          " +
                                            energy.MeasureDate.ToString("yyyy") +
                                            energy.MeasureDate.ToString("hh") +
                                            energy.MeasureDate.ToString("mm") +
                                            energy.MeasureDate.ToString("ss") +
                                            energy.EnergyMeterCode.ToString().Trim().PadLeft(10, '0') +
                                            energy.Device.ToString().Trim().PadLeft(2, '0') +
                                            energy.KiloWatts.ToString().Trim().PadLeft(6, '0') +
                                            custo.ToString().Replace(".", "").PadLeft(7, '0'));
                }
            }
            invoiceData.Close();
        }
    }
}
