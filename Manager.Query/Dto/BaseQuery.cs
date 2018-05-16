using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Query.Dto
{
   public  class BaseQuery:IDisposable
    {
        public  SqlConnection conn
        {
            get;set; 
        }
        public BaseQuery()
        {
            conn=  new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDiagnosticsDb"].ConnectionString);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


       
    }
}
