using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式.操作运算
{
    public class Mul:Calc
    {
        public override double GetResult()
        {
            return this.Num1 * this.Num2;
        }
    }
}
