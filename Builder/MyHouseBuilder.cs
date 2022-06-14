using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 具体房屋的操作
    /// </summary>
    public class MyHouseBuilder : HouseBuilder
    {
        public override void BuildPart1()
        {
            Console.WriteLine("创建大门");
        }

        public override void BuildPart2()
        {
            Console.WriteLine("创建窗户");
        }

        public override void BuildPart3()
        {
            throw new NotImplementedException();
        }

        public override void BuildPart4()
        {
            throw new NotImplementedException();
        }

        public override void BuildPart5()
        {
            throw new NotImplementedException();
        }
    }
}
