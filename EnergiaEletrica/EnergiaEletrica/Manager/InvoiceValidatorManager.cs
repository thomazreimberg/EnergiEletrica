using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergiaEletrica.Business;

namespace EnergiaEletrica.Manager
{
    public class InvoiceValidatorManager
    {
        public List<RecordError> Validate(List<string> content)
        {
            List<RecordError> list = new List<RecordError>();
            foreach (string record in content)
            {
                try
                {
                    RecordConverter recordConverter = new RecordConverter();
                    InvoiceData separeteContent = recordConverter.ToInvoiceData(record);

                    RecordValidator recordValidator = new RecordValidator();
                    recordValidator.Validate(separeteContent, content.IndexOf(record));
                }
                catch (Exception.RecordValidatorException ex)
                {
                    list.AddRange(ex.Model);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return list;
        }
    }
}
