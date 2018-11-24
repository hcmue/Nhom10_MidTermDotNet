using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class DBConnection
    {
        string strCon;
        public DBConnection()
        {
            strCon = ConfigurationManager.ConnectionStrings["DBCOnnect"].ConnectionString;

        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(strCon);
        }
     
    }
}