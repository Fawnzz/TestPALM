using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace PalmDataLayer
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            //connection from local host
            string connectionString = "Data Source=MCFAWN;Initial Catalog=PALM3;Integrated Security=True";
           
            //connection from server
            //string connectionString = "Data Source=192.168.1.132;Initial Catalog=PALM3;User ID=SA;PAssword=2016NBcc!";
            
            return new SqlConnection(connectionString);
        }
    }
}
