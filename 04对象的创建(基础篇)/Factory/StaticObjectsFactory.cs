using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对象的创建
{
    public class StaticObjectsFactory
    {
        public static PersonDao CreateInstanceTest()
        {
            return new PersonDao();
        }

        public static PersonDao.Person CreateInstance()
        {
            return new PersonDao.Person();
        }
    }
}
