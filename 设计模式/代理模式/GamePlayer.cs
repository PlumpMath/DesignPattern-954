using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 游戏者
    /// </summary>
    public class GamePlayer : IGamePlayer 
    {
        private string name = "";
        public GamePlayer(string name)
        {
            this.name = name;
        }
        public void login(string user, string password)
        {
            Console.WriteLine("登录名为" + user + "用户名为" + name + "登陆成功");
        }

        public void killBoss()
        {
            Console.WriteLine(this.name + "在打怪");
        }

        public void upgrade()
        {
            Console.WriteLine(this.name + "又升了一级");
        }
    }
}
