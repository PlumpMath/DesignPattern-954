﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.插座供电案例
{
    public class GBTwoPlug
    {
        public void powerWithTwo()
        {
            Console.WriteLine("使用二相电流供电");
        }
    }
}
