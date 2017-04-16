using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 适配器模式.插座供电案例;
using 适配器模式.篮球翻译适配器;
using 适配器模式.配置器案例;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 插座供电案例
            //Console.WriteLine("插上三孔进行充电");
            //GBThreePlug gbp = new GBThreePlug();
            //NotepadBook nb = new NotepadBook(gbp);
            //nb.charge();
            //Console.WriteLine("---------------------分割线-----------------------------");
            //Console.WriteLine("通过适配器接入二相插孔");
            //GBTwoPlug gb = new GBTwoPlug();
            //IThreePlug tp = new ThreeTwoTwoAdapter(gb);
            //NotepadBook nb2 = new NotepadBook(tp);
            //nb2.charge();
            #endregion        
            #region 适配器案例
            //Console.WriteLine("----------------------------普通请求----------------------------");
            //Target target1 = new Target();
            //target1.Requert();
            //Console.WriteLine("----------------------------进行适配后的普通请求：---------------");
            //Target target = new Adapter();
            //target.Requert();
            #endregion
            #region 篮球翻译适配器
            Player b = new Forwards("巴蒂尔");
            b.Attack();
            Player m = new Guards("麦克格雷迪");
            m.Attack();
            Player y = new Translator("姚明");
            y.Attack();
            y.Defense();
            #endregion         
            Console.ReadKey();
        }
    }
}
