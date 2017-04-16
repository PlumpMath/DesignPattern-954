﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.篮球翻译适配器
{
    /// <summary>
    /// 后卫
    /// </summary>
    public class Guards:Player
    {
        public Guards(string name)
            : base(name)
        {
 
        }
        public override void Attack()
        {
            Console.WriteLine(string.Format("后卫{0}进攻",name));
        }

        public override void Defense()
        {
            Console.WriteLine(string.Format("后卫{0}防守", name));
        }
    }
}
