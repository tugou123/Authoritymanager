using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mangaer.Contract;
using Orleans;
namespace Manager.Implement
{
    public class Test :Orleans.Grain,ITest
    {
        private readonly IMyTest imyTest;
        public Test(IMyTest imyTest)
        {
            this.imyTest = imyTest;
        }
        public async Task<string> Holle()
        {
           return  await Task.FromResult("这是测试数据");
        }
        public async Task<string> GetName()
        {
            return await imyTest.GetName();
        }

    }

    public class MyTest : IMyTest
    {
        public async Task<string> GetName()
        {
            return await Task.FromResult("我是傅万夫:" + DateTime.Now);
        }
    }
}
