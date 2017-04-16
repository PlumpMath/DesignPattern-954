using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式.飞行;

namespace 策略模式.鸭子类型
{
    public class BigYellow:Duck
    {
        public BigYellow()
        {
            base.setFlyingStragety(new FlyNoWay());
        }
        public override void display()
        {
            Console.WriteLine("我身体很大，全身黄黄");
        }
        public override void quack()
        {
            Console.WriteLine("我不会叫");
        }
    }
}
