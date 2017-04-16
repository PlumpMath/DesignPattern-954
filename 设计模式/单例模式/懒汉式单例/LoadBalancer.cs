using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式.懒汉式单例
{
    /// <summary>
    /// 在第一个调用LoadBalancer.GetLoadBalancer()时才会实例化对象，这种技术又被称之为延迟加载(多个线程调用的时候，可能存在一个对象还没创建完毕，调用时判断对象为空，而造成创建了多个对象的情况，就需要使用加锁解决)
    /// </summary>
    public class LoadBalancer
    {
        // 私有静态变量，存储唯一实例
        private static LoadBalancer instance = null;
        // 服务器集合
        private IList<CustomServer> serverList = null;
        private LoadBalancer() {
            serverList = new List<CustomServer>();
        } 
          // 公共静态成员方法，返回唯一实例
        public static LoadBalancer GetLoadBalancer() 
        {
            if (instance == null)
            {
                instance = new LoadBalancer();
            }
            return instance;
        }
        //添加一台服务器
        public void AddServer(CustomServer server)
        {
            serverList.Add(server);
        }
        // 获得一台Server - 使用随机数获取
        private Random rand = new Random();
        public CustomServer GetServer()
        {
            int index = rand.Next(serverList.Count);//随机分配服务器
            return serverList[index];
        }
    }
}
