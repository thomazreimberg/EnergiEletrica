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
        public bool Validate(InvoiceData recordContent)
        {
            int falso = 0;

            //Cliente
            if (recordContent.Cliente == string.Empty)
                falso++;

            if (recordContent.Cliente.Length != 10)
                falso++;

            //Cep
            if (recordContent.Cep == string.Empty)
                falso++;

            if (recordContent.Cep.Length != 8)
                falso++;

            //Número
            if (recordContent.Numero == string.Empty)
                falso++;

            if (recordContent.Numero.Length != 5)
                falso++;

            //Complemento
            if (recordContent.Complemento != string.Empty)
                if (recordContent.Complemento.Length != 20) 
                    falso++;

            //Região
            if (recordContent.Regiao == string.Empty)
                falso++;

            if (recordContent.Regiao.Length != 5)
                falso++;

            if (recordContent.Regiao != "##SSP")
                falso++;

            //Dia
            if (recordContent.Dia == string.Empty)
                falso++;

            if (recordContent.Dia.Length != 2)
                falso++;

            //Mês
            if (recordContent.Mes == string.Empty)
                falso++;

            if (recordContent.Mes.Length != 10)
                falso++;

            //Ano
            if(recordContent.Ano < 1000 || recordContent.Ano > 9999)
                falso++;

            //Hora
            if (recordContent.Hora == string.Empty)
                falso++;

            if (recordContent.Hora.Length != 2)
                falso++;

            //Minuto
            if (recordContent.Minuto == string.Empty)
                falso++;

            if (recordContent.Minuto.Length != 2)
                falso++;

            //Segundo
            if (recordContent.Segundo == string.Empty)
                falso++;

            if (recordContent.Segundo.Length != 2)
                falso++;

            //Medidor
            if (recordContent.Medidor == string.Empty)
                falso++;

            if (recordContent.Medidor.Length != 10)
                falso++;

            //Aparelho
            if (recordContent.Aparelho == string.Empty)
                falso++;

            if (recordContent.Aparelho.Length != 2)
                falso++;

            //Kilo Watts
            if (recordContent.KiloWatts == string.Empty)
                falso++;

            if (recordContent.KiloWatts.Length != 6)
                falso++;

            //Custo
            if (recordContent.Custo == string.Empty)
                falso++;

            if (recordContent.Custo.Length != 7)
                falso++;

            //Finalizado as validações

            return falso > 0 ? false : true;
        }
    }
}
