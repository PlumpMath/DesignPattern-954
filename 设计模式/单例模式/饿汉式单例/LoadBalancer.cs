using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式.饿汉式单例
{
    /// <summary>
    /// 这样会过早地创建实例，从而降低内存的使用效率
    /// </summary>
    public class LoadBalancer
    {
        List<CustomServer> listServer = null;
        private LoadBalancer()
        { // 服务器集合
            listServer = new List<CustomServer>();
        }
        private static readonly LoadBalancer balancer = new LoadBalancer ();

        public static LoadBalancer GetLoadBalancer()
        {
            return balancer;
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
    }
}
