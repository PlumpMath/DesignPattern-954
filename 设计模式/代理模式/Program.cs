using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个痴迷的玩家
            IGamePlayer player = new GamePlayer("张三");
            //然后定义一个代练者
            IGamePlayer proxy = new GamePalyerProxy(player);
            //开始打游戏
            proxy.login("zhangsan", "123456");
            //打怪
            proxy.killBoss();
            //升级
            proxy.upgrade();
            Console.ReadKey();
        }
    }
}
