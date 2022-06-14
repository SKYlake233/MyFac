using FactoryMethod.Factory;
using FactoryMethod.product;
using System;

namespace FactoryMethod
{
    class Program
    {
        public static void Main()
        {
            AppleFactory appleFactory = new AppleFactory();
            BananaFactory bananaFactory = new BananaFactory();

            Store store = new Store(appleFactory);

            //生产水果

            Fruit fruit = store.getFruit();
            fruit.get_name();



            store.fruitFactory = bananaFactory;
            fruit = store.getFruit();
            fruit.get_name();
        }
    }
}
