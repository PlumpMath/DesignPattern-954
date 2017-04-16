using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式.懒汉式单例_线程安全_
{
    /// <summary>
    /// 线程比较安全
    /// </summary>
    public class LoadBalancer
    {
        private static LoadBalancer balancer=null;
        private static IList<CustomServer> serverList = null;
        private static readonly object syncLocker = new object();
        private LoadBalancer()
        {
            serverList = new List<CustomServer>();
        }
        public static LoadBalancer GetLoadBalancer()
        {
            if (balancer == null)
            {
                // 锁定代码块
                lock (syncLocker)
                {
                    // 第二重判断
                    if (balancer == null)
                    {
                        balancer = new LoadBalancer();
                    }
                }
            }
            return balancer;
        }
        public void AddServer(CustomServer server)
        {
            serverList.Add(server);
        }
        private static Random random = new Random();
        public  CustomServer GetServer()
        {
            int index = random.Next(serverList.Count);
            return serverList[index];
        }
    }
}
