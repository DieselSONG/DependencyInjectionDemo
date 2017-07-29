using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.DependencyInjection
{
    class GeographicLocationProvider : ILocationProvider
    {
        public string Location
        {
            get
            {
                return "中国广州";
            }
        }
    }
}
