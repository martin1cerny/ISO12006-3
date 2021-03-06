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
    /// Readonly interface for xtdMeasureConstraint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdMeasureConstraint : IxtdConstraint
	{
		xtdConstraintTypeEnum @ConstraintType { get;  set; }
		IItemSet<IxtdValueType> @ConstraintValues { get; }
		IxtdUnit @ValuesUnit { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdMeasureConstraint", 2)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdMeasureConstraint : xtdConstraint, IInstantiableEntity, IxtdMeasureConstraint, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@xtdMeasureConstraint>
	{
		#region IxtdMeasureConstraint explicit implementation
		xtdConstraintTypeEnum IxtdMeasureConstraint.ConstraintType { 
 
			get { return @ConstraintType; } 
			set { ConstraintType = value;}
		}	
		IItemSet<IxtdValueType> IxtdMeasureConstraint.ConstraintValues { 
			get { return new Common.Collections.ProxyItemSet<xtdValueType, IxtdValueType>( @ConstraintValues); } 
		}	
		IxtdUnit IxtdMeasureConstraint.ValuesUnit { 
 
 
			get { return @ValuesUnit; } 
			set { ValuesUnit = value as xtdUnit;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdMeasureConstraint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_constraintValues = new ItemSet<xtdValueType>( this, 0,  7);
		}

		#region Explicit attribute fields
		private xtdConstraintTypeEnum _constraintType;
		private readonly ItemSet<xtdValueType> _constraintValues;
		private xtdUnit _valuesUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 6)]
		public xtdConstraintTypeEnum @ConstraintType 
		{ 
			get 
			{
				if(_activated) return _constraintType;
				Activate();
				return _constraintType;
			} 
			set
			{
				SetValue( v =>  _constraintType = v, _constraintType, value,  "ConstraintType", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 7)]
		public IItemSet<xtdValueType> @ConstraintValues 
		{ 
			get 
			{
				if(_activated) return _constraintValues;
				Activate();
				return _constraintValues;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public xtdUnit @ValuesUnit 
		{ 
			get 
			{
				if(_activated) return _valuesUnit;
				Activate();
				return _valuesUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _valuesUnit = v, _valuesUnit, value,  "ValuesUnit", 8);
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
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
                    _constraintType = (xtdConstraintTypeEnum) System.Enum.Parse(typeof (xtdConstraintTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_constraintValues.InternalAdd((xtdValueType)value.EntityVal);
					return;
				case 7: 
					_valuesUnit = (xtdUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdMeasureConstraint other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Descriptions)
					yield return entity;
				foreach(var entity in @Names)
					yield return entity;
				if (@ValuesUnit != null)
					yield return @ValuesUnit;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Descriptions)
					yield return entity;
				foreach(var entity in @Names)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}