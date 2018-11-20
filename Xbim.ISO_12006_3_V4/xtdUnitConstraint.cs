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
    /// Readonly interface for xtdUnitConstraint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdUnitConstraint : IxtdConstraint
	{
		IxtdUnit @ConstraintUnit { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdUnitConstraint", 3)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdUnitConstraint : xtdConstraint, IInstantiableEntity, IxtdUnitConstraint, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@xtdUnitConstraint>
	{
		#region IxtdUnitConstraint explicit implementation
		IxtdUnit IxtdUnitConstraint.ConstraintUnit { 
 
 
			get { return @ConstraintUnit; } 
			set { ConstraintUnit = value as xtdUnit;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdUnitConstraint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private xtdUnit _constraintUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public xtdUnit @ConstraintUnit 
		{ 
			get 
			{
				if(_activated) return _constraintUnit;
				Activate();
				return _constraintUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _constraintUnit = v, _constraintUnit, value,  "ConstraintUnit", 6);
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
					_constraintUnit = (xtdUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdUnitConstraint other)
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
				if (@ConstraintUnit != null)
					yield return @ConstraintUnit;
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