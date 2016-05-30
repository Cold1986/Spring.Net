/**************************
 * 
 * 前置通知(before advise)：是在IMethodInterceptor.Proceed()方法调用前的通知。
 * 继承自IMethodBeforeAdvice接口。
 * 
 * **********************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;

namespace AOP的通知类型
{
    /// <summary>
    /// 前置通知
    /// </summary>
    public class BeforeAdvise : IMethodBeforeAdvice
    {
        public void Before(System.Reflection.MethodInfo method, object[] args, object target)
        {
            Console.Out.WriteLine(string.Format("前置通知：调用的方法名：'{0}'", method.Name));
            Console.Out.WriteLine(string.Format("前置通知：目标：'{0}'", target));
            Console.Out.WriteLine(string.Format("前置通知：参数为："));

            if (args != null)
            {
                foreach (object arg in args)
                {
                    Console.Out.WriteLine("\t: " + arg);
                }
            }

            Console.WriteLine();
        }
    }
}
