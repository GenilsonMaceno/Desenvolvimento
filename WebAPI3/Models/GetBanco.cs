using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI3.Models
{
    public class GetBanco
    {
        public string Nome { get; set; }

        public GetBanco(string nome)
        {
            this.Nome = nome;
        }
    }
}