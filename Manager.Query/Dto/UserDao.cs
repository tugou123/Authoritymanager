using Dapper;
using Mangaer.Contract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Query.Dto
{
   public  class UserDao: BaseQuery
    {
        public UserDao():base()
        {
           
        }

        public async Task<IEnumerable<TokeninfoDto>> GetALLTokens(long operatorid)
        {
           
          return  await  conn.QueryAsync<TokeninfoDto>("", new { });
        }

    }
}
