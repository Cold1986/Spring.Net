using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 依赖注入
{
    public static class ToolFactory
    {
        /// <summary>
        /// 工厂制造工具
        /// </summary>
        /// <returns></returns>
        public static ITool CreateTool()
        {
            return new Hoe();  // 制造锄头
        }
    }
}
