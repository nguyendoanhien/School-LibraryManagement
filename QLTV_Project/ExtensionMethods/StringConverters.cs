#region
using System;
#endregion

namespace ExtensionMethods
{
    public static class StringConverters
    {
        public static int ToInt32(this object obj)
        {
            return Convert.ToInt32(obj);
        }
    }
}