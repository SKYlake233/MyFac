using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.product
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class  Fruit
    {
        /// <summary>
        /// 抽象方法  获取水果名称
        /// </summary>
        public abstract void get_name();
    }
}
