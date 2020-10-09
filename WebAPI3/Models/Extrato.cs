using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI3.Models
{
    public class Extrato
    {

        public string NumeroCartao { get; }
        public string Data_Compra { get; }
        public string Status_Extrato { get; }

        public Extrato(string numerocartao, string data_compra, string Status_Extrato)
        {
            this.NumeroCartao = numerocartao;
            this.Data_Compra = data_compra;
            this.Status_Extrato = Status_Extrato;
        }


    }
}