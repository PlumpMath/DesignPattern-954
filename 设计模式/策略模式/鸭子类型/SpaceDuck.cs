using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式.飞行;

namespace 策略模式.鸭子类型
{
    class SpaceDuck:Duck
    {
        public SpaceDuck()
        {
            base.setFlyingStragety(new FlyWithRocket());
        }
        public override void display()
        {
            Console.WriteLine("我头戴宇航头盔");
        }
        public override void quack()
        {
            Console.WriteLine("我通过无线电与你通信");
        }
    }
}
