using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP的概念
{
    public class SecurityService
    {
        public bool IsPass(string userName)
        {
            return userName == "admin";
        }
    }
}
