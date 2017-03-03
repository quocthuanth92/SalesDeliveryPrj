using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class ExtensionMethod
    {
        private static CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        #region To VND
        public static string ToCurrency(this double value)
        {
            return value.ToString("C", cul);
        }

        public static string ToCurrency(this int value)
        {
            return value.ToString("C", cul);
        }
        #endregion
    }
}
