using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common.Model;

namespace Xbim.ISO_12006_3_V4.Samples
{
    internal class SchemaMappingExample
    {
        public static void Run()
        {
            using (var h = new ModelHelper())
            {
                var en = h.New<xtdLanguage>(l => {
                    l.LanguageNameInEnglish = "English";
                    h.Comment(l, "Definition of the language");
                });


                var door = h.New<xtdSubject>(s => {
                    s.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "The Door";
                    }));
                    s.Descriptions.Add(h.New<xtdDescription>(d => {
                        d.LanguageName = en;
                        d.Description = "Example of the door";
                    }));
                    h.Comment(s, "Subject of the specification");
                });

                var floor = h.New<xtdSubject>(s => {
                    s.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "The Floor";
                    }));
                    s.Descriptions.Add(h.New<xtdDescription>(d => {
                        d.LanguageName = en;
                        d.Description = "Example of the floor";
                    }));
                });

                var ifc = h.New<xtdExternalSchema>(s => {
                    s.Name = "IFC";
                    s.Description = "Industrial Foundation Classes";
                    s.Identifier = "IFC4";
                    s.Location = "http://www.buildingsmart-tech.org/ifc/IFC4/Add2/IFC4_ADD2.exp";
                    s.Version = "IFC4 ADD2";
                    h.Comment(s, "Information identifying external schema so that external automation systems can identify relevant mappings");
                });

                var extDoor = h.New<xtdExternalObject>(e => {
                    e.ExternalIdentifier = "IfcDoor";
                    e.ExternalSubIdentifier = "DOOR";
                    e.ExternalSchema = ifc;
                    h.Comment(e, "External objects identified by their identifiers, sub-identifiers and the schema");
                });
                var extFloor = h.New<xtdExternalObject>(e => {
                    e.ExternalIdentifier = "IfcSlab";
                    e.ExternalSubIdentifier = "FLOOR";
                    e.ExternalSchema = ifc;
                });

                h.New<xtdRelMapping>(rel =>
                {
                    rel.RelatedExternalObject = extDoor;
                    rel.RelatingObject = door;
                    h.Comment(rel, "Relation defining external objects in external schemas");
                });
                h.New<xtdRelMapping>(rel =>
                {
                    rel.RelatedExternalObject = extFloor;
                    rel.RelatingObject = floor;
                });


                h.Save(nameof(SchemaMappingExample));
            }
        }
    }
}
