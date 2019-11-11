using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Attributes
{
    public static class EnumExtension
    {
        public static string Description (this Enum value)
        {
            var enumMember = value.GetType().GetMember(value.ToString()).FirstOrDefault();
            var descriptionAttribute =
                enumMember == null
                ? default(EnumNameAttribute)
                : enumMember.GetCustomAttribute(typeof(EnumNameAttribute)) as EnumNameAttribute;
            return
                descriptionAttribute == null ? string.Empty : descriptionAttribute.Name;
        }
    }
}
