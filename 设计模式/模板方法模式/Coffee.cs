using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    public class Coffee:RefreshBeverage
    {
        protected override void addCondiments()
        {
            Console.WriteLine("加入糖和牛奶");
        }

        protected override void brew()
        {
            Console.WriteLine("用沸水冲泡咖啡");
        }
    }
}
