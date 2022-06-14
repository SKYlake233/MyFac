using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 房屋创建者
    /// </summary>
    public abstract class HouseBuilder
    {
        House house;

        public House GetResult()
        {
            return house;
        }
        //对应的具体是变化的
        public abstract void BuildPart1();
        public abstract void BuildPart2();
        public abstract void BuildPart3();
        public abstract void BuildPart4();
        public abstract void BuildPart5();
    }
}
