using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式.操作运算
{
    public class Div:Calc
    {
        public override double GetResult()
        {
            if (this.Num2 == 0)
            {
                throw new Exception("除数不能为0");
            }
            return this.Num1 / this.Num2;
        }
    }
}
