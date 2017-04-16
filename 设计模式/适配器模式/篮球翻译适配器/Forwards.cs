using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.篮球翻译适配器
{
    /// <summary>
    /// 前锋
    /// </summary>
    public class Forwards:Player
    {
        public Forwards(string name)
            : base(name)
        {
 
        }
        public override void Attack()
        {
            Console.WriteLine(string.Format("前锋{0}进攻",name));
        }

        public override void Defense()
        {
            Console.WriteLine(string.Format("前锋{0}防守", name));
        }
    }
}
