using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 打造简易的依赖注入框架
{
    public class PersonDao
    {
        private int intProp;

        public PersonDao(int intProp)
        {
            this.intProp = intProp;
        }

        public Person Entity { get; set; }

        public override string ToString()
        {
            return "构造函数参数intProp为：" + this.intProp;
        }
    }
}
