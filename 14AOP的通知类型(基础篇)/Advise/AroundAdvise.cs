/*****************************
 * 
 * 拦截环绕通知(around advice)：
 * Spring.NET中最基本的通知类型是拦截环绕通知（interception around advice），即方法拦截器。
 * 拦截环绕通知继承IMethodInterceptor接口。
 * 注意其中IMethodInvocation.Proceed()方法的调用。
 * 该方法会依次调用拦截器链上的其它拦截器。
 * 大部分拦截器都需要调用这个方法并返回它的返回值。
 * 当然，也可以不调用Proceed方法，而返回一个其它值或抛出一个异常，但一般不太会这么做。
 * 
 * *************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;

namespace AOP的通知类型
{
    /// <summary>
    /// 环绕通知
    /// </summary>
    public class AroundAdvise : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            Console.Out.WriteLine(string.Format("环绕通知：调用的方法'{0}'", invocation.Method.Name));
            Console.WriteLine();

            object returnValue = null;

            try
            {
                returnValue = invocation.Proceed();
            }
            catch
            {
                Console.Out.WriteLine("环绕通知：发生异常");
                Console.WriteLine();
            }

            Console.Out.WriteLine(string.Format("环绕通知：返回值'{0}'",returnValue));

            return returnValue;
        }
    }
}
