using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对象的创建
{
    public class PersonDao
    {
        public class Person
        {
            public override string ToString()
            {
                return "我是嵌套类Person";
            }
        }

        public override string ToString()
        {
            return "我是PersonDao";
        }
    }
}
