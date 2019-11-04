using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class GenericDelegate<T>
    {
        public delegate T1 Foo<T1>();
        public Foo<T> _delegate1;
    }
}
