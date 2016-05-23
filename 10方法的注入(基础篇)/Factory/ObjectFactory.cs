using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的注入
{
    //注意，可以直接在配置中定义这个类的对象
    public abstract class ObjectFactory
    {
        //或者可以是一个虚方法	
        public abstract PersonDao CreatePersonDao();
    }
}
