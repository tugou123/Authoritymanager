
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
        [Display(Name = "LSM管理员")]
        Guest_LSM =20,
        [Display(Name = "LSM普通管理员")]
        Ordinary_LSM = 30,
    }
}