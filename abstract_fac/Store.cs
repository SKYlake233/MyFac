using AbstractFactory.Factory;
using AbstractFactory.product.Fruit;
using AbstractFactory.product.Juice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Store
    {
        //抽象工厂
        public Factory.Factory factory { get; set; }
        /// <summary>
        /// 构造函数  同工厂只需要一个
        /// </summary>
        /// <param name="factory"></param>
        public Store(Factory.Factory factory)
        {
            this.factory = factory;
        }
        /// <summary>
        /// 生产水果
        /// </summary>
        /// <returns></returns>
        public Fruit createFruit()
        {
            return factory.createFruit();
        }
        /// <summary>
        /// 生产果汁
        /// </summary>
        /// <returns></returns>
        public Juice createJuice()
        {
            return factory.createJuice();
        }
    }
}
