using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对象的创建
{
    public class InstanceObjectsFactoryTest
    {
        public PersonDao CreateInstanceMethod()
        {
            return new PersonDao();
        }
    }
}
