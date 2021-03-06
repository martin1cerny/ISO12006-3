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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.ISO_12006_3_V4.Interfaces;
using Xbim.ISO_12006_3_V4;
//## Custom using statements
//##

namespace Xbim.ISO_12006_3_V4.Interfaces
{
	/// <summary>
    /// Readonly interface for xtdExternalObject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdExternalObject : IPersistEntity
	{
		xtdLabel @ExternalIdentifier { get;  set; }
		xtdLabel? @ExternalSubIdentifier { get;  set; }
		IxtdExternalSchema @ExternalSchema { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdExternalObject", 70)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdExternalObject : PersistEntity, IInstantiableEntity, IxtdExternalObject, IContainsEntityReferences, IEquatable<@xtdExternalObject>
	{
		#region IxtdExternalObject explicit implementation
		xtdLabel IxtdExternalObject.ExternalIdentifier { 
 
			get { return @ExternalIdentifier; } 
			set { ExternalIdentifier = value;}
		}	
		xtdLabel? IxtdExternalObject.ExternalSubIdentifier { 
 
			get { return @ExternalSubIdentifier; } 
			set { ExternalSubIdentifier = value;}
		}	
		IxtdExternalSchema IxtdExternalObject.ExternalSchema { 
 
 
			get { return @ExternalSchema; } 
			set { ExternalSchema = value as xtdExternalSchema;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdExternalObject(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private xtdLabel _externalIdentifier;
		private xtdLabel? _externalSubIdentifier;
		private xtdExternalSchema _externalSchema;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public xtdLabel @ExternalIdentifier 
		{ 
			get 
			{
				if(_activated) return _externalIdentifier;
				Activate();
				return _externalIdentifier;
			} 
			set
			{
				SetValue( v =>  _externalIdentifier = v, _externalIdentifier, value,  "ExternalIdentifier", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public xtdLabel? @ExternalSubIdentifier 
		{ 
			get 
			{
				if(_activated) return _externalSubIdentifier;
				Activate();
				return _externalSubIdentifier;
			} 
			set
			{
				SetValue( v =>  _externalSubIdentifier = v, _externalSubIdentifier, value,  "ExternalSubIdentifier", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public xtdExternalSchema @ExternalSchema 
		{ 
			get 
			{
				if(_activated) return _externalSchema;
				Activate();
				return _externalSchema;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _externalSchema = v, _externalSchema, value,  "ExternalSchema", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_externalIdentifier = value.StringVal;
					return;
				case 1: 
					_externalSubIdentifier = value.StringVal;
					return;
				case 2: 
					_externalSchema = (xtdExternalSchema)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdExternalObject other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ExternalSchema != null)
					yield return @ExternalSchema;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}