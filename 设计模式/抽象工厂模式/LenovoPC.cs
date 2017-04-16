using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    public class LenovoPC:IPC
    {
        public void makePC()
        {
            Console.WriteLine("联想笔记本电脑");
        }
    }
}
