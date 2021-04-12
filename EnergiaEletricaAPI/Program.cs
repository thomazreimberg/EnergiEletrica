using System;
using EnergiaEletricaAPI.Services;

namespace EnergiaEletricaAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceConverter serviceConverter = new ServiceConverter();
                serviceConverter.GenerateFileConverted();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine(@"Arquivos invoice.data gerado no caminho C:\Users\treim\OneDrive\Documentos\Utils\invoice.data");
                Console.ReadKey();
            }
            
        }
    }
}
