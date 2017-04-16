using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    public class LenovoFactory:IMediaFactory
    {

        public IPC GetPC()
        {
            return new LenovoPC();
        }

        public IPhone GetPhone()
        {
            return new LenovoPhone();
        }
    }
}
