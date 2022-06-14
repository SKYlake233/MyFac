using AbstractFactory.product.Fruit;
using AbstractFactory.product.Juice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class AFactory : Factory
    {

        //是否需要通过AppleFactory简介创建一个对象？
        //不需要，相当于将两个工厂合二为一   ，原本工厂只有一个方法，只产生对应的对象，只需要把产生对应对象的逻辑填写进去即可
        //抽象工厂的特点：
        //两个工厂在生产相同种类的产品，且流程相同，类似于一个苹果生产厂生产苹果和苹果汁
        //    类似于一个家族 => 大家族，上下之间是存在关联的
        //    另一个香蕉生产厂生产香蕉和香蕉汁
        public override Fruit createFruit()
        {
            return new Apple();
        }

        public override Juice createJuice()
        {
            return new AppleJuice();
        }
    }
}
