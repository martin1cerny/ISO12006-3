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
    /// Readonly interface for xtdRelAssignsValues
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdRelAssignsValues : IxtdRelationship
	{
		IxtdMeasureWithUnit @RelatingMeasure { get;  set; }
		IItemSet<IxtdValue> @RelatedValues { get; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdRelAssignsValues", 38)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdRelAssignsValues : xtdRelationship, IInstantiableEntity, IxtdRelAssignsValues, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@xtdRelAssignsValues>
	{
		#region IxtdRelAssignsValues explicit implementation
		IxtdMeasureWithUnit IxtdRelAssignsValues.RelatingMeasure { 
 
 
			get { return @RelatingMeasure; } 
			set { RelatingMeasure = value as xtdMeasureWithUnit;}
		}	
		IItemSet<IxtdValue> IxtdRelAssignsValues.RelatedValues { 
			get { return new Common.Collections.ProxyItemSet<xtdValue, IxtdValue>( @RelatedValues); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdRelAssignsValues(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedValues = new ItemSet<xtdValue>( this, 0,  8);
		}

		#region Explicit attribute fields
		private xtdMeasureWithUnit _relatingMeasure;
		private readonly ItemSet<xtdValue> _relatedValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public xtdMeasureWithUnit @RelatingMeasure 
		{ 
			get 
			{
				if(_activated) return _relatingMeasure;
				Activate();
				return _relatingMeasure;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingMeasure = v, _relatingMeasure, value,  "RelatingMeasure", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 8)]
		public IItemSet<xtdValue> @RelatedValues 
		{ 
			get 
			{
				if(_activated) return _relatedValues;
				Activate();
				return _relatedValues;
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
					_relatingMeasure = (xtdMeasureWithUnit)(value.EntityVal);
					return;
				case 7: 
					_relatedValues.InternalAdd((xtdValue)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdRelAssignsValues other)
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
				if (@RelatingMeasure != null)
					yield return @RelatingMeasure;
				foreach(var entity in @RelatedValues)
					yield return entity;
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