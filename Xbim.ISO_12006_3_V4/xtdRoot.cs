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
    /// Readonly interface for xtdRoot
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdRoot : IPersistEntity
	{
		xtdDate? @VersionDate { get;  set; }
		xtdVersionID? @VersionID { get;  set; }
		xtdGlobalUniqueID @UniqueID { get;  set; }
		IItemSet<IxtdDescription> @Descriptions { get; }
		IItemSet<IxtdName> @Names { get; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdRoot", 47)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @xtdRoot : PersistEntity, IxtdRoot, IEquatable<@xtdRoot>
	{
		#region IxtdRoot explicit implementation
		xtdDate? IxtdRoot.VersionDate { 
 
			get { return @VersionDate; } 
			set { VersionDate = value;}
		}	
		xtdVersionID? IxtdRoot.VersionID { 
 
			get { return @VersionID; } 
			set { VersionID = value;}
		}	
		xtdGlobalUniqueID IxtdRoot.UniqueID { 
 
			get { return @UniqueID; } 
			set { UniqueID = value;}
		}	
		IItemSet<IxtdDescription> IxtdRoot.Descriptions { 
			get { return new Common.Collections.ProxyItemSet<xtdDescription, IxtdDescription>( @Descriptions); } 
		}	
		IItemSet<IxtdName> IxtdRoot.Names { 
			get { return new Common.Collections.ProxyItemSet<xtdName, IxtdName>( @Names); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdRoot(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_descriptions = new OptionalItemSet<xtdDescription>( this, 0,  4);
			_names = new ItemSet<xtdName>( this, 0,  5);
		}

		#region Explicit attribute fields
		private xtdDate? _versionDate;
		private xtdVersionID? _versionID;
		private xtdGlobalUniqueID _uniqueID;
		private readonly OptionalItemSet<xtdDescription> _descriptions;
		private readonly ItemSet<xtdName> _names;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public xtdDate? @VersionDate 
		{ 
			get 
			{
				if(_activated) return _versionDate;
				Activate();
				return _versionDate;
			} 
			set
			{
				SetValue( v =>  _versionDate = v, _versionDate, value,  "VersionDate", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public xtdVersionID? @VersionID 
		{ 
			get 
			{
				if(_activated) return _versionID;
				Activate();
				return _versionID;
			} 
			set
			{
				SetValue( v =>  _versionID = v, _versionID, value,  "VersionID", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public xtdGlobalUniqueID @UniqueID 
		{ 
			get 
			{
				if(_activated) return _uniqueID;
				Activate();
				return _uniqueID;
			} 
			set
			{
				SetValue( v =>  _uniqueID = v, _uniqueID, value,  "UniqueID", 3);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IOptionalItemSet<xtdDescription> @Descriptions 
		{ 
			get 
			{
				if(_activated) return _descriptions;
				Activate();
				return _descriptions;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IItemSet<xtdName> @Names 
		{ 
			get 
			{
				if(_activated) return _names;
				Activate();
				return _names;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_versionDate = value.StringVal;
					return;
				case 1: 
					_versionID = value.StringVal;
					return;
				case 2: 
					_uniqueID = value.StringVal;
					return;
				case 3: 
					_descriptions.InternalAdd((xtdDescription)value.EntityVal);
					return;
				case 4: 
					_names.InternalAdd((xtdName)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdRoot other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}