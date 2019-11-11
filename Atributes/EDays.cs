using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    public enum Days
    {
        [EnumName(Name = "понеділок")]
        Monday,
        [EnumName("вівторок")]
        Tuesday,
        [EnumName("середа")]
        Wednesday,
        [EnumName("четвер")]
        Thursday,
        [EnumName("п'ятниця")]
        Friday,
        [EnumName("субота")]
        Saturday,
        [EnumName("неділя")]
        Sunday
    }
}
