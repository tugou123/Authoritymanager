﻿using Dapper;
using Mangaer.Contract.Dtos;
using Mangaer.Contract.IService.IQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Query
{
    //这里用Darper
    public class UserAppServiceQuery : IUserAppServiceQuery
    {
         
        public Task<IEnumerable<TokeninfoDto>> GetALLTokens(long operatorid)
        {
            using (var mx=new Dto.UserDao())
            {
               await 
            }
        }

        public Task<IEnumerable<UserinfoDto>> GetAllUserinfo(long operatorid)
        {
            throw new NotImplementedException();
        }

        public Task<TokeninfoDto> GetToken(string token)
        {
            throw new NotImplementedException();
        }

        public Task<TokeninfoDto> GetToken(long userid)
        {
            throw new NotImplementedException();
        }

        public Task<UserinfoDto> GetUserinfo(long userid, long operatorid)
        {
            throw new NotImplementedException();
        }
    }
}
