using System;
using System.Collections.Generic;
using System.Text;

namespace Struct_int128
{
    [Flags]
    
    public enum eByteFlags : byte
    {
        first = 1,
        second = 1 << 1,
        third = 1 << 2,
        fourth = 1 << 3,
        fifth = 1 << 4,
        sixth = 1 << 5,
        seventh = 1 << 6,
        eighth = 1 << 7,
        fifthsecond = fifth | second
    }
}
