﻿using System;
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

        public RecordError()
        {

        }

        public RecordError(string error, int line, string field)  
        {
            this.Error = error;
            this.Line = line;
            this.Field = field;
        }

        public string ShowValidationError ()
        {
            return @"Linha: " + Line + "\nCampo: " + Field + "\nErro: " + Error;
        }
    }

    
}
