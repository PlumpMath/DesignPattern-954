using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.配置器案例
{
    /// <summary>
    /// 大话设计模式案例
    /// </summary>
    public class Target
    {
        public virtual void Requert()
        {
            Console.WriteLine("这是一个普通请求");
        }
    }
}
