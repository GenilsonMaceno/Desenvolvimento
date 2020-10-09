using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI3.Models;

namespace WebAPI3.Controllers
{
    public class UsuarioLogController : ApiController
    {
        private static List<LoginUsuario> UsuarioComLogin = new List<LoginUsuario>();


        [HttpGet]
        public List<LoginUsuario> UsuarioLogin()
        {
            return UsuarioComLogin;
        }


       
        public void Post(string usuario, string senha)
        {
            UsuarioComLogin.Add(new LoginUsuario(usuario, senha));
        }


    }
}
