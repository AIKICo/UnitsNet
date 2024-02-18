//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Amount of ionizing radiation released when an element spontaneously emits energy as a result of the radioactive decay of an unstable atom per unit time.
    /// </summary>
    public struct  Radioactivity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RadioactivityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public RadioactivityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Radioactivity(double value, RadioactivityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Radioactivity, which is Second. All conversions go via this value.
        /// </summary>
        public static RadioactivityUnit BaseUnit { get; } = RadioactivityUnit.Becquerel;

        /// <summary>
        /// Represents the largest possible value of Radioactivity.
        /// </summary>
        public static Radioactivity MaxValue { get; } = new Radioactivity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Radioactivity.
        /// </summary>
        public static Radioactivity MinValue { get; } = new Radioactivity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Radioactivity Zero { get; } = new Radioactivity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Becquerel"/>
        /// </summary>
        public double Becquerels => As(RadioactivityUnit.Becquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Curie"/>
        /// </summary>
        public double Curies => As(RadioactivityUnit.Curie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Exabecquerel"/>
        /// </summary>
        public double Exabecquerels => As(RadioactivityUnit.Exabecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Gigabecquerel"/>
        /// </summary>
        public double Gigabecquerels => As(RadioactivityUnit.Gigabecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Gigacurie"/>
        /// </summary>
        public double Gigacuries => As(RadioactivityUnit.Gigacurie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Gigarutherford"/>
        /// </summary>
        public double Gigarutherfords => As(RadioactivityUnit.Gigarutherford);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Kilobecquerel"/>
        /// </summary>
        public double Kilobecquerels => As(RadioactivityUnit.Kilobecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Kilocurie"/>
        /// </summary>
        public double Kilocuries => As(RadioactivityUnit.Kilocurie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Kilorutherford"/>
        /// </summary>
        public double Kilorutherfords => As(RadioactivityUnit.Kilorutherford);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Megabecquerel"/>
        /// </summary>
        public double Megabecquerels => As(RadioactivityUnit.Megabecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Megacurie"/>
        /// </summary>
        public double Megacuries => As(RadioactivityUnit.Megacurie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Megarutherford"/>
        /// </summary>
        public double Megarutherfords => As(RadioactivityUnit.Megarutherford);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Microbecquerel"/>
        /// </summary>
        public double Microbecquerels => As(RadioactivityUnit.Microbecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Microcurie"/>
        /// </summary>
        public double Microcuries => As(RadioactivityUnit.Microcurie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Microrutherford"/>
        /// </summary>
        public double Microrutherfords => As(RadioactivityUnit.Microrutherford);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Millibecquerel"/>
        /// </summary>
        public double Millibecquerels => As(RadioactivityUnit.Millibecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Millicurie"/>
        /// </summary>
        public double Millicuries => As(RadioactivityUnit.Millicurie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Millirutherford"/>
        /// </summary>
        public double Millirutherfords => As(RadioactivityUnit.Millirutherford);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Nanobecquerel"/>
        /// </summary>
        public double Nanobecquerels => As(RadioactivityUnit.Nanobecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Nanocurie"/>
        /// </summary>
        public double Nanocuries => As(RadioactivityUnit.Nanocurie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Nanorutherford"/>
        /// </summary>
        public double Nanorutherfords => As(RadioactivityUnit.Nanorutherford);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Petabecquerel"/>
        /// </summary>
        public double Petabecquerels => As(RadioactivityUnit.Petabecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Picobecquerel"/>
        /// </summary>
        public double Picobecquerels => As(RadioactivityUnit.Picobecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Picocurie"/>
        /// </summary>
        public double Picocuries => As(RadioactivityUnit.Picocurie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Picorutherford"/>
        /// </summary>
        public double Picorutherfords => As(RadioactivityUnit.Picorutherford);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Rutherford"/>
        /// </summary>
        public double Rutherfords => As(RadioactivityUnit.Rutherford);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Terabecquerel"/>
        /// </summary>
        public double Terabecquerels => As(RadioactivityUnit.Terabecquerel);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Teracurie"/>
        /// </summary>
        public double Teracuries => As(RadioactivityUnit.Teracurie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadioactivityUnit.Terarutherford"/>
        /// </summary>
        public double Terarutherfords => As(RadioactivityUnit.Terarutherford);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Becquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromBecquerels(double becquerels) => new Radioactivity(becquerels, RadioactivityUnit.Becquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Curie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromCuries(double curies) => new Radioactivity(curies, RadioactivityUnit.Curie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Exabecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromExabecquerels(double exabecquerels) => new Radioactivity(exabecquerels, RadioactivityUnit.Exabecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Gigabecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromGigabecquerels(double gigabecquerels) => new Radioactivity(gigabecquerels, RadioactivityUnit.Gigabecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Gigacurie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromGigacuries(double gigacuries) => new Radioactivity(gigacuries, RadioactivityUnit.Gigacurie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Gigarutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromGigarutherfords(double gigarutherfords) => new Radioactivity(gigarutherfords, RadioactivityUnit.Gigarutherford);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Kilobecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromKilobecquerels(double kilobecquerels) => new Radioactivity(kilobecquerels, RadioactivityUnit.Kilobecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Kilocurie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromKilocuries(double kilocuries) => new Radioactivity(kilocuries, RadioactivityUnit.Kilocurie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Kilorutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromKilorutherfords(double kilorutherfords) => new Radioactivity(kilorutherfords, RadioactivityUnit.Kilorutherford);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Megabecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMegabecquerels(double megabecquerels) => new Radioactivity(megabecquerels, RadioactivityUnit.Megabecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Megacurie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMegacuries(double megacuries) => new Radioactivity(megacuries, RadioactivityUnit.Megacurie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Megarutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMegarutherfords(double megarutherfords) => new Radioactivity(megarutherfords, RadioactivityUnit.Megarutherford);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Microbecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMicrobecquerels(double microbecquerels) => new Radioactivity(microbecquerels, RadioactivityUnit.Microbecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Microcurie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMicrocuries(double microcuries) => new Radioactivity(microcuries, RadioactivityUnit.Microcurie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Microrutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMicrorutherfords(double microrutherfords) => new Radioactivity(microrutherfords, RadioactivityUnit.Microrutherford);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Millibecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMillibecquerels(double millibecquerels) => new Radioactivity(millibecquerels, RadioactivityUnit.Millibecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Millicurie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMillicuries(double millicuries) => new Radioactivity(millicuries, RadioactivityUnit.Millicurie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Millirutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromMillirutherfords(double millirutherfords) => new Radioactivity(millirutherfords, RadioactivityUnit.Millirutherford);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Nanobecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromNanobecquerels(double nanobecquerels) => new Radioactivity(nanobecquerels, RadioactivityUnit.Nanobecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Nanocurie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromNanocuries(double nanocuries) => new Radioactivity(nanocuries, RadioactivityUnit.Nanocurie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Nanorutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromNanorutherfords(double nanorutherfords) => new Radioactivity(nanorutherfords, RadioactivityUnit.Nanorutherford);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Petabecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromPetabecquerels(double petabecquerels) => new Radioactivity(petabecquerels, RadioactivityUnit.Petabecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Picobecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromPicobecquerels(double picobecquerels) => new Radioactivity(picobecquerels, RadioactivityUnit.Picobecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Picocurie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromPicocuries(double picocuries) => new Radioactivity(picocuries, RadioactivityUnit.Picocurie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Picorutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromPicorutherfords(double picorutherfords) => new Radioactivity(picorutherfords, RadioactivityUnit.Picorutherford);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Rutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromRutherfords(double rutherfords) => new Radioactivity(rutherfords, RadioactivityUnit.Rutherford);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Terabecquerel"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromTerabecquerels(double terabecquerels) => new Radioactivity(terabecquerels, RadioactivityUnit.Terabecquerel);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Teracurie"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromTeracuries(double teracuries) => new Radioactivity(teracuries, RadioactivityUnit.Teracurie);

        /// <summary>
        ///     Creates a <see cref="Radioactivity"/> from <see cref="RadioactivityUnit.Terarutherford"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Radioactivity FromTerarutherfords(double terarutherfords) => new Radioactivity(terarutherfords, RadioactivityUnit.Terarutherford);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RadioactivityUnit" /> to <see cref="Radioactivity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Radioactivity unit value.</returns>
        public static Radioactivity From(double value, RadioactivityUnit fromUnit)
        {
            return new Radioactivity(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(RadioactivityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Radioactivity to another Radioactivity with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Radioactivity with the specified unit.</returns>
                public Radioactivity ToUnit(RadioactivityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Radioactivity(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        RadioactivityUnit.Becquerel => _value,
                        RadioactivityUnit.Curie => _value * 3.7e10,
                        RadioactivityUnit.Exabecquerel => (_value) * 1e18d,
                        RadioactivityUnit.Gigabecquerel => (_value) * 1e9d,
                        RadioactivityUnit.Gigacurie => (_value * 3.7e10) * 1e9d,
                        RadioactivityUnit.Gigarutherford => (_value * 1e6) * 1e9d,
                        RadioactivityUnit.Kilobecquerel => (_value) * 1e3d,
                        RadioactivityUnit.Kilocurie => (_value * 3.7e10) * 1e3d,
                        RadioactivityUnit.Kilorutherford => (_value * 1e6) * 1e3d,
                        RadioactivityUnit.Megabecquerel => (_value) * 1e6d,
                        RadioactivityUnit.Megacurie => (_value * 3.7e10) * 1e6d,
                        RadioactivityUnit.Megarutherford => (_value * 1e6) * 1e6d,
                        RadioactivityUnit.Microbecquerel => (_value) * 1e-6d,
                        RadioactivityUnit.Microcurie => (_value * 3.7e10) * 1e-6d,
                        RadioactivityUnit.Microrutherford => (_value * 1e6) * 1e-6d,
                        RadioactivityUnit.Millibecquerel => (_value) * 1e-3d,
                        RadioactivityUnit.Millicurie => (_value * 3.7e10) * 1e-3d,
                        RadioactivityUnit.Millirutherford => (_value * 1e6) * 1e-3d,
                        RadioactivityUnit.Nanobecquerel => (_value) * 1e-9d,
                        RadioactivityUnit.Nanocurie => (_value * 3.7e10) * 1e-9d,
                        RadioactivityUnit.Nanorutherford => (_value * 1e6) * 1e-9d,
                        RadioactivityUnit.Petabecquerel => (_value) * 1e15d,
                        RadioactivityUnit.Picobecquerel => (_value) * 1e-12d,
                        RadioactivityUnit.Picocurie => (_value * 3.7e10) * 1e-12d,
                        RadioactivityUnit.Picorutherford => (_value * 1e6) * 1e-12d,
                        RadioactivityUnit.Rutherford => _value * 1e6,
                        RadioactivityUnit.Terabecquerel => (_value) * 1e12d,
                        RadioactivityUnit.Teracurie => (_value * 3.7e10) * 1e12d,
                        RadioactivityUnit.Terarutherford => (_value * 1e6) * 1e12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(RadioactivityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        RadioactivityUnit.Becquerel => baseUnitValue,
                        RadioactivityUnit.Curie => baseUnitValue / 3.7e10,
                        RadioactivityUnit.Exabecquerel => (baseUnitValue) / 1e18d,
                        RadioactivityUnit.Gigabecquerel => (baseUnitValue) / 1e9d,
                        RadioactivityUnit.Gigacurie => (baseUnitValue / 3.7e10) / 1e9d,
                        RadioactivityUnit.Gigarutherford => (baseUnitValue / 1e6) / 1e9d,
                        RadioactivityUnit.Kilobecquerel => (baseUnitValue) / 1e3d,
                        RadioactivityUnit.Kilocurie => (baseUnitValue / 3.7e10) / 1e3d,
                        RadioactivityUnit.Kilorutherford => (baseUnitValue / 1e6) / 1e3d,
                        RadioactivityUnit.Megabecquerel => (baseUnitValue) / 1e6d,
                        RadioactivityUnit.Megacurie => (baseUnitValue / 3.7e10) / 1e6d,
                        RadioactivityUnit.Megarutherford => (baseUnitValue / 1e6) / 1e6d,
                        RadioactivityUnit.Microbecquerel => (baseUnitValue) / 1e-6d,
                        RadioactivityUnit.Microcurie => (baseUnitValue / 3.7e10) / 1e-6d,
                        RadioactivityUnit.Microrutherford => (baseUnitValue / 1e6) / 1e-6d,
                        RadioactivityUnit.Millibecquerel => (baseUnitValue) / 1e-3d,
                        RadioactivityUnit.Millicurie => (baseUnitValue / 3.7e10) / 1e-3d,
                        RadioactivityUnit.Millirutherford => (baseUnitValue / 1e6) / 1e-3d,
                        RadioactivityUnit.Nanobecquerel => (baseUnitValue) / 1e-9d,
                        RadioactivityUnit.Nanocurie => (baseUnitValue / 3.7e10) / 1e-9d,
                        RadioactivityUnit.Nanorutherford => (baseUnitValue / 1e6) / 1e-9d,
                        RadioactivityUnit.Petabecquerel => (baseUnitValue) / 1e15d,
                        RadioactivityUnit.Picobecquerel => (baseUnitValue) / 1e-12d,
                        RadioactivityUnit.Picocurie => (baseUnitValue / 3.7e10) / 1e-12d,
                        RadioactivityUnit.Picorutherford => (baseUnitValue / 1e6) / 1e-12d,
                        RadioactivityUnit.Rutherford => baseUnitValue / 1e6,
                        RadioactivityUnit.Terabecquerel => (baseUnitValue) / 1e12d,
                        RadioactivityUnit.Teracurie => (baseUnitValue / 3.7e10) / 1e12d,
                        RadioactivityUnit.Terarutherford => (baseUnitValue / 1e6) / 1e12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

