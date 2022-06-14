using AbstractFactory.Factory;
using AbstractFactory.product.Fruit;
using AbstractFactory.product.Juice;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.直接new  Fruit 和 juice
            ////2.工厂方法创建
            //FruitFactory appleFactory = new AppleFactory();
            //JuiceFactory juiceFactory = new AppleJuiceFactory();
            //Store store = new Store(appleFactory, juiceFactory);
            //Fruit fruit = store.createFruit();
            //Juice juice = store.createJuice();
            //fruit.get_name();
            //juice.get_name();
            ////3.由抽象工厂创建
            ///

            Factory.Factory factory = new AFactory();
            Factory.Factory factory1 = new BFactory();
            Store store = new Store(factory);
            Fruit fruit = store.createFruit();
            Juice juice = store.createJuice();
            fruit.get_name();
            juice.get_name();
            store.factory = factory1;
            fruit = store.createFruit();
            juice = store.createJuice();
            store.createJuice();
            fruit.get_name();
            juice.get_name();
        }
    }
}
