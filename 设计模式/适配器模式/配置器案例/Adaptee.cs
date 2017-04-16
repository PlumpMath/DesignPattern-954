using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.配置器案例
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("这是一个特殊请求");
        }
    }
}
