﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaEletrica.Business
{
    public class RecordConverter
    {
        //Realiza a conversão de cada item do invoice.data
        //(o loop passando cada linha será feito no método que chamar essa classe)
        public InvoiceData ToInvoiceData(string record)
        {
           // string example = @"00000348340483300100051Bloco 1A apto 44    ##SSP29Março     20211544230007A16894030000840001550";

            InvoiceData model = new InvoiceData();
            model.Cliente = record.Substring(0, 10);
            model.Cep = record.Substring(10, 8);
            model.Numero = record.Substring(18, 5);
            model.Complemento = record.Substring(23, 20);
            model.Regiao = record.Substring(43, 5);
            model.Dia = record.Substring(48, 2);
            model.Mes = record.Substring(50, 10);
            model.Ano = Convert.ToInt32(record.Substring(60, 4));
            model.Hora = record.Substring(64, 2);
            model.Minuto = record.Substring(66, 2);
            model.Segundo = record.Substring(68, 2);
            model.Medidor = record.Substring(70, 10);
            model.Aparelho = record.Substring(80, 2);
            model.KiloWatts = record.Substring(82, 6);
            model.Custo = record.Substring(88, 7);

            return model;
        }
    }
}
