/**************************************
 * 
 * 后置通知(after returning advise)：是在IMethodInterceptor.Proceed()方法调用后的通知。
 * 继承自IAfterReturningAdvice接口。
 * 后置通知对切入点的执行没有影响，如果通知抛出异常，就会沿拦截器链向上抛出，从而中断拦截器链的继续执行。
 * 
 * ************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;

namespace AOP的通知类型
{
    /// <summary>
    /// 后置通知
    /// </summary>
    public class AfterReturningAdvise: IAfterReturningAdvice
    {
        public void AfterReturning(object returnValue, MethodInfo method, object[] args, object target)
        {
            Console.Out.WriteLine("后置通知：方法调用成功，方法名：" + method.Name);
            Console.Out.WriteLine("后置通知：目标为：" + target);
            Console.Out.WriteLine("后置通知：参数：");

            if (args != null)
            {
                foreach (object arg in args)
                {
                    Console.Out.WriteLine("\t: " + arg);
                }
            }
            Console.Out.WriteLine("后置通知：返回值是 : " + returnValue);

            Console.WriteLine();
        }
    }
}
