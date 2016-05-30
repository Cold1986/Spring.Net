/*****************************
 * 
 * 异常通知(throws advise)：是在IMethodInterceptor.Proceed()方法调用时发生异常的通知。
 * 继承自IthrowsAdvice接口。
 * IthrowsAdvice接口没有定义任何方法：它是一个标识接口
 * （按：之所以用标识接口，原因有二：
 * 1、在通知方法中，只有最后一个参数是必须的。如果声明为接口的方法，参数列表就被固定了。
 * 2、如果第一个原因可以用重载的接口方法解决，那么这个原因就是使用标识接口的充分原因了：实现此接口的类必须声明一或多个通知方法，接口方法做不到这一点），用以表明实现它的类声明了一或多个强类型的异常通知方法。 
 * 
 * ************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;

namespace AOP的通知类型
{
    /// <summary>
    /// 异常通知
    /// </summary>
    public class ThrowsAdvise : IThrowsAdvice
    {
        public void AfterThrowing(Exception ex)
        {
            string errorMsg = string.Format("异常通知： 方法抛出的异常 : {0}", ex.Message);
            Console.Error.WriteLine(errorMsg);

            Console.WriteLine();
        }
    }
}
