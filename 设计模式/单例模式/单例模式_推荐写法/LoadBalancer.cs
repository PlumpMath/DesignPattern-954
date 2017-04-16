using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式.单例模式_推荐写法
{
    public class LoadBalancer
    {
        IList<CustomServer> listServer = null;
        private LoadBalancer()
        { // 服务器集合
            listServer = new List<CustomServer>();
        }
        // 公共静态成员方法，返回唯一实例
        public static LoadBalancer GetLoadBalancer()
        {
            return Nested.instance;
        }
        public void AddServer(CustomServer server)
        {
            listServer.Add(server);
        }
        private Random random = new Random();
        public CustomServer GetServer()
        {
            int index = random.Next(listServer.Count);
            return listServer[index];
        }
        // 使用内部类+静态构造函数实现延迟初始化
        class Nested
        {
            static Nested() { }
            internal static readonly LoadBalancer instance = new LoadBalancer();
        }
    }
}
