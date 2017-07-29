using DependencyInjectionDemo.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Interfacer
{
    /// <summary>
    /// 定义需要注入ITimeProvider的类型
    /// </summary>
    interface IObjectWithTimeProvider
    {
        ITimeProvider TimeProvider { get; set; }
    }

    /// <summary>
    /// 通过接口方式注入
    /// </summary>
    class Client : IObjectWithTimeProvider
    {
        private ITimeProvider timeProvider;

        /// <summary>
        /// IObjectWithTimeProvider Members
        /// </summary>
        public ITimeProvider TimeProvider
        {
            get { return this.timeProvider; }
            set { this.timeProvider = value; }
        }
    }

    class InterfacerInjectionTest
    {
        public static void Test()
        {
            ITimeProvider timeProvider = (new Assembler()).Create<ITimeProvider>();
            IObjectWithTimeProvider objectWithTimeProvider = new Client();
            objectWithTimeProvider.TimeProvider = timeProvider; // 通过接口方式注入
        }
    }
}
