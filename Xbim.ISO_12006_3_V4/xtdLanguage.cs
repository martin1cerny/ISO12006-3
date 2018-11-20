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
    /// Readonly interface for xtdLanguage
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IxtdLanguage : IPersistEntity
	{
		xtdLabel @LanguageNameInEnglish { get;  set; }
		xtdLabel? @LanguageNameInSelf { get;  set; }
		IItemSet<xtdText> @Comments { get; }
		xtdGlobalUniqueID @UniqueID { get;  set; }
	
	}
}

namespace Xbim.ISO_12006_3_V4
{
	[ExpressType("xtdLanguage", 44)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @xtdLanguage : PersistEntity, IInstantiableEntity, IxtdLanguage, IEquatable<@xtdLanguage>
	{
		#region IxtdLanguage explicit implementation
		xtdLabel IxtdLanguage.LanguageNameInEnglish { 
 
			get { return @LanguageNameInEnglish; } 
			set { LanguageNameInEnglish = value;}
		}	
		xtdLabel? IxtdLanguage.LanguageNameInSelf { 
 
			get { return @LanguageNameInSelf; } 
			set { LanguageNameInSelf = value;}
		}	
		IItemSet<xtdText> IxtdLanguage.Comments { 
			get { return @Comments; } 
		}	
		xtdGlobalUniqueID IxtdLanguage.UniqueID { 
 
			get { return @UniqueID; } 
			set { UniqueID = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal xtdLanguage(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_comments = new OptionalItemSet<xtdText>( this, 0,  3);
		}

		#region Explicit attribute fields
		private xtdLabel _languageNameInEnglish;
		private xtdLabel? _languageNameInSelf;
		private readonly OptionalItemSet<xtdText> _comments;
		private xtdGlobalUniqueID _uniqueID;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public xtdLabel @LanguageNameInEnglish 
		{ 
			get 
			{
				if(_activated) return _languageNameInEnglish;
				Activate();
				return _languageNameInEnglish;
			} 
			set
			{
				SetValue( v =>  _languageNameInEnglish = v, _languageNameInEnglish, value,  "LanguageNameInEnglish", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public xtdLabel? @LanguageNameInSelf 
		{ 
			get 
			{
				if(_activated) return _languageNameInSelf;
				Activate();
				return _languageNameInSelf;
			} 
			set
			{
				SetValue( v =>  _languageNameInSelf = v, _languageNameInSelf, value,  "LanguageNameInSelf", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 3)]
		public IOptionalItemSet<xtdText> @Comments 
		{ 
			get 
			{
				if(_activated) return _comments;
				Activate();
				return _comments;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
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
				SetValue( v =>  _uniqueID = v, _uniqueID, value,  "UniqueID", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_languageNameInEnglish = value.StringVal;
					return;
				case 1: 
					_languageNameInSelf = value.StringVal;
					return;
				case 2: 
					_comments.InternalAdd(value.StringVal);
					return;
				case 3: 
					_uniqueID = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@xtdLanguage other)
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