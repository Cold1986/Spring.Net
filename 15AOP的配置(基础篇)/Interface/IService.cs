using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP的配置
{
    public interface IService
    {
        IList FindAll();

        void Save(object entity);
    }
}
