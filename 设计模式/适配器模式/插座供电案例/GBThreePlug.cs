using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.插座供电案例
{
    class GBThreePlug:IThreePlug
    {
        public void PowerWithThree()
        {
            Console.WriteLine("使用三相电流供电");
        }
    }
}
