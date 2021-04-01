using System;
using System.Collections.Generic;
using EnergiaEletrica.Business;
using EnergiaEletrica.Manager;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;
namespace EnergiaEletrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chama o LoadFileContent (input)

            //Após o input InvoiceValidatorManager(passa o input do LoadFileContent)

            //Exibir a resposta

            // ---------------- TESTE -----------------------
            string path = @"C:\Users\Public\Desafio\Semana 8 - Invoice.data";
            List<string> lines = File.ReadAllLines(path).ToList();

            InvoiceValidatorManager manager = new InvoiceValidatorManager();
            List<RecordError> list = manager.Validate(lines);

            if (list.Count != 0)
            {
                foreach (RecordError item in list)
                {
                    Console.WriteLine(item.ShowValidationError());
                }
            }
            Console.ReadKey();
        }
    }
}
