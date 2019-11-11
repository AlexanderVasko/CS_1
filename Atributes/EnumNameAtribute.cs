using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class EnumNameAttribute : Attribute
    {
        public string Name { get; set; }
        public EnumNameAttribute(string vari)
        {
            Name = vari;
        }
        public EnumNameAttribute()
        {

        }
    }
}
