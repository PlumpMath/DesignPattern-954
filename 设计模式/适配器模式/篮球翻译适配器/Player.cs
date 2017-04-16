using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.篮球翻译适配器
{
    /// <summary>
    /// 球员
    /// </summary>
    public abstract class Player
    {
        protected string name;

        protected Player(string name)
        {
            this.name = name;
        }
        public abstract void Attack();
        public abstract void Defense();
    }

}
