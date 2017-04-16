using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.飞行
{
    class FlyWithWin:FlyingStragety
    {
        public void performFly()
        {
            Console.WriteLine("展翅高飞");
        }
    }
}
