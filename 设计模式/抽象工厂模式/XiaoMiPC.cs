using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    public class XiaoMiPC:IPC
    {
        public void makePC()
        {
            Console.WriteLine("小米笔记本");
        }
    }
}
