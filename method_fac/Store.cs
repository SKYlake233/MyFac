using FactoryMethod.Factory;
using FactoryMethod.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Store
    {
        /// <summary>
        /// 工厂指针   可以设置
        /// </summary>
        public FruitFactory fruitFactory { get; set; }

        public Fruit getFruit()
        {
            return fruitFactory.createFruit();
        }

        /// <summary>
        /// 构造时必须有具体的对象  ，  否则会产生构造失败
        /// </summary>
        /// <param name="fruitFactory"></param>
        public Store(FruitFactory fruitFactory)
        {
            this.fruitFactory = fruitFactory;
        }
    }
}
