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
using Xbim.ISO_12006_3_V3.Interfaces;
using Xbim.ISO_12006_3_V3;
//## Custom using statements
//##

namespace Xbim.ISO_12006_3_V3.Interfaces
{
	/// <summary>
    /// Readonly interface for xtdRelCollects
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdRelCollects : IxtdRelationship
	{
		IItemSet<IxtdRoot> @RelatedThings { get; }
		IxtdCollection @RelatingCollection { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V3
{
	[ExpressType("xtdRelCollects", 30)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdRelCollects : xtdRelationship, IInstantiableEntity, IxtdRelCollects, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@xtdRelCollects>
	{
		#region IxtdRelCollects explicit implementation
		IItemSet<IxtdRoot> IxtdRelCollects.RelatedThings { 
			get { return new Common.Collections.ProxyItemSet<xtdRoot, IxtdRoot>( @RelatedThings); } 
		}	
		IxtdCollection IxtdRelCollects.RelatingCollection { 
 
 
			get { return @RelatingCollection; } 
			set { RelatingCollection = value as xtdCollection;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdRelCollects(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedThings = new ItemSet<xtdRoot>( this, 0,  7);
		}

		#region Explicit attribute fields
		private readonly ItemSet<xtdRoot> _relatedThings;
		private xtdCollection _relatingCollection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 7)]
		public IItemSet<xtdRoot> @RelatedThings 
		{ 
			get 
			{
				if(_activated) return _relatedThings;
				Activate();
				return _relatedThings;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public xtdCollection @RelatingCollection 
		{ 
			get 
			{
				if(_activated) return _relatingCollection;
				Activate();
				return _relatingCollection;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingCollection = v, _relatingCollection, value,  "RelatingCollection", 8);
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
					_relatedThings.InternalAdd((xtdRoot)value.EntityVal);
					return;
				case 7: 
					_relatingCollection = (xtdCollection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdRelCollects other)
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
				foreach(var entity in @RelatedThings)
					yield return entity;
				if (@RelatingCollection != null)
					yield return @RelatingCollection;
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