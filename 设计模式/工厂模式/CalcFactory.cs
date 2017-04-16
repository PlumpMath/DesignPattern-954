﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 工厂模式.操作运算;

namespace 工厂模式
{
    public class CalcFactory
    {      
        public static Calc CreateOperate(string key)
        {
            Calc calc = null;
            switch (key)
            {
                case "+":
                    calc = new Add();
                    break;
                case "-":
                    calc = new Sub();
                    break;
                case "*":
                    calc = new Mul();
                    break;
                case "/":
                    calc = new Add();
                    break;
                default:
                    break;
            }
            return calc;
        }
    }
}
