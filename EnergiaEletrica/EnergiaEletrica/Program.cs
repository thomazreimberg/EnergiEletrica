using System;
using EnergiaEletrica.Business;
using EnergiaEletrica.Manager;
namespace EnergiaEletrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chama o LoadFileContent (input)

            //Após o input InvoiceValidatorManager(passa o input do LoadFileContent)

            //Exibir a resposta

            RecordConverter model = new RecordConverter();
            model.ToInvoiceData("=");
        }
    }
}
