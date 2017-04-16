using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.插座供电案例
{
    public class NotepadBook
    {
        private IThreePlug threeplug;
        public NotepadBook(IThreePlug plug)
        {
            this.threeplug = plug;
        }
        public void charge()   //开始充电
        {
            threeplug.PowerWithThree();
        }
    }
}
