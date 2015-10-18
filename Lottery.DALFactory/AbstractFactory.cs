using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lottery.IDAL;
using System.Reflection;
using System.Configuration;

namespace Lottery.DALFactory
{
    public partial class AbstractFactory
    {
        public static object CreateInstance(string DalAssemblyPath, string fullClassName)
        {
            var assembly = Assembly.Load(DalAssemblyPath);//加载程序集
            return assembly.CreateInstance(fullClassName);
        }
    }
}
