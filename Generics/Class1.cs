using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Class1<T> where T : class
    {


        public T _var1;
        public T GetTest() => _var1;

        public static string GetString<T1>(T1 obj)
        {
            return obj.ToString();
        }

    }
}
