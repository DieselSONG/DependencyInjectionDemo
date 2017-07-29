using DependencyInjectionDemo.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Constructor
{
    /// <summary>
    /// 在构造函数中注入
    /// </summary>
    class Client
    {
        private ITimeProvider timeProvider;

        public Client(ITimeProvider timeProvider)
        {
            this.timeProvider = timeProvider;
        }
    }

    class ConstructorInjectionTest
    {
        public static void Test()
        {
            ITimeProvider timeProvider = (new Assembler()).Create<ITimeProvider>();
            Client client = new Client(timeProvider);   // 在构造函数中注入
        }
    }
}
