using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.鸭子类型
{
    public abstract class Duck
    {
        public virtual void quack()
        {
            Console.WriteLine("嘎嘎嘎");
        }
        //鸭子的描述
        public abstract void display();
        //
        private FlyingStragety flyingStragety=null;
        //多用组合少用继承,用到了不同的飞行策略
        public void setFlyingStragety(FlyingStragety flyingStragety)
        {
            this.flyingStragety = flyingStragety;
        }

        public void fly()
        {
            flyingStragety.performFly();
        }

    }
}
