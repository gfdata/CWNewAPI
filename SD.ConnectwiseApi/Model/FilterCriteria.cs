using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi.Model
{
    public sealed class FilterCriteria<T>
    {
        public FilterCriteria()
        {
            this.Operation = FilterOperation.Equal;
            ValueType = typeof(string);
        }
        public T TargetField { get; set; }

        public string Operation { get; set; }

        public string Value { get; set; }

        public Type ValueType { get; set; }

        public override string ToString()
        {
            var typename = ValueType.ToString();
            var formattedValue = string.Empty;
            switch (typename)
            {
                case "System.Int32":
                    formattedValue = string.Format("{0}", this.Value);
                    throw new NotImplementedException();
                case "System.Boolean":
                    formattedValue = string.Format("{0}", this.Value);
                    throw new NotImplementedException();
                case "System.DateTime":
                    formattedValue = string.Format("'{0}'", this.Value);
                    throw new NotImplementedException();
                default:
                    formattedValue = string.Format("'{0}'", this.Value);
                    break;
            }

            var expr = string.Format("{0} {1} {2}", this.TargetField, this.Operation, formattedValue);
            return expr;
        }
    }
}
