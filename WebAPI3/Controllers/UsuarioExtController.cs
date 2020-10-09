using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI3.Models;

namespace WebAPI3.Controllers
{
    public class UsuarioExtController : ApiController
    {
        private static List<Extrato> ExtratoUsuario = new List<Extrato>();

        [HttpGet]
        public List<Extrato> UsuarioExtrato()
        {
            return ExtratoUsuario;
        }


        
        public void Post(string numerocartao, string data_compra, string Status_Extrato)
        {
            ExtratoUsuario.Add(new Extrato(numerocartao, data_compra, Status_Extrato));
        }

    }
}
