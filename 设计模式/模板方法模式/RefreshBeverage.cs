using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    public abstract class RefreshBeverage
    {
        public void prepareBeverageTemplate(){
		//步骤1 将水煮沸
		boilWater();
		//步骤2 泡制饮料
		brew();
		//步骤3 将饮料倒入杯中
		pourInCup();
		if(isCustomerWantsCondiments()){
			//步骤4 加入调味料
			addCondiments();
		}
	}

        protected abstract void addCondiments();

        protected virtual bool isCustomerWantsCondiments()
        {
            return true;
        }

        private void pourInCup()
        {
            Console.WriteLine("将饮料倒入杯中");
        }

        protected abstract void brew();

        private void boilWater()
        {
            Console.WriteLine("将水煮沸");
        }

    }
}
