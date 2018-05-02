using Manager.Model.InputeMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;
namespace Mangaer.Contract.IImplement
{
   public interface ISysLogComponet:IGrainWithStringKey
    {
        Task Add(Log log);

        Task Update(Log log);
    }
}
