using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI3.Models
{
    public class Fatura
    {
        public string NumeroCartao { get; }
        public string Status_Fatura { get; }
        public string Data_Pagamento { get; }

        public Fatura(string numerocartao, string statusfatura, string datapagamento)
        {
            this.NumeroCartao = numerocartao;
            this.Status_Fatura = statusfatura;
            this.Data_Pagamento = datapagamento;
        }
    }
}