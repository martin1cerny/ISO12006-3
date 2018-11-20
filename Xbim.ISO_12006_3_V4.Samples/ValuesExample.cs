using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common.Model;

namespace Xbim.ISO_12006_3_V4.Samples
{
    internal class ValuesExample
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
                        d.Description = "Clear widt of the door";
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

                var widthMeasure = h.New<xtdMeasureWithUnit>(c => {
                    c.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "Width measure";
                    }));
                    c.Descriptions.Add(h.New<xtdDescription>(d => {
                        d.LanguageName = en;
                        d.Description = "Width of the door";
                    }));
                    c.ValueDomain.Add(h.New<xtdValue>(v => v.NominalValue = new xtdReal(800)));
                    c.UnitComponent = mm;
                    h.Comment(c, "This measure has value reliably encoded as a real number and has machine readable units");
                });

                var gradeMeasure = h.New<xtdMeasureWithUnit>(c => {
                    c.Names.Add(h.New<xtdName>(n => {
                        n.LanguageName = en;
                        n.Name = "Quality grade";
                    }));
                    c.Descriptions.Add(h.New<xtdDescription>(d => {
                        d.LanguageName = en;
                        d.Description = "Quality must be expressed as one of the values [A,B,C,D,E]";
                    }));
                    c.ValueDomain.Add(h.New<xtdValue>(v => v.NominalValue = new xtdLabel("C")));
                    c.UnitComponent = mm;
                    h.Comment(c, "This measure represents the grade as an enumeration value");
                });

                h.New<xtdRelAssignsMeasures>(rel => {
                    rel.RelatingProperty = propertyWidth;
                    rel.RelatedMeasures.Add(widthMeasure);
                    h.Comment(rel, "Relation expressing measure of the property");
                });
                h.New<xtdRelAssignsMeasures>(rel => {
                    rel.RelatingProperty = propertyGrade;
                    rel.RelatedMeasures.Add(gradeMeasure);
                });
                h.New<xtdRelAssignsProperties>(rel => {
                    rel.RelatedProperties.Add(propertyWidth);
                    rel.RelatedProperties.Add(propertyGrade);
                    rel.RelatingObject = subject;
                });

                h.Save(nameof(ValuesExample));
            }
        }
    }
}
