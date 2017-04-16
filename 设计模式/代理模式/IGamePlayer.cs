using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    public interface IGamePlayer 
    {
        //登录游戏
        void login(String user, String password);
        //杀怪
        void killBoss();
        //升级
        void upgrade();
    }
}
