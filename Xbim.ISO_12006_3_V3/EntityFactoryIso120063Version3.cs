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
using Xbim.Common.Step21;
using Xbim.Common;

namespace Xbim.ISO_12006_3_V3
{
	public sealed class EntityFactoryIso120063Version3 : IEntityFactory
	{
		private static readonly System.Reflection.Assembly _assembly;
		
		static EntityFactoryIso120063Version3()
		{
			_assembly = typeof(EntityFactoryIso120063Version3).Assembly;
		}

		public T New<T>(IModel model, int entityLabel, bool activated) where T: IInstantiableEntity
		{
			return (T)New(model, typeof(T), entityLabel, activated);
		}

		public T New<T>(IModel model, Action<T> init, int entityLabel, bool activated) where T: IInstantiableEntity
		{
			var o = New<T>(model, entityLabel, activated);
			if (init != null)
				init(o);
			return o;
		}

		public IInstantiableEntity New(IModel model, Type t, int entityLabel, bool activated)
		{
			//check that the type is from this assembly
			if(t.Assembly != _assembly)
				throw new Exception("This factory only creates types from its assembly");

			return New(model, t.Name, entityLabel, activated);
		}

		public IInstantiableEntity New(IModel model, string typeName, int entityLabel, bool activated)
		{
			if (model == null || string.IsNullOrWhiteSpace(typeName) || entityLabel < 0)
				throw new ArgumentNullException();

			var name = typeName.ToUpperInvariant();
			switch(name)
			{
				case "XTDACTIVITY": return new xtdActivity ( model, entityLabel, activated );
				case "XTDACTOR": return new xtdActor ( model, entityLabel, activated );
				case "XTDBAG": return new xtdBag ( model, entityLabel, activated );
				case "XTDDESCRIPTION": return new xtdDescription ( model, entityLabel, activated );
				case "XTDEXTERNALDOCUMENT": return new xtdExternalDocument ( model, entityLabel, activated );
				case "XTDLANGUAGE": return new xtdLanguage ( model, entityLabel, activated );
				case "XTDMEASUREWITHUNIT": return new xtdMeasureWithUnit ( model, entityLabel, activated );
				case "XTDNAME": return new xtdName ( model, entityLabel, activated );
				case "XTDNEST": return new xtdNest ( model, entityLabel, activated );
				case "XTDPROPERTY": return new xtdProperty ( model, entityLabel, activated );
				case "XTDRELACTSUPON": return new xtdRelActsUpon ( model, entityLabel, activated );
				case "XTDRELASSIGNSCOLLECTIONS": return new xtdRelAssignsCollections ( model, entityLabel, activated );
				case "XTDRELASSIGNSMEASURES": return new xtdRelAssignsMeasures ( model, entityLabel, activated );
				case "XTDRELASSIGNSPROPERTIES": return new xtdRelAssignsProperties ( model, entityLabel, activated );
				case "XTDRELASSIGNSPROPERTYWITHVALUES": return new xtdRelAssignsPropertyWithValues ( model, entityLabel, activated );
				case "XTDRELASSIGNSUNITS": return new xtdRelAssignsUnits ( model, entityLabel, activated );
				case "XTDRELASSIGNSVALUES": return new xtdRelAssignsValues ( model, entityLabel, activated );
				case "XTDRELASSOCIATES": return new xtdRelAssociates ( model, entityLabel, activated );
				case "XTDRELCOLLECTS": return new xtdRelCollects ( model, entityLabel, activated );
				case "XTDRELCOMPOSES": return new xtdRelComposes ( model, entityLabel, activated );
				case "XTDRELDOCUMENTS": return new xtdRelDocuments ( model, entityLabel, activated );
				case "XTDRELGROUPS": return new xtdRelGroups ( model, entityLabel, activated );
				case "XTDRELSEQUENCES": return new xtdRelSequences ( model, entityLabel, activated );
				case "XTDRELSPECIALIZES": return new xtdRelSpecializes ( model, entityLabel, activated );
				case "XTDSUBJECT": return new xtdSubject ( model, entityLabel, activated );
				case "XTDUNIT": return new xtdUnit ( model, entityLabel, activated );
				case "XTDVALUE": return new xtdValue ( model, entityLabel, activated );
				default:
					return null;
			}
		}
		public IInstantiableEntity New(IModel model, int typeId, int entityLabel, bool activated)
		{
			if (model == null)
				throw new ArgumentNullException();


			switch(typeId)
			{
				case 8: return new xtdActivity ( model, entityLabel, activated );
				case 9: return new xtdActor ( model, entityLabel, activated );
				case 10: return new xtdBag ( model, entityLabel, activated );
				case 12: return new xtdDescription ( model, entityLabel, activated );
				case 13: return new xtdExternalDocument ( model, entityLabel, activated );
				case 14: return new xtdLanguage ( model, entityLabel, activated );
				case 16: return new xtdMeasureWithUnit ( model, entityLabel, activated );
				case 17: return new xtdName ( model, entityLabel, activated );
				case 18: return new xtdNest ( model, entityLabel, activated );
				case 20: return new xtdProperty ( model, entityLabel, activated );
				case 21: return new xtdRelActsUpon ( model, entityLabel, activated );
				case 22: return new xtdRelAssignsCollections ( model, entityLabel, activated );
				case 23: return new xtdRelAssignsMeasures ( model, entityLabel, activated );
				case 24: return new xtdRelAssignsProperties ( model, entityLabel, activated );
				case 25: return new xtdRelAssignsPropertyWithValues ( model, entityLabel, activated );
				case 26: return new xtdRelAssignsUnits ( model, entityLabel, activated );
				case 27: return new xtdRelAssignsValues ( model, entityLabel, activated );
				case 28: return new xtdRelAssociates ( model, entityLabel, activated );
				case 30: return new xtdRelCollects ( model, entityLabel, activated );
				case 31: return new xtdRelComposes ( model, entityLabel, activated );
				case 32: return new xtdRelDocuments ( model, entityLabel, activated );
				case 33: return new xtdRelGroups ( model, entityLabel, activated );
				case 34: return new xtdRelSequences ( model, entityLabel, activated );
				case 35: return new xtdRelSpecializes ( model, entityLabel, activated );
				case 37: return new xtdSubject ( model, entityLabel, activated );
				case 38: return new xtdUnit ( model, entityLabel, activated );
				case 39: return new xtdValue ( model, entityLabel, activated );
				default:
					return null;
			}
		}

		public IExpressValueType New(string typeName)
		{
			if (typeName == null)
				throw new ArgumentNullException();

			var name = typeName.ToUpperInvariant();
			switch(name)
			{
				case "XTDDATE": return new xtdDate ();
				case "XTDGLOBALUNIQUEID": return new xtdGlobalUniqueID ();
				case "XTDLABEL": return new xtdLabel ();
				case "XTDTEXT": return new xtdText ();
				case "XTDVERSIONID": return new xtdVersionID ();
				default:
					return null;
			}
		}

		private static readonly List<string> _schemasIds = new List<string> { "ISO_12006_3_VERSION_3" };
		public IEnumerable<string> SchemasIds { get { return _schemasIds; } }

		/// <summary>
        /// Gets the Ifc Schema version of the model if this is IFC schema
        /// </summary>
		public XbimSchemaVersion SchemaVersion { 
			get
			{
				return XbimSchemaVersion.Unsupported;
			}
		}

	}
}
