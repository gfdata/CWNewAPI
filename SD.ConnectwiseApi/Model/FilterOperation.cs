using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi.Model
{
    public static class FilterOperation
    {
        public const string Equal = " = ";
        public const string NotEqual = " != ";
        public const string LessThan = " < ";
        public const string LessThanOrEqual = " <= ";
        public const string GreaterThan = " > ";
        public const string GreaterThanOrEqual = " >= ";
        public const string Contains = " contains ";
        public const string Like = " like ";
    }
}
