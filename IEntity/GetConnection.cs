using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEntity
{
    public class GetConnection
    {
        
        public string GetConnectionString()
        {
            
            try
            {
                string strConnection = "Data Source=DESKTOP-0899RCC;Initial Catalog=MVCDB;User ID=sa;Password=123456; TrustServerCertificate=True";
                //con =new SqlConnection(strConnection);
                //string strConnection = ConfigurationManager.AppSettings["Connection"].ToString();


                return strConnection;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
