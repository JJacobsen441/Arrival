using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrival._Statics
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> value)
        {
            return value == null || value.Count() == 0;
        }

        public static bool IsNull<T>(this T value)
        {
            return value == null;
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return value == null || value.Length == 0;
        }
    }
}