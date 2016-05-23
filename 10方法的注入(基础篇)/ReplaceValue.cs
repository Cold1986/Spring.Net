using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Spring.Objects.Factory.Support;

namespace 方法的注入
{
    //实现IMethodReplacer接口
    public class ReplaceValue : IMethodReplacer
    {
        public object Implement(object target, MethodInfo method, object[] arguments)
        {
            string value = (string)arguments[0];
            return "获取到：" + value;
        }
    }
}
