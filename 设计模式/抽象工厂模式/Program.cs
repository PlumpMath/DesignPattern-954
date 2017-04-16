using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IPC pc = null;
            IPhone phone = null;
            //PC
            Console.WriteLine("-----------------------PC测试-----------------------------");
            IMediaFactory mediapc1 = new LenovoFactory();
            IMediaFactory mediapc2 = new XiaoMiFactory();
            pc = mediapc1.GetPC();
            pc.makePC();
            pc = mediapc2.GetPC();
            pc.makePC();
            Console.WriteLine("-----------------------Phone测试------------------------------------");
            IMediaFactory mediaphone1 = new LenovoFactory();
            IMediaFactory mediaphone2 = new XiaoMiFactory();
            phone = mediaphone1.GetPhone();
            phone.makehone();
            phone = mediaphone2.GetPhone();
            phone.makehone();
            Console.ReadKey();
        }
    }
}
