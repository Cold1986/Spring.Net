using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP的概念
{
    public interface IOrderService
    {
        string UserName { get; set; }

        object Save(object id);
    }
}
