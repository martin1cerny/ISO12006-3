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
    /// Readonly interface for xtdRelAssignsProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdRelAssignsProperties : IxtdRelationship
	{
		IItemSet<IxtdProperty> @RelatedProperties { get; }
		IxtdObject @RelatingObject { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdRelAssignsProperties", 35)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdRelAssignsProperties : xtdRelationship, IInstantiableEntity, IxtdRelAssignsProperties, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@xtdRelAssignsProperties>
	{
		#region IxtdRelAssignsProperties explicit implementation
		IItemSet<IxtdProperty> IxtdRelAssignsProperties.RelatedProperties { 
			get { return new Common.Collections.ProxyItemSet<xtdProperty, IxtdProperty>( @RelatedProperties); } 
		}	
		IxtdObject IxtdRelAssignsProperties.RelatingObject { 
 
 
			get { return @RelatingObject; } 
			set { RelatingObject = value as xtdObject;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdRelAssignsProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedProperties = new ItemSet<xtdProperty>( this, 0,  7);
		}

		#region Explicit attribute fields
		private readonly ItemSet<xtdProperty> _relatedProperties;
		private xtdObject _relatingObject;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 7)]
		public IItemSet<xtdProperty> @RelatedProperties 
		{ 
			get 
			{
				if(_activated) return _relatedProperties;
				Activate();
				return _relatedProperties;
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
					_relatedProperties.InternalAdd((xtdProperty)value.EntityVal);
					return;
				case 7: 
					_relatingObject = (xtdObject)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdRelAssignsProperties other)
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
				foreach(var entity in @RelatedProperties)
					yield return entity;
				if (@RelatingObject != null)
					yield return @RelatingObject;
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