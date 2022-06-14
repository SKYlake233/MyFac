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
        //工厂方法所需参数
        ////创建所需工厂
        //public FruitFactory fruitFactory;
        //public JuiceFactory JuiceFactory;


        ///// <summary>
        ///// 构造函数，外部工厂使用
        ///// </summary>
        ///// <param name="fruitFactory"></param>
        ///// <param name="juiceFactory"></param>
        //public Store(FruitFactory fruitFactory, JuiceFactory juiceFactory)
        //{
        //    this.fruitFactory = fruitFactory;
        //    JuiceFactory = juiceFactory;
        //}

        ////生产水果
        //public Fruit createFruit()
        //{
        //    return fruitFactory.createFruit();
        //}

        ////生产果汁
        //public Juice createJuice()
        //{
        //    return JuiceFactory.createJucie();
        //}


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
