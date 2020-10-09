using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI3.Models;

namespace WebAPI3.Controllers
{
    public class UsuarioEndController : ApiController
    {
        private static List<Logradouro> EnderecoUsuario = new List<Logradouro>();


        [HttpGet]
        public List<Logradouro> GetEdenreco()
        {
            return EnderecoUsuario;
        }


        public void Post(string Endereco)
        {
           EnderecoUsuario.Add(new Logradouro(Endereco));
        }



    }
}
