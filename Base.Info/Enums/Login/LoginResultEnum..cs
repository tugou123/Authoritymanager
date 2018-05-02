using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Info.Enums
{
    public enum LoginResultEnum
    {
        [Display(Name = "成功")]
        Success = 10,
        [Display(Name = "账户密码不存在")]
        UserNameUnExists = 20,
        [Display(Name = "验证码错误")]
        VerifyCodeError = 30,
        [Display(Name = "账户密码错误")]
        UserNameOrPasswordError = 40
    }
    
}
