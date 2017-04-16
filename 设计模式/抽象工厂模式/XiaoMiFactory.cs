using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    public class XiaoMiFactory:MediaFactory
    {
        public IPC GetPC()
        {
            return new XiaoMiPC();
        }

        public IPhone GetPhone()
        {
            return new XiaoMiPhone();
        }
    }
}
