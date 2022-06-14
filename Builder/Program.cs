using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 寻找变化中稳定的部分
             * First ->   House基类    MyHouse子类  
             * Second->   HouseBuilder基类   MyHouseBuilder子类（Builder中含有House对象   =>  父类的get对象获取 【新思路：访问父类元素，使用父类的getResult 访问子类  -> 低级构建化对象】）
             * Third->    为什么要有HouseDirector类   因为创建的过程都是相同的，相同的代码写五份（可以统一抽象出来进行处理，最后Director进行创建即可）
             */
            HouseBuilder houseBuilder = new MyHouseBuilder();
            HouseDirector houseDirector = new HouseDirector(houseBuilder);
            House house = houseDirector.init();
        }
    }
}
