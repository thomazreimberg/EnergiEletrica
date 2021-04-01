using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergiaEletrica.Business
{
    public class RecordValidator
    {
        //Aplica as regras de validação dos campos do invoice.data (seguir o exemplo do PDF "Semana 8 - Invoice File)
        public void Validate(InvoiceData recordContent)
        {
            List<RecordError> list = new List<RecordError>();

            //Cliente
            if (string.IsNullOrEmpty(recordContent.Cliente))
            {
                RecordError model = new RecordError();
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = 2; // 2 em Line é só um exemplo
                model.Field = "Cliente";
                list.Add(model);
            }

            if (string.IsNullOrEmpty(recordContent.Cep))
            {
                RecordError model = new RecordError();
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = 2;
                model.Field = "Cep";
                list.Add(model);
            }

            if (string.IsNullOrEmpty(recordContent.Numero))
            {
                RecordError model = new RecordError();
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = 2;
                model.Field = "Numero";
                list.Add(model);
            }

            if (recordContent.Cliente.Length != 10)

            //Cep
            if (recordContent.Cep == string.Empty)

            if (recordContent.Cep.Length != 8)

            //Número
            if (recordContent.Numero == string.Empty)

            if (recordContent.Numero.Length != 5)

            //Complemento
            if (recordContent.Complemento != string.Empty)
                if (recordContent.Complemento.Length != 20) 

            //Região
            if (recordContent.Regiao == string.Empty)

            if (recordContent.Regiao.Length != 5)

            if (recordContent.Regiao != "##SSP")

            //Dia
            if (recordContent.Dia == string.Empty)

            if (recordContent.Dia.Length != 2)

            //Mês
            if (recordContent.Mes == string.Empty)

            if (recordContent.Mes.Length != 10)

            //Ano
            if(recordContent.Ano < 1000 || recordContent.Ano > 9999)

            //Hora
            if (recordContent.Hora == string.Empty)

            if (recordContent.Hora.Length != 2)

            //Minuto
            if (recordContent.Minuto == string.Empty)

            if (recordContent.Minuto.Length != 2)

            //Segundo
            if (recordContent.Segundo == string.Empty)

            if (recordContent.Segundo.Length != 2)

            //Medidor
            if (recordContent.Medidor == string.Empty)

            if (recordContent.Medidor.Length != 10)

            //Aparelho
            if (recordContent.Aparelho == string.Empty)

            if (recordContent.Aparelho.Length != 2)

            //Kilo Watts
            if (recordContent.KiloWatts == string.Empty)

            if (recordContent.KiloWatts.Length != 6)

            //Custo
            if (recordContent.Custo == string.Empty)

            if (recordContent.Custo.Length != 7)

            //Finalizado as validações

            if (list.Count != 0)
            {
                throw new Exception.RecordValidatorException(list);

            }
        }
    }
}
