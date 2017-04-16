using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.配置器案例
{
    class Adapter:Target
    {
        private Adaptee ada = new Adaptee();
        public override void Requert()
        {
            ada.SpecificRequest();
        }
    }
}
