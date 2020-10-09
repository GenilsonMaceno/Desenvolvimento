using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI3.Models;
using MySql.Data.MySqlClient;

namespace WebAPI3.Controllers
{
    public class BancoController : ApiController
    {
        private static List<GetBanco> clientes = new List<GetBanco>();

        public string Usuario { get; set; }
        public string Senha { get; set; }


        // [HttpGet] Quando quero definir outro nome para minha lista
        public List<GetBanco> Get()
        {
            return clientes;
        }

        // metodo de insert
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            clientes.Add(new GetBanco(nome));
        }

        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }

    }
}
