using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace EnergiaEletrica.Business
{
    public class RecordValidator
    {
        //Aplica as regras de validação dos campos do invoice.data (seguir o exemplo do PDF "Semana 8 - Invoice File)
        public void Validate(InvoiceData recordContent, int line)
        {
            List<RecordError> list = new List<RecordError>();
            RecordError model = new RecordError();
            
            //Cliente
            if (recordContent.Cliente.Trim().Length != 10)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Cliente";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Cliente,@"[a-zA-Z]").Count > 0)
	        {
                model.Error = "Não é permite tipos não-numéricos";
                model.Line = line;
                model.Field = "Cliente";
                list.Add(model);
            }
            if (recordContent.Cliente.Contains("#"))
            {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Cliente";
                list.Add(model);
            }

            //Cep
            if (recordContent.Cep.Trim().Length != 8)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "CEP";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Cep,@"[a-zA-Z]").Count > 0)
	        {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "CEP";
                list.Add(model);
            }

            //Número
            if (recordContent.Numero.Trim().Length != 5)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Número";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Numero,@"[a-zA-Z]").Count > 0)
	        {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Número";
                list.Add(model);
            }

            //Complemento
            if (recordContent.Complemento.Length != 20)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Complemento";
                list.Add(model);
            }

            //Região
            if (recordContent.Regiao.Trim().Length != 5)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Região";
                list.Add(model);
            }

            //Dia
            if (recordContent.Dia.Trim().Length != 2)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Dia";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Dia,@"[a-zA-Z]").Count > 0)
	        {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Dia";
                list.Add(model);
            }

            //Mês
            if (recordContent.Mes.Length != 10)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Mês";
                list.Add(model);
            }

            //Ano
            if (recordContent.Ano.Trim().Length != 4)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Ano";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Ano,@"[a-zA-Z]").Count > 0)
	        {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Ano";
                list.Add(model);
            }

            //Hora
            if (recordContent.Hora.Trim().Length != 2)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Hora";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Hora,@"[a-zA-Z]").Count > 0)
	        {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Hora";
                list.Add(model);
            }

            //Minuto
            if (recordContent.Minuto.Trim().Length != 2)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Minuto";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Minuto,@"[a-zA-Z]").Count > 0)
	        {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Minuto";
                list.Add(model);
            }

            //Segundo
            if (recordContent.Segundo.Trim().Length != 2)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Segundo";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Segundo, @"[a-zA-Z]").Count > 0)
            {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Segundo";
                list.Add(model);
            }

            //Medidor
            if (recordContent.Medidor.Trim().Length != 10)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Medidor";
                list.Add(model);
            }

            //Aparelho
            if (recordContent.Aparelho.Trim().Length != 2)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Aparelho";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Aparelho, @"[a-zA-Z]").Count > 0)
            {
                model.Error = "Não é permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Aparelho";
                list.Add(model);
            }

            //Kilo Watts
            if (recordContent.KiloWatts.Trim().Length != 6)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "KiloWatts";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.KiloWatts, @"[a-zA-Z]").Count > 0)
            {
                model.Error = "Não permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "KiloWatts";
                list.Add(model);
            }

            //Custo
            if (recordContent.Custo.Trim().Length != 7)
            {
                model.Error = "Não atingiu os caracteres necessários";
                model.Line = line;
                model.Field = "Custo";
                list.Add(model);
            }

            if (Regex.Matches(recordContent.Custo, @"[a-zA-Z]").Count > 0)
            {
                model.Error = "Não permitido tipos não-numéricos";
                model.Line = line;
                model.Field = "Custo";
                list.Add(model);
            }

            //Finalizado as validações

            if (list.Count != 0)
            {
                throw new Exception.RecordValidatorException(list);

            }
        }
    }
}
