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
    /// Readonly interface for xtdRelAssignsPropertyWithValues
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdRelAssignsPropertyWithValues : IxtdRelationship
	{
		IxtdProperty @RelatedProperty { get;  set; }
		IxtdObject @RelatingObject { get;  set; }
		IItemSet<IxtdValue> @RelatedValues { get; }
		IxtdUnit @RelatedUnit { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdRelAssignsPropertyWithValues", 36)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdRelAssignsPropertyWithValues : xtdRelationship, IInstantiableEntity, IxtdRelAssignsPropertyWithValues, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@xtdRelAssignsPropertyWithValues>
	{
		#region IxtdRelAssignsPropertyWithValues explicit implementation
		IxtdProperty IxtdRelAssignsPropertyWithValues.RelatedProperty { 
 
 
			get { return @RelatedProperty; } 
			set { RelatedProperty = value as xtdProperty;}
		}	
		IxtdObject IxtdRelAssignsPropertyWithValues.RelatingObject { 
 
 
			get { return @RelatingObject; } 
			set { RelatingObject = value as xtdObject;}
		}	
		IItemSet<IxtdValue> IxtdRelAssignsPropertyWithValues.RelatedValues { 
			get { return new Common.Collections.ProxyItemSet<xtdValue, IxtdValue>( @RelatedValues); } 
		}	
		IxtdUnit IxtdRelAssignsPropertyWithValues.RelatedUnit { 
 
 
			get { return @RelatedUnit; } 
			set { RelatedUnit = value as xtdUnit;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdRelAssignsPropertyWithValues(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedValues = new ItemSet<xtdValue>( this, 0,  9);
		}

		#region Explicit attribute fields
		private xtdProperty _relatedProperty;
		private xtdObject _relatingObject;
		private readonly ItemSet<xtdValue> _relatedValues;
		private xtdUnit _relatedUnit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public xtdProperty @RelatedProperty 
		{ 
			get 
			{
				if(_activated) return _relatedProperty;
				Activate();
				return _relatedProperty;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedProperty = v, _relatedProperty, value,  "RelatedProperty", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public xtdObject @RelatingObject 
		{ 
			get 
			{
				if(_activated) return _relatingObject;
				Activate();
				return _relatingObject;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingObject = v, _relatingObject, value,  "RelatingObject", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 9)]
		public IItemSet<xtdValue> @RelatedValues 
		{ 
			get 
			{
				if(_activated) return _relatedValues;
				Activate();
				return _relatedValues;
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 10)]
		public xtdUnit @RelatedUnit 
		{ 
			get 
			{
				if(_activated) return _relatedUnit;
				Activate();
				return _relatedUnit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedUnit = v, _relatedUnit, value,  "RelatedUnit", 10);
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
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_relatedProperty = (xtdProperty)(value.EntityVal);
					return;
				case 7: 
					_relatingObject = (xtdObject)(value.EntityVal);
					return;
				case 8: 
					_relatedValues.InternalAdd((xtdValue)value.EntityVal);
					return;
				case 9: 
					_relatedUnit = (xtdUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdRelAssignsPropertyWithValues other)
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
				if (@ViewSelector != null)
					yield return @ViewSelector;
				if (@RelatedProperty != null)
					yield return @RelatedProperty;
				if (@RelatingObject != null)
					yield return @RelatingObject;
				foreach(var entity in @RelatedValues)
					yield return entity;
				if (@RelatedUnit != null)
					yield return @RelatedUnit;
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