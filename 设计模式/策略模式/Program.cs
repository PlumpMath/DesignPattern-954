using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式.鸭子类型;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = null;
           		duck = new BigYellow();
                duck = new MallardDuck();
                duck = new RubberDuck();
                duck = new SpaceDuck();

                duck.display();
                duck.fly();
                duck.quack();
            Console.ReadKey();
        }
    }
}
