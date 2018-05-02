using Base.Info.Enums;

using Manager.Model.InputeMode;
using Mangaer.Contract.Dtos;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangaer.Contract.IImplement
{
  public interface IUserComponet: IGrainWithStringKey
    {
       Task<LoginResultEnum> Login(string username, string password, Action<LoginUser> lou);
        Task<LoginUserDto> Login(string username, string password);
    }
}
