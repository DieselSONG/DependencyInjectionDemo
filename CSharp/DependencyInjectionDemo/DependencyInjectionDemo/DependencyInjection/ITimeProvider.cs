using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.DependencyInjection
{
    public interface ITimeProvider
    {
        DateTime CurrentDate { get; }
    }
}
