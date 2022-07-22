using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCMeuSistema.Models
{
    public class Produtos
    {
        private readonly static string _conn = @"Data Source=.;Initial Catalog=devdb;Persist Security Info=True;User ID=admin;Password=123";

            public int ID { get; set; }
            public string NOME { get; set; }
            public string VALOR { get; set; }
            public int QUANTIDADE { get; set; }
            public DateTime DATAHORA { get; set; }

     
}