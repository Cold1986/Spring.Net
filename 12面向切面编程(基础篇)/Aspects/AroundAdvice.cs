using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;

namespace 面向切面编程
{
    public class AroundAdvice : IMethodInterceptor
    {
        //权限系统类(可外部注入)
        private ISecurityManager manager = new SecurityManager();

        public object Invoke(IMethodInvocation invocation)
        {
            //拦截Save方法
            if (invocation.Method.Name == "Save")
            {
                ICompanyManager target = (ICompanyManager)invocation.Target;

                return manager.IsPass(target.UserName) ? invocation.Proceed() : null;
            }
            else
            {
                return invocation.Proceed();
            }
        }
    }
}
