using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    public class Tea:RefreshBeverage 
    {
        protected override void addCondiments()
        {
            Console.WriteLine("加入柠檬");
        }

        protected override void brew()
        {
            Console.WriteLine("用80度的热水浸泡茶叶5分钟");
        }
        protected override bool isCustomerWantsCondiments()
        {
            return false;
        }
    }
}
