using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class DelegateClass
    {
        public delegate int Foo2();
        public event Foo2 fooEvent;

        public int Foo3()
        {
            
            return 10;
        }

    }
}
