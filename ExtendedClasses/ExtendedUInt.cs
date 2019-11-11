using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendedClasses
{
    public static class ExtendedUInt
    {
        public static (ushort, ushort) HiLo(this uint i)
        //public static dynamic HiLo(this uint i)
        {            
            ushort Lo = (ushort)(i & 0xffff);
            ushort Hi = (ushort)(i >> 16);

            //(ushort, ushort) a = (Hi, Lo);
            return (Hi, Lo);

            //return new { Hi, Lo };
        }
    }
}
