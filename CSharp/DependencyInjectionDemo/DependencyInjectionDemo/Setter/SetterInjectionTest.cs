using DependencyInjectionDemo.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Setter
{
    /// <summary>
    /// 通过Setter实现注入
    /// </summary>
    class Client
    {
        private ITimeProvider timeProvider;

        public ITimeProvider TimeProvider
        {
            get { return this.timeProvider; }   // getter本身和Setter方式实现注入没有关系
            set { this.timeProvider = value; }
        }
    }

    class SetterInjectionTest
    {
        public static void Test()
        {
            ITimeProvider timeProvider = (new Assembler()).Create<ITimeProvider>();
            Client client = new Client();
            client.TimeProvider = timeProvider; // 通过Setter实现注入
        }
    }
}
