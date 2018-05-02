
using Manager.Model.InputeMode;
using Mangaer.Contract.IImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Implement
{
    public class SysLogComponet : ComponetBase, ISysLogComponet
    {
        
        public async Task Add(Log log)
        {
           await Task.Delay(100);
            if (log == null)
                throw new Exception("日志没有实例化");
            Console.WriteLine("日志添加");
        }

        public async Task Update(Log log)
        {
            await Task.Delay(100);
            if (log == null)
                throw new Exception("日志没有实例化");
            Console.WriteLine("日志更新");

        }
    }
}
