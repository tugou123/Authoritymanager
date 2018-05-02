using Base.Info.Enums;
using Manager.Model.InputeMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangaer.Contract.Dtos
{
   public class LoginUserDto
    {
        public LoginResultEnum LoginResult;

        public LoginUser loginUser { set; get; }
    }
}
