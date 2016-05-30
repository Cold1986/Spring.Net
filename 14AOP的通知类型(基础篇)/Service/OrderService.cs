using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP的通知类型
{
    public class OrderService : IOrderService
    {
        /// <summary>
        /// 拦截该方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object Save(object id)
        {
            //throw new Exception("由于XXX原因保存出错");  
            return "保存：" + id.ToString();
        }
    }
}
