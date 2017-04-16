using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式.飞行;

namespace 策略模式.鸭子类型
{
    class MallardDuck:Duck
    {
        public MallardDuck()
        {
            base.setFlyingStragety(new FlyWithWin());
        }

        public override void display()
        {
            Console.WriteLine("我的脖子是绿色的");
        }
    }
}
