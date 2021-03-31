using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaEletrica
{
    public class RecordError
    {
        public string Error { get; set; }
        public int Line { get; set; }
        public string Field { get; set; }

        public RecordError(string error, int line, string field)  
        {
            this.Error = error;
            this.Line = line;
            this.Field = field;
        }

        //ShowValidationError retorna uma string com o texto formatado com a mensagem de erro
        public string ShowValidationError ()
        {
            throw new ArgumentException(Error + " na linha: " + Line + " no campo: " + Field);
        }
    }

    
}
