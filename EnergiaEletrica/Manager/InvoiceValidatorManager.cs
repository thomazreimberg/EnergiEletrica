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
                    if (record.Length < 95 || record.Length > 95)
                    {
                        RecordError model = new RecordError();
                        model.Error = "Tamanho do registro inválido.";
                        model.Line = content.IndexOf(record);
                        model.Field = "Linha";
                        list.Add(model);
                    }

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
