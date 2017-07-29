using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.DependencyInjection
{
    public class Assembler
    {
        /// <summary>
        /// 保存“类型名称/实体类型”对应关系的字典
        /// </summary>
        private static Dictionary<string, Type> dictionary = new Dictionary<string, Type>();

        // 实际的配置信息可以从外层机制获得,例如通过xml文件配置.
        static Assembler()
        {
            dictionary.Add("SystemTimeProvider", typeof(SystemTimeProvider));
            dictionary.Add("UtcNowTimeProvider", typeof(UtcNowTimeProvider));
        }

        static void RegisterType(string name,Type type)
        {
            if ((type == null) || dictionary.ContainsKey(name)) throw new NullReferenceException();
            dictionary.Add(name, type);
        }

        static void Remove(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new NullReferenceException();
            dictionary.Remove(name);
        }

        /// <summary>
        /// 根据程序需要的类型名称选择相应的实体类型，并返回类型实例
        /// </summary>
        public ITimeProvider Create(string type)
        {
            if ((type == null) || !dictionary.ContainsKey(type)) throw new NullReferenceException();
            Type targetType = dictionary[type];
            return (ITimeProvider)Activator.CreateInstance(targetType);
        }

    }
}
