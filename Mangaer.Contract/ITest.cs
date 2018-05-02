﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;
namespace Mangaer.Contract
{
    public interface ITest : IGrainWithStringKey
    {
        Task<string> Holle();
        Task<string> GetName();
    }


    public interface IMyTest
    {
        Task<string> GetName();
    }
}
