using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式.飞行;

namespace 策略模式.鸭子类型
{
    public class RubberDuck:Duck
    {
        public RubberDuck() {
            base.setFlyingStragety(new FlyNoWay());
        }
        public override void display()
        {
            Console.WriteLine("我全身发黄，嘴巴很红");
        }
        public override void quack()
        {
            Console.WriteLine("嘎~嘎~嘎");
        }
    }
}
