using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.篮球翻译适配器
{
    public class Translator:Player
    {
        private foreignCenter wjzf = new foreignCenter();
        public Translator(string name)
            : base(name)
        {
            wjzf.Name = name;
        }
        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}
