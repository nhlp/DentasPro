
namespace Dentas_Pro.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.SqlClient;

    public class Connect_To_DB
    {
        public void Connect_Sql_Server(bool isItTrue) 
        {
            SqlConnection sqlConnection = new SqlConnection("Server=10.168.0.26;Database=DentasPro;uid=sa;pwd=dentas;");
        }
    }
}
