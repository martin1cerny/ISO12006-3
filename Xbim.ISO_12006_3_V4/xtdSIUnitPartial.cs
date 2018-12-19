using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Step21;

namespace Xbim.ISO_12006_3_V4
{
    // ReSharper disable once InconsistentNaming
    public partial class xtdSIUnit
    {
        private static readonly Dictionary<xtdSIUnitName, xtdDimensionalExponents> ExponentsCache = new Dictionary<xtdSIUnitName, xtdDimensionalExponents>(); 
        internal xtdDimensionalExponents xtdDimensionsForSiUnit(xtdSIUnitName name)
        {
            xtdDimensionalExponents result;
            if (ExponentsCache.TryGetValue(name, out result))
                return result;
            switch (name)
            {
                case xtdSIUnitName.METRE: result = GetOrCreateExponents(new List<int> { 1, 0, 0, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.GRAM: result = GetOrCreateExponents(new List<int> { 0, 1, 0, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.SECOND: result = GetOrCreateExponents(new List<int> { 0, 0, 1, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.AMPERE: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 1, 0, 0, 0 }); break;
                case xtdSIUnitName.KELVIN: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 0, 1, 0, 0 }); break;
                case xtdSIUnitName.MOLE: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 0, 0, 1, 0 }); break;
                case xtdSIUnitName.CANDELA: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 0, 0, 0, 1 }); break;
                case xtdSIUnitName.RADIAN: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.STERADIAN: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.HERTZ: result = GetOrCreateExponents(new List<int> { 0, 0, -1, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.NEWTON: result = GetOrCreateExponents(new List<int> { 1, 1, -2, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.PASCAL: result = GetOrCreateExponents(new List<int> { -1, 1, -2, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.JOULE: result = GetOrCreateExponents(new List<int> { 2, 1, -2, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.WATT: result = GetOrCreateExponents(new List<int> { 2, 1, -3, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.COULOMB: result = GetOrCreateExponents(new List<int> { 0, 0, 1, 1, 0, 0, 0 }); break;
                case xtdSIUnitName.VOLT: result = GetOrCreateExponents(new List<int> { 2, 1, -3, -1, 0, 0, 0 }); break;
                case xtdSIUnitName.FARAD: result = GetOrCreateExponents(new List<int> { -2, -1, 4, 1, 0, 0, 0 }); break;
                case xtdSIUnitName.OHM: result = GetOrCreateExponents(new List<int> { 2, 1, -3, -2, 0, 0, 0 }); break;
                case xtdSIUnitName.SIEMENS: result = GetOrCreateExponents(new List<int> { -2, -1, 3, 2, 0, 0, 0 }); break;
                case xtdSIUnitName.WEBER: result = GetOrCreateExponents(new List<int> { 2, 1, -2, -1, 0, 0, 0 }); break;
                case xtdSIUnitName.TESLA: result = GetOrCreateExponents(new List<int> { 0, 1, -2, -1, 0, 0, 0 }); break;
                case xtdSIUnitName.HENRY: result = GetOrCreateExponents(new List<int> { 2, 1, -2, -2, 0, 0, 0 }); break;
                case xtdSIUnitName.DEGREE_CELSIUS: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 0, 1, 0, 0 }); break;
                case xtdSIUnitName.LUMEN: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 0, 0, 0, 1 }); break;
                case xtdSIUnitName.LUX: result = GetOrCreateExponents(new List<int> { -2, 0, 0, 0, 0, 0, 1 }); break;
                case xtdSIUnitName.BECQUEREL: result = GetOrCreateExponents(new List<int> { 0, 0, -1, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.GRAY: result = GetOrCreateExponents(new List<int> { 2, 0, -2, 0, 0, 0, 0 }); break;
                case xtdSIUnitName.SIEVERT: result = GetOrCreateExponents(new List<int> { 2, 0, -2, 0, 0, 0, 0 }); break;
                default: result = GetOrCreateExponents(new List<int> { 0, 0, 0, 0, 0, 0, 0 }); break;
            }

            ExponentsCache.Add(name, result);
            return result;
        }

        private xtdDimensionalExponents GetOrCreateExponents(IList<int> exponents)
        {
            var result = Model.Instances.FirstOrDefault<xtdDimensionalExponents>(e =>
                e.LengthExponent == exponents[0] &&
                e.MassExponent == exponents[1] &&
                e.TimeExponent == exponents[2] &&
                e.ElectricCurrentExponent == exponents[3] &&
                e.ThermodynamicTemperatureExponent == exponents[4] &&
                e.AmountOfSubstanceExponent == exponents[5] &&
                e.LuminousIntensityExponent == exponents[6]
                );
            if (result != null)
                return result;

            result = new xtdDimensionalExponents(
                exponents[0],
                exponents[1],
                exponents[2],
                exponents[3],
                exponents[4],
                exponents[5],
                exponents[6]
                );
            

            return result;

        }
        /// <summary>
        ///   returns the power of the SIUnit prefix, i.e. MILLI = 0.001, if undefined returns 1.0
        /// </summary>
        public double Power
        {
            get
            {
                var exponential = 1;
                if (Prefix.HasValue)
                {
                    double factor;
                    switch (Prefix.Value)
                    {
                        case xtdSIPrefix.EXA:
                            factor = 1.0e+18; break;
                        case xtdSIPrefix.PETA:
                            factor = 1.0e+15; break;
                        case xtdSIPrefix.TERA:
                            factor = 1.0e+12; break;
                        case xtdSIPrefix.GIGA:
                            factor = 1.0e+9; break;
                        case xtdSIPrefix.MEGA:
                            factor = 1.0e+6; break;
                        case xtdSIPrefix.KILO:
                            factor = 1.0e+3; break;
                        case xtdSIPrefix.HECTO:
                            factor = 1.0e+2; break;
                        case xtdSIPrefix.DECA:
                            factor = 10; break;
                        case xtdSIPrefix.DECI:
                            factor = 1.0e-1; break;
                        case xtdSIPrefix.CENTI:
                            factor = 1.0e-2; break;
                        case xtdSIPrefix.MILLI:
                            factor = 1.0e-3; break;
                        case xtdSIPrefix.MICRO:
                            factor = 1.0e-6; break;
                        case xtdSIPrefix.NANO:
                            factor = 1.0e-9; break;
                        case xtdSIPrefix.PICO:
                            factor = 1.0e-12; break;
                        case xtdSIPrefix.FEMTO:
                            factor = 1.0e-15; break;
                        case xtdSIPrefix.ATTO:
                            factor = 1.0e-18; break;
                        default:
                            factor = 1.0; break;
                    }
                    return Math.Pow(factor, exponential);
                }
                return 1.0;
            }
        }



        /// <summary>
        /// Get Symbol string for SIUnit unit
        /// </summary>
        /// <returns>String holding symbol</returns>
        public string Symbol
        {
            get
            {
                var ifcSiUnitName = Name;
                string value;
                string prefix = string.Empty;
                if (Prefix != null)
                {
                    var ifcSiPrefix = (xtdSIPrefix) Prefix;
                    switch (ifcSiPrefix)
                    {
                        case xtdSIPrefix.EXA:
							prefix = "E";
							break;
						case xtdSIPrefix.PETA:
							prefix = "P";
							break;
						case xtdSIPrefix.TERA:
							prefix = "T";
							break;
						case xtdSIPrefix.GIGA:
							prefix = "G";
							break;
						case xtdSIPrefix.MEGA:
							prefix = "M";
							break;
						case xtdSIPrefix.KILO:
							prefix = "k";
							break;
						case xtdSIPrefix.HECTO:
							prefix = "h";
							break;
						case xtdSIPrefix.DECA:
							prefix = "da";
							break;
						case xtdSIPrefix.DECI:
							prefix = "d";
							break;
						case xtdSIPrefix.CENTI:
							prefix = "c";
							break;
                        case xtdSIPrefix.MILLI:
                            prefix = "m";
                            break;
						case xtdSIPrefix.MICRO:
							prefix = "µ";
							break;
						case xtdSIPrefix.NANO:
							prefix = "n";
							break;
						case xtdSIPrefix.PICO:
							prefix = "p";
							break;
						case xtdSIPrefix.FEMTO:
							prefix = "f";
							break;
						case xtdSIPrefix.ATTO:
							prefix = "a";
							break;
						default: //TODO: the other values of xtdSIPrefix
                            prefix = ifcSiPrefix.ToString();
                            break;
                    }
                }

                switch (ifcSiUnitName)
                {
                    case xtdSIUnitName.AMPERE:
						value = prefix + "A";
						break;
					case xtdSIUnitName.BECQUEREL:
						value = prefix + "Bq";
						break;
					case xtdSIUnitName.CANDELA:
						value = prefix + "cd";
						break;
					case xtdSIUnitName.COULOMB:
						value = prefix + "C";
						break;
					case xtdSIUnitName.DEGREE_CELSIUS:
						value = prefix + '\u00B0' + "C"; //((char)0x00B0)
						break;
					case xtdSIUnitName.FARAD:
						value = prefix + "F";
						break;
					case xtdSIUnitName.GRAM:
						value = prefix + "g";
						break;
					case xtdSIUnitName.GRAY:
						value = prefix + "Gy";
						break;
					case xtdSIUnitName.HENRY:
						value = prefix + "H";
						break;
					case xtdSIUnitName.HERTZ:
						value = prefix + "Hz";
						break;
					case xtdSIUnitName.JOULE:
						value = prefix + "J";
						break;
					case xtdSIUnitName.KELVIN:
						value = prefix + "K";
						break;
					case xtdSIUnitName.LUMEN:
						value = prefix + "lm";
						break;
					case xtdSIUnitName.LUX:
						value = prefix + "lx";
						break;
					case xtdSIUnitName.METRE:
                        value = prefix + "m";
                        break;
					case xtdSIUnitName.MOLE:
						value = prefix + "mol";
						break;
					case xtdSIUnitName.NEWTON:
						value = prefix + "N";
						break;
					case xtdSIUnitName.OHM:
						value = prefix + '\u03A9'; //((char)0x03A9)
						break;
					case xtdSIUnitName.PASCAL:
						value = prefix + "Pa";
						break;
					case xtdSIUnitName.RADIAN:
						value = prefix + "rad";
						break;
					case xtdSIUnitName.SECOND:
						value = prefix + "s";
						break;
					case xtdSIUnitName.SIEMENS:
						value = prefix + "S";
						break;
					case xtdSIUnitName.SIEVERT:
						value = prefix + "Sv";
						break;
					case xtdSIUnitName.STERADIAN:
						value = prefix + "sr";
						break;
					case xtdSIUnitName.TESLA:
						value = prefix + "T";
						break;
					case xtdSIUnitName.VOLT:
						value = prefix + "V";
						break;
					case xtdSIUnitName.WATT:
						value = prefix + "W";
						break;
					case xtdSIUnitName.WEBER:
						value = prefix + "Wb";
						break;
					default: //TODO: the other values of xtdSIUnitName
                        value = ToString();
                        break;
                }
                return value;
            }
        }

        /// <summary>
        /// Returns the full name of the unit
        /// </summary>
        /// <returns>string holding name</returns>
        public string FullName
        {
            get
            {
                var prefixUnit = (Prefix.HasValue) ? Prefix.ToString() : ""; //see xtdSIPrefix
                var value = Name.ToString(); //see xtdSIUnitName
                //Handle the "_" in _name value, should work for lengths, but might have to look at other values later
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Contains("_"))
                        return value.Replace("_", prefixUnit);
                    return prefixUnit + value; //combine to give length name
                }
                return string.Format("{0}{1}", Prefix.HasValue ? Prefix.Value.ToString() : "", Name);
            }
        }

        private class PropVal: IPropertyValue
        {
            public PropVal(long integer)
            {
                IntegerVal = integer;
                Type = StepParserType.Integer;
            }

            public bool BooleanVal { get; private set; }
            public string EnumVal { get; private set; }
            public object EntityVal { get; private set; }
            public byte[] HexadecimalVal { get; private set; }
            public long IntegerVal { get; private set; }
            public double NumberVal { get; private set; }
            public double RealVal { get; private set; }
            public string StringVal { get; private set; }
            public StepParserType Type { get; private set; }
        }
    }
}
