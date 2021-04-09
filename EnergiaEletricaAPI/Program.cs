using EnergiaEletricaAPI.API.Controllers;
using EnergiaEletricaAPI.Models;
using System;
using System.Collections.Generic;

namespace EnergiaEletricaAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TESTE 
            EnergyMeterController controller = new EnergyMeterController();
            List<ClientModel> list = controller.ModelConverter();

            foreach (ClientModel client in list)
            {
                Console.WriteLine(client.ClientCode);
                Console.WriteLine(client.ZipCode);
                Console.WriteLine(client.AddressNumber);
                Console.WriteLine(client.Complement);

                foreach (EnergyMeterModel energy in client.EnergyData)
                {
                    Console.WriteLine(energy.EnergyMeterCode);
                    Console.WriteLine(energy.MeasureDate);
                    Console.WriteLine(energy.Device);
                    Console.WriteLine(energy.KiloWatts);
                }
                Console.ReadKey();
            }
        }

        /* 
         *  - Configurar a rota da API (Controller) para consumir a API do Bruno - Felipe
            - Criar os modelos para serem carregados com o response da API - Felipe
            - Criar conversor para converter os objetos de modelos para a txt(string) - Thomaz
         */
    }
}
