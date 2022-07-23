using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev2_MVC.DAL
{
    public class SqlConnect
    {
        private string _sqlConnection = @"Server=DESKTOP-63E5VH2;Database=MVCWebSite;Trusted_Connection=True;";

        public string SqlConnection { get { return _sqlConnection; } }
    }
}