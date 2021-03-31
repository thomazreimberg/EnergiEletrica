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
        public List<InvoiceData> Validate(List<string> content)
        {
            List<InvoiceData> invoiceData = new List<InvoiceData>();

            try
            {
                bool validated = true;

                foreach (string record in content)
                {
                    RecordConverter recordConverter = new RecordConverter();
                    InvoiceData separeteContent = recordConverter.ToInvoiceData(record);

                    RecordValidator recordValidator = new RecordValidator();
                    validated = recordValidator.Validate(separeteContent);

                    if (validated)
                        invoiceData.Add(separeteContent);

                }

                return invoiceData;
            }
            catch (Exception)
            {
                return invoiceData;
            }
        }
    }
}
