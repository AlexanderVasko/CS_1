using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Partial
{
    abstract partial class Class2 : Class1
    {
        public int _i1 = 19;
        public Class2(int i) : base(i)
        {
            
        }

        public override abstract int AbstrMethod();
        //{
        //    return 100;
        //}

        public override int R => base.R + 10;

        public int Calc(int a, int b) => a + b + AbstrMethod();
    }
}
