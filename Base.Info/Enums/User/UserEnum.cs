
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace Base.Info.Enums
{
    public enum UserType
    {
        [Display(Name ="超级管理员")]
        Super_administrator = 10,
        [Display(Name = "管理员")]
        Guest =20,
        [Display(Name = "会员")]
        Ordinary = 30,
    }



    public enum Userlevel
    {
        [Display(Name ="普通会员")]
         Common=10,
        [Display(Name = "VIP")]
        VIP =20

    }
}