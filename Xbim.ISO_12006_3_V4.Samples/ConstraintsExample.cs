using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common.Model;

namespace Xbim.ISO_12006_3_V4.Samples
{
    internal class ConstraintsExample
    {
        public static void Run()
        {
            using (var h = new ModelHelper())
            {
                var en = h.New<xtdLanguage>(l => {
                    l.LanguageNameInEnglish = "English";
                    h.Comment(l, "Definition of the language");
                });

                var mmDef = h.New<xtdSIUnit>(si => {
                    si.Prefix = xtdSIPrefix.MILLI;
                    si.Name = xtdSIUnitName.METRE;
                    si.UnitType = xtdUnitEnum.LENGTHUNIT;
                    h.Comment(si, "New entity types introduced to describe units. This is a simple SI unit.");
                });

                var mm = h.New<xtdUnit>(u => {
                    u.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "Millimetre";
                    }));
                    u.Definition = mmDef;
                    h.Comment(u, "xtdUnit is extended with 'Definition' which is a machine readable expression for the unit.");
                    h.Comment(u, "This makes it possible to external autometed systems to work with the data and definitions.");
                });

                var subject = h.New<xtdSubject>(s => {
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


                var propertyWidth = h.New<xtdProperty>(p => {
                    p.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "Width";
                    }));
                    p.Descriptions.Add(h.New<xtdDescription>(d => {
                        d.LanguageName = en;
                        d.Description = "Clear width of the door";
                    }));
                    h.Comment(p, "Property can either be related to subject with value or constraint or both");
                });
                var propertyGrade = h.New<xtdProperty>(p => {
                    p.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "Quality";
                    }));
                    p.Descriptions.Add(h.New<xtdDescription>(d => {
                        d.LanguageName = en;
                        d.Description = "Quality grading";
                    }));
                });

                var measureConstraint = h.New<xtdMeasureConstraint>(c => {
                    c.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "Width constraint";
                    }));
                    c.Descriptions.Add(h.New<xtdDescription>(d => {
                        d.LanguageName = en;
                        d.Description = "Width of the doot must be less than or equal to 800mm";
                    }));
                    c.ConstraintType = xtdConstraintTypeEnum.LESSTHANOREQUALTO;
                    c.ConstraintValues.Add(new xtdReal(800));
                    c.ValuesUnit = mm;
                    h.Comment(c, "This constraint expresses requirement for the value assignable to a property");
                });

                var enumConstraint = h.New<xtdMeasureConstraint>(c => {
                    c.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "Quality grade constraint";
                    }));
                    c.Descriptions.Add(h.New<xtdDescription>(d => {
                        d.LanguageName = en;
                        d.Description = "Quality must be expressed as one of the values";
                    }));
                    c.ConstraintType = xtdConstraintTypeEnum.INCLUDEDIN;
                    c.ConstraintValues.Add(new xtdLabel("A"));
                    c.ConstraintValues.Add(new xtdLabel("B"));
                    c.ConstraintValues.Add(new xtdLabel("C"));
                    c.ConstraintValues.Add(new xtdLabel("D"));
                    c.ConstraintValues.Add(new xtdLabel("E"));
                    c.ValuesUnit = mm;
                    h.Comment(c, "This constraint expresses requirement for the value to exist in the list of allowed values (enumeration)");
                });

                h.New<xtdRelAssignsPropertyWithConstraint>(rel => {
                    rel.RelatingObject = subject;
                    rel.RelatedProperty = propertyWidth;
                    rel.RelatedConstraint = measureConstraint;
                    h.Comment(rel, "Relation expressing constrained property for the subject");
                });
                h.New<xtdRelAssignsPropertyWithConstraint>(rel => {
                    rel.RelatingObject = subject;
                    rel.RelatedProperty = propertyGrade;
                    rel.RelatedConstraint = enumConstraint;
                });

                h.Save(nameof(ConstraintsExample));
            }
        }
    }
}
