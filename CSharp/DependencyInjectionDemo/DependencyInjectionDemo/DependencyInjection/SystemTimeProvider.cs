using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.DependencyInjection
{
    public class SystemTimeProvider : ITimeProvider
    {
        public DateTime CurrentDate { get { return DateTime.Now; } }
    }

    public class UtcNowTimeProvider : ITimeProvider
    {
        public DateTime CurrentDate { get { return DateTime.UtcNow; } }
    }

}
