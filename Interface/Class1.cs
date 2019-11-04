using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Class1 : IsomeInterface, IComparable
    {
        int _someValue = 0;

        public double Prop1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CompareTo(object obj)
        {
            if (obj == null) return 2;

            Class1 inClass1 = obj as Class1;
            if (_someValue == inClass1._someValue)
            {
                return 0;

            }
            else
            {
                if (_someValue >= inClass1._someValue)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public int Method()
        {
            throw new NotImplementedException();
        }

        int Method2(int a, int b = 10)
        {
            return a + b;
        }
    }
}
