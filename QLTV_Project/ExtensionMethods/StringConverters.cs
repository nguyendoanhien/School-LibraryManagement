using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class StringConverters
    {
        public static Int32 ToInt32(this object obj)
        {
            return Convert.ToInt32(obj);
        }
    }
}
