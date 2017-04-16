using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            RefreshBeverage b1 = new Coffee();
		b1.prepareBeverageTemplate();
            Console.WriteLine("咖啡好了！");	
		Console.WriteLine("\n******************************************");
		
		Console.WriteLine("制备茶...");
		RefreshBeverage b2 = new Tea();
		b2.prepareBeverageTemplate();
        Console.WriteLine("茶好了！");
            Console.ReadKey();
        }
    }
}
