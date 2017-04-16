using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------简单工厂模式--------------------");
            Calc calc = CalcFactory.CreateOperate("+");
            calc.Num1 = 10;
            calc.Num2 = 3;
            Console.WriteLine(calc.GetResult()); 
            Console.ReadKey();
        }
    }
}
