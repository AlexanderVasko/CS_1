using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IsomeInterface
    {
        public double Prop1 { get; set; }

        static float StaticMethod() => 100;

        int Method();
    }
}
