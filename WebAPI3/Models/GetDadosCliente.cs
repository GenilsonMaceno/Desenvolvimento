using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace WebAPI3.Models
{
    public class GetDadosCliente
    {
              

        public GetDadosCliente()
        {

            string cxn = "server=localhost;port=3307;User id=root;database=bd_cliente; password=usbw;";
            MySqlConnection conexao = new MySqlConnection(cxn);
            conexao.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conexao;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select CPF from cliente;";

            comm.ExecuteNonQuery();

        }
    }
}