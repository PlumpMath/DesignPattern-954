using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    public abstract class Calc
    {
        private double num1 = 0;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        private double num2 = 0;

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public abstract double GetResult();
    }
    
}
