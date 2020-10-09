using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI3.Models
{
    public class Logradouro
    {

        public string Endereco { get;}

        public Logradouro(string endereco)
        {
            this.Endereco = endereco;
        }
    }
}