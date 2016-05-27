using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向切面编程
{
    public interface ISecurityManager
    {
        bool IsPass(string userName);
    }
}
