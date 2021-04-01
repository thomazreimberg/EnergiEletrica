using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaEletrica.Exception
{
    public class RecordValidatorException : System.Exception
    {
        public List<RecordError> Model { get; set; }

        public RecordValidatorException(List<RecordError> error)
        {
            this.Model = error;
        }
    }
}
