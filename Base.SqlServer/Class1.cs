using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.SqlServer
{
    public class QueryDapper
    {
        public static SqlConnection conn
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDiagnosticsDb"].ConnectionString);
            }
        }
        
    }
}
