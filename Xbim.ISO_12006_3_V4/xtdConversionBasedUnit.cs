// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.ISO_12006_3_V4.Interfaces;
using Xbim.ISO_12006_3_V4;
//## Custom using statements
//##

namespace Xbim.ISO_12006_3_V4.Interfaces
{
	/// <summary>
    /// Readonly interface for xtdConversionBasedUnit
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdConversionBasedUnit : IxtdNamedUnit
	{
		xtdLabel @Name { get;  set; }
		xtdNumber @ConversionFactor { get;  set; }
		IxtdUnitDefinition @BaseUnit { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdConversionBasedUnit", 13)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdConversionBasedUnit : xtdNamedUnit, IInstantiableEntity, IxtdConversionBasedUnit, IContainsEntityReferences, IEquatable<@xtdConversionBasedUnit>
	{
		#region IxtdConversionBasedUnit explicit implementation
		xtdLabel IxtdConversionBasedUnit.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		xtdNumber IxtdConversionBasedUnit.ConversionFactor { 
 
			get { return @ConversionFactor; } 
			set { ConversionFactor = value;}
		}	
		IxtdUnitDefinition IxtdConversionBasedUnit.BaseUnit { 
 
 
			get { return @BaseUnit; } 
			set { BaseUnit = value as xtdUnitDefinition;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdConversionBasedUnit(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private xtdLabel _name;
		private xtdNumber _conversionFactor;
		private xtdUnitDefinition _baseUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public xtdLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public xtdNumber @ConversionFactor 
		{ 
			get 
			{
				if(_activated) return _conversionFactor;
				Activate();
				return _conversionFactor;
			} 
			set
			{
				SetValue( v =>  _conversionFactor = v, _conversionFactor, value,  "ConversionFactor", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public xtdUnitDefinition @BaseUnit 
		{ 
			get 
			{
				if(_activated) return _baseUnit;
				Activate();
				return _baseUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _baseUnit = v, _baseUnit, value,  "BaseUnit", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_name = value.StringVal;
					return;
				case 3: 
					_conversionFactor = value.NumberVal;
					return;
				case 4: 
					_baseUnit = (xtdUnitDefinition)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdConversionBasedUnit other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Dimensions != null)
					yield return @Dimensions;
				if (@BaseUnit != null)
					yield return @BaseUnit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}