using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 代练者
    /// </summary>
    public class GamePalyerProxy : IGamePlayer  
    {
        private IGamePlayer gamePlayer = null;
        //通过构造函数传递要对谁进行代练
        public GamePalyerProxy(IGamePlayer mgamePlayer)
        {
            this.gamePlayer = mgamePlayer;
        }

        public void login(string user, string password)
        {
            this.gamePlayer.login(user, password);
        }

        public void killBoss()
        {
            this.gamePlayer.killBoss();
        }

        public void upgrade()
        {
            this.gamePlayer.upgrade();
        }
    }
}
