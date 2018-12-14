using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.ISO_12006_3_V4.Samples
{
    class ComplexUnitsExample
    {
        public static void Run()
        {
            using (var h = new ModelHelper())
            {
                // litre per metre squared second
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.USERDEFINED;
                    du.UserDefinedType = "VOLUMETRIC_FLUX_UNIT";
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 1;
                        e.Unit = h.New<xtdConversionBasedUnit>(cbu =>
                        {
                            cbu.Name = "litre";
                            cbu.ConversionFactor = 0.001;
                            cbu.BaseUnit = h.New<xtdSIUnit>(si => {
                                si.Name = xtdSIUnitName.CUBIC_METRE;
                            });
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.SQUARE_METRE;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.SECOND;
                        });
                    }));
                    h.Comment(du, "litre per metre squared second");
                    h.Comment(du, $"Dimensional exponents: {du.Dimensions}");
                });

                // centimetre to the power of four
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.MOMENTOFINERTIAUNIT;
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 4;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Prefix = xtdSIPrefix.CENTI;
                            si.Name = xtdSIUnitName.METRE;
                        });
                    }));
                    h.Comment(du, "centimetre to the power of four");
                    h.Comment(du, $"Derived dimensional exponents: {du.Dimensions}");
                });

                // kilogram per square metre hour to the power of one half kg/(m² · h¹/²)
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.USERDEFINED;
                    du.UserDefinedType = "WATER_PERMEABILITY";
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.GRAM;
                            si.Prefix = xtdSIPrefix.KILO;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.SQUARE_METRE;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -0.5;
                        e.Unit = h.New<xtdConversionBasedUnit>(cbu =>
                        {
                            cbu.Name = "hour";
                            cbu.ConversionFactor = 60*60;
                            cbu.BaseUnit = h.New<xtdSIUnit>(si => {
                                si.Name = xtdSIUnitName.SECOND;
                            });
                        });
                    }));
                    h.Comment(du, "kilogram per square metre hour to the power of one half");
                    h.Comment(du, $"Derived dimensional exponents: {du.Dimensions}");
                });

                // miligram per kilowatt-hour
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.USERDEFINED;
                    du.UserDefinedType = "NO2_EMISSION";
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.GRAM;
                            si.Prefix = xtdSIPrefix.MILLI;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.WATT;
                            si.Prefix = xtdSIPrefix.KILO;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdConversionBasedUnit>(cbu =>
                        {
                            cbu.Name = "hour";
                            cbu.ConversionFactor = 60 * 60;
                            cbu.BaseUnit = h.New<xtdSIUnit>(si => {
                                si.Name = xtdSIUnitName.SECOND;
                            });
                        });
                    }));
                    h.Comment(du, "miligram per kilowatt-hour");
                    h.Comment(du, $"Derived dimensional exponents: {du.Dimensions}");
                });

                // kilogram per metre
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.MASSPERLENGTHUNIT;
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.GRAM;
                            si.Prefix = xtdSIPrefix.KILO;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.METRE;
                        });
                    }));
                   
                    h.Comment(du, "kilogram per metre");
                    h.Comment(du, $"Derived dimensional exponents: {du.Dimensions}");
                });

                // piece per pack
                h.New<xtdContextDependentUnit>(u => {
                    u.Name = "PIECES_PER_PACK";
                    h.Comment(u, "pieces per pack");
                    h.Comment(u, $"Derived dimensional exponents: {u.Dimensions}");
                    h.Comment(u, "Dimensional exponents [0 0 0 0 0 0 0] means dimension = 1 (ISO 80000-1)");
                    h.Comment(u, "Which is true for dimension-less measures like count");
                });

                // parts per million
                h.New<xtdContextDependentUnit>(u => {
                    u.Name = "PARTS_PER_MILLION";
                    h.Comment(u, "pieces per pack");
                    h.Comment(u, $"Derived dimensional exponents: {u.Dimensions}");
                });

                // baud
                h.New<xtdContextDependentUnit>(u => {
                    u.Name = "BAUD";
                    h.Comment(u, "baud");
                    h.Comment(u, $"Derived dimensional exponents: {u.Dimensions}");
                });

                h.Save(nameof(ComplexUnitsExample));
            }
        }
    }
}
