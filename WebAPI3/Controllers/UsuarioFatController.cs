using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI3.Models;

namespace WebAPI3.Controllers
{
    public class UsuarioFatController : ApiController
    {
        private static List<Fatura> FaturaUsuario = new List<Fatura>();

        [HttpGet]
        public List<Fatura> GetFatura()
        {
            return FaturaUsuario;
        }


        
        public void Post(string numerocartao, string statusfatura, string datapagamento)
        {
            FaturaUsuario.Add(new Fatura(numerocartao, statusfatura, datapagamento));
        }
    }
}
