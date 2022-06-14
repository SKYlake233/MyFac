using AbstractFactory.product.Fruit;
using AbstractFactory.product.Juice;

namespace AbstractFactory.Factory
{
    /// <summary>
    /// 榨汁工厂  含有两个创建的对象 => 创建水果 => 创建果汁
    /// </summary>
    public abstract class Factory
    {
        //相对于工厂方法多一个方法
        public abstract Fruit createFruit();
        public abstract Juice createJuice();
    }
}
