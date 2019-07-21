using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public sealed class SingletonLock
    {
        private SingletonLock()
        {
        }

        private static readonly object syncObj = new object();

        private static SingletonLock instance = null;
        public static SingletonLock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncObj)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonLock();
                        }
                    }

                }
                return instance;
            }
        }
    }

    public sealed class SingletonStatic
    {
        // 使用静态构造函数
        private SingletonStatic()
        {
        }
        public static SingletonStatic Instance { get; } = new SingletonStatic();
        // 以上代码等同于
        /*
        private static readonly SingletonStatic instance = new SingletonStatic();
        public static SingletonStatic Instance
        {
            get
            {
                return instance;
            }
        }
        */
    }

    public sealed class SingletonOnDemand
    {
        // 实现按需创建实例
        SingletonOnDemand()
        {
        }

        public static SingletonOnDemand Instance
        {
            get
            {
                return Nested.instance;
            }

        }

        // 利用私有嵌套类型的特性，做到只有真正需要的时候才会创建实例，提高空间使用效率
        class Nested
        {
            static Nested()
            {
            }
            internal static readonly SingletonOnDemand instance = new SingletonOnDemand();
        }
    }


    public class SingletonMain
    {
        public static void SingleMain()
        {
            var instanceLock = SingletonLock.Instance;

            var instanceStaic = SingletonStatic.Instance;

            var instanceOnDemand = SingletonOnDemand.Instance;
        }
    }
}
