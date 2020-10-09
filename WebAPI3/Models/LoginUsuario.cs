using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI3.Models
{
    public class LoginUsuario
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public LoginUsuario(string usuario, string senha)
        {
            this.Usuario = usuario;
            this.Senha = senha;
        }
    }
}