using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.ISO_12006_3_V4.Samples
{

    // litre per metre squared second
    // centimetre to the power of four
    // kilogram per square metre hour to the power of one half
    // miligram per kilowatt-hour
    // kilogram per metre
    class ComplexUnitsExample
    {
        public static void Run()
        {
            using (var h = new ModelHelper())
            {
                // litre per metre squared second
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.USERDEFINED;
                    du.UserDefinedType = "VOLUMETRICFLUXUNIT";
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 1;
                        e.Unit = h.New<xtdConversionBasedUnit>(cbu =>
                        {
                            cbu.Name = "litre";
                            cbu.ConversionFactor = 0.001;
                            cbu.BaseUnit = h.New<xtdSIUnit>(si => {
                                si.Name = xtdSIUnitName.CUBIC_METRE;
                                si.UnitType = xtdUnitEnum.VOLUMEUNIT;
                            });
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.SQUARE_METRE;
                            si.UnitType = xtdUnitEnum.AREAUNIT;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.SECOND;
                            si.UnitType = xtdUnitEnum.TIMEUNIT;
                        });
                    }));
                    h.Comment(du, "litre per metre squared second");
                });

                // centimetre to the power of four
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.MOMENTOFINERTIAUNIT;
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 4;
                        e.Unit = h.New<xtdConversionBasedUnit>(cbu =>
                        {
                            cbu.Name = "centimetre";
                            cbu.ConversionFactor = 0.01;
                            cbu.BaseUnit = h.New<xtdSIUnit>(si => {
                                si.Name = xtdSIUnitName.METRE;
                                si.UnitType = xtdUnitEnum.LENGTHUNIT;
                            });
                        });
                    }));
                    h.Comment(du, "centimetre to the power of four");
                });

                // kilogram per square metre hour to the power of one half kg/(m² · h¹/²)
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.USERDEFINED;
                    du.UserDefinedType = "WATERPERMEABILITY";
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.GRAM;
                            si.Prefix = xtdSIPrefix.KILO;
                            si.UnitType = xtdUnitEnum.MASSUNIT;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.SQUARE_METRE;
                            si.UnitType = xtdUnitEnum.AREAUNIT;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdConversionBasedUnit>(cbu =>
                        {
                            cbu.Name = "hour";
                            cbu.ConversionFactor = 60*60;
                            cbu.BaseUnit = h.New<xtdSIUnit>(si => {
                                si.Name = xtdSIUnitName.SECOND;
                                si.UnitType = xtdUnitEnum.TIMEUNIT;
                            });
                        });
                    }));
                    h.Comment(du, "kilogram per square metre hour");
                });

                // miligram per kilowatt-hour
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.USERDEFINED;
                    du.UserDefinedType = "NO2EMISSION";
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.GRAM;
                            si.Prefix = xtdSIPrefix.MILLI;
                            si.UnitType = xtdUnitEnum.MASSUNIT;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.WATT;
                            si.Prefix = xtdSIPrefix.KILO;
                            si.UnitType = xtdUnitEnum.POWERUNIT;
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
                                si.UnitType = xtdUnitEnum.TIMEUNIT;
                            });
                        });
                    }));
                    h.Comment(du, "miligram per kilowatt-hour");
                });

                // kilogram per metre
                h.New<xtdDerivedUnit>(du => {
                    du.UnitType = xtdDerivedUnitEnum.MASSPERLENGTHUNIT;
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = 1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.GRAM;
                            si.Prefix = xtdSIPrefix.KILO;
                            si.UnitType = xtdUnitEnum.MASSUNIT;
                        });
                    }));
                    du.Elements.Add(h.New<xtdDerivedUnitElement>(e => {
                        e.Exponent = -1;
                        e.Unit = h.New<xtdSIUnit>(si => {
                            si.Name = xtdSIUnitName.METRE;
                            si.UnitType = xtdUnitEnum.LENGTHUNIT;
                        });
                    }));
                   
                    h.Comment(du, "kilogram per metre");
                });

                // piece per pack
                h.New<xtdContextDependentUnit>(u => {
                    u.UnitType = xtdUnitEnum.USERDEFINED;
                    u.Dimensions = h.New<xtdDimensionalExponents>();
                    u.Name = "pieces per pack";
                    h.Comment(u, "pieces per pack");
                });

                // parts per million
                h.New<xtdContextDependentUnit>(u => {
                    u.UnitType = xtdUnitEnum.USERDEFINED;
                    u.Dimensions = h.New<xtdDimensionalExponents>();
                    u.Name = "parts per million";
                    h.Comment(u, "pieces per pack");
                });

                // baud
                h.New<xtdContextDependentUnit>(u => {
                    u.UnitType = xtdUnitEnum.USERDEFINED;
                    u.Dimensions = h.New<xtdDimensionalExponents>();
                    u.Name = "baud";
                    h.Comment(u, "baud");
                });

                h.Save(nameof(ComplexUnitsExample));
            }
        }
    }
}
