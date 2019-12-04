using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace WFA_DECLARE
{
     public static class Extensions
    {
        public static bool IsNullableType(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
        public static bool IsNullOrEmpty(this object data)
        {
            return string.IsNullOrEmpty(Convert.ToString(data));
        }
        public static int[] FindAllIndexof<T>(this IEnumerable<T> values, T val)
        {
            return values.Select((b, i) => object.Equals(b, val) ? i : -1).Where(i => i != -1).ToArray();
        }
    }
}
