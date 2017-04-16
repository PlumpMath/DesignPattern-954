using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.飞行
{
    public class FlyNoWay:FlyingStragety
    {
        public void performFly()
        {
            Console.WriteLine("我不会飞行");
        }
    }
}
