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
    /// Readonly interface for xtdRelAssignsConstraint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdRelAssignsConstraint : IxtdRelationship
	{
		IxtdProperty @RelatingProperty { get;  set; }
		IxtdConstraint @RelatedConstraint { get;  set; }
		IxtdName @MethodOfInterpretation { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdRelAssignsConstraint", 6)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdRelAssignsConstraint : xtdRelationship, IInstantiableEntity, IxtdRelAssignsConstraint, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@xtdRelAssignsConstraint>
	{
		#region IxtdRelAssignsConstraint explicit implementation
		IxtdProperty IxtdRelAssignsConstraint.RelatingProperty { 
 
 
			get { return @RelatingProperty; } 
			set { RelatingProperty = value as xtdProperty;}
		}	
		IxtdConstraint IxtdRelAssignsConstraint.RelatedConstraint { 
 
 
			get { return @RelatedConstraint; } 
			set { RelatedConstraint = value as xtdConstraint;}
		}	
		IxtdName IxtdRelAssignsConstraint.MethodOfInterpretation { 
 
 
			get { return @MethodOfInterpretation; } 
			set { MethodOfInterpretation = value as xtdName;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdRelAssignsConstraint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private xtdProperty _relatingProperty;
		private xtdConstraint _relatedConstraint;
		private xtdName _methodOfInterpretation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public xtdProperty @RelatingProperty 
		{ 
			get 
			{
				if(_activated) return _relatingProperty;
				Activate();
				return _relatingProperty;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingProperty = v, _relatingProperty, value,  "RelatingProperty", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public xtdConstraint @RelatedConstraint 
		{ 
			get 
			{
				if(_activated) return _relatedConstraint;
				Activate();
				return _relatedConstraint;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedConstraint = v, _relatedConstraint, value,  "RelatedConstraint", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 9)]
		public xtdName @MethodOfInterpretation 
		{ 
			get 
			{
				if(_activated) return _methodOfInterpretation;
				Activate();
				return _methodOfInterpretation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _methodOfInterpretation = v, _methodOfInterpretation, value,  "MethodOfInterpretation", 9);
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
					_relatingProperty = (xtdProperty)(value.EntityVal);
					return;
				case 7: 
					_relatedConstraint = (xtdConstraint)(value.EntityVal);
					return;
				case 8: 
					_methodOfInterpretation = (xtdName)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdRelAssignsConstraint other)
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
				if (@RelatingProperty != null)
					yield return @RelatingProperty;
				if (@RelatedConstraint != null)
					yield return @RelatedConstraint;
				if (@MethodOfInterpretation != null)
					yield return @MethodOfInterpretation;
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