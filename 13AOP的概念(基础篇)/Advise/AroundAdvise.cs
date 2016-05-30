using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;

namespace AOP的概念
{
    public class AroundAdvise : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            IOrderService target = (IOrderService)invocation.Target;
            SecurityService manager = new SecurityService();
            if (manager.IsPass(target.UserName))
            {
                return invocation.Proceed();
            }
            else
            {
                return null;
            }
        }
    }
}
