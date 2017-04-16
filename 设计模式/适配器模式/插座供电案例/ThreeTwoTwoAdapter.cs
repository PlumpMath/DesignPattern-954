using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.插座供电案例
{
    public class ThreeTwoTwoAdapter:IThreePlug
    {
        private GBTwoPlug twoplug;
        public ThreeTwoTwoAdapter(GBTwoPlug plug)
        {
            this.twoplug = plug;
        }
        public void PowerWithThree()
        {
            twoplug.powerWithTwo();
        }
    }
}
