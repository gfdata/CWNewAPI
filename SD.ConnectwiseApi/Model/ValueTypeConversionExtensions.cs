using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi
{
    public static class ValueTypeConversionExtensions
    {
        public static int? ToNullableInt32(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return new int?();
            int output;
            if (int.TryParse(value, out output))
            {
                return output;
            }
            return new int?();
        }

        public static int ToInt32(this string value)
        {
            int output;
            int.TryParse(value, out output);
            return output;
        }

        public static decimal ToDecimal(this string value)
        {
            decimal output;
            decimal.TryParse(value, out output);
            return output;
        }

        public static DateTime? ToNullableDateTime(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return new DateTime?();
            DateTime output;
            if (DateTime.TryParse(value, out output))
            {
                return output;
            }
            return new DateTime?();
            
        }
    }
}
