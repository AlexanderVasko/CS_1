using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Class2<T> where T : new()
    {
        private T _var1;

        Class2()
        {
            
        }

        public T Foo()
        {
            return new T();
        }
    }
}
