using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Test1<T> : ITest1<T> where T : new()
    {
        public T GetTest1()
        {
            return new T();
        }
    }
}
