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
    }

    //ShowValidationError retorna uma string com o texto formatado com a mensagem de erro
}
