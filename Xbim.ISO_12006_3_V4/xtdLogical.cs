// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdLogical", 52)]
	[DefinedType(typeof(bool?))]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct xtdLogical : xtdValueType, IExpressValueType, IExpressLogicalType, System.IEquatable<bool?>
	{ 
		private bool? _value;
        
		public object Value
        {
            get { return _value; }
        }

 
		bool? IExpressLogicalType.Value { get { return _value; } }

		public override string ToString()
        {
			if (_value == true)
                return "true";
            else if (_value == false)
                return "false";
            else
                return "unknown";
        }
        public xtdLogical(bool? val)
        {
            _value = val;
        }

		public xtdLogical(string val)
        {
			if (string.Compare(val, "true", System.StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(val, ".T.", System.StringComparison.OrdinalIgnoreCase) == 0)
                _value = true;
            else if (string.Compare(val, "false", System.StringComparison.OrdinalIgnoreCase) == 0)
                _value = false;
            else
                _value = null;
        }

        public static implicit operator xtdLogical(bool? value)
        {
            return new xtdLogical(value);
        }

        public static implicit operator bool?(xtdLogical obj)
        {
            return obj._value;

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return ((xtdLogical) obj)._value == _value;
        }

		public bool Equals(bool? other)
	    {
	        return this == other;
	    }

        public static bool operator ==(xtdLogical obj1, xtdLogical obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(xtdLogical obj1, xtdLogical obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
            _value = value.BooleanVal;
            
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(bool?);
			}
		}
		#endregion


	}
}
