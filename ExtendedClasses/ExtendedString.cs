using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedClasses
{
    public static class ExtendedString
    {
        public static string AddDateSignature(this string str)
        {
            return str + DateTime.Now.ToString();
        }
    }
}
