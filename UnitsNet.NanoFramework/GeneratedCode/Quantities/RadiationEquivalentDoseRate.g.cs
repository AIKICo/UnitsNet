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
    ///     A dose rate is quantity of radiation absorbed or delivered per unit time.
    /// </summary>
    public struct  RadiationEquivalentDoseRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RadiationEquivalentDoseRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public RadiationEquivalentDoseRateUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public RadiationEquivalentDoseRate(double value, RadiationEquivalentDoseRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of RadiationEquivalentDoseRate, which is Second. All conversions go via this value.
        /// </summary>
        public static RadiationEquivalentDoseRateUnit BaseUnit { get; } = RadiationEquivalentDoseRateUnit.SievertPerHour;

        /// <summary>
        /// Represents the largest possible value of RadiationEquivalentDoseRate.
        /// </summary>
        public static RadiationEquivalentDoseRate MaxValue { get; } = new RadiationEquivalentDoseRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of RadiationEquivalentDoseRate.
        /// </summary>
        public static RadiationEquivalentDoseRate MinValue { get; } = new RadiationEquivalentDoseRate(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static RadiationEquivalentDoseRate Zero { get; } = new RadiationEquivalentDoseRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadiationEquivalentDoseRateUnit.MicrosievertPerHour"/>
        /// </summary>
        public double MicrosievertsPerHour => As(RadiationEquivalentDoseRateUnit.MicrosievertPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadiationEquivalentDoseRateUnit.MilliroentgenEquivalentManPerHour"/>
        /// </summary>
        public double MilliroentgensEquivalentManPerHour => As(RadiationEquivalentDoseRateUnit.MilliroentgenEquivalentManPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadiationEquivalentDoseRateUnit.MillisievertPerHour"/>
        /// </summary>
        public double MillisievertsPerHour => As(RadiationEquivalentDoseRateUnit.MillisievertPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadiationEquivalentDoseRateUnit.NanosievertPerHour"/>
        /// </summary>
        public double NanosievertsPerHour => As(RadiationEquivalentDoseRateUnit.NanosievertPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadiationEquivalentDoseRateUnit.RoentgenEquivalentManPerHour"/>
        /// </summary>
        public double RoentgensEquivalentManPerHour => As(RadiationEquivalentDoseRateUnit.RoentgenEquivalentManPerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RadiationEquivalentDoseRateUnit.SievertPerHour"/>
        /// </summary>
        public double SievertsPerHour => As(RadiationEquivalentDoseRateUnit.SievertPerHour);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="RadiationEquivalentDoseRate"/> from <see cref="RadiationEquivalentDoseRateUnit.MicrosievertPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RadiationEquivalentDoseRate FromMicrosievertsPerHour(double microsievertsperhour) => new RadiationEquivalentDoseRate(microsievertsperhour, RadiationEquivalentDoseRateUnit.MicrosievertPerHour);

        /// <summary>
        ///     Creates a <see cref="RadiationEquivalentDoseRate"/> from <see cref="RadiationEquivalentDoseRateUnit.MilliroentgenEquivalentManPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RadiationEquivalentDoseRate FromMilliroentgensEquivalentManPerHour(double milliroentgensequivalentmanperhour) => new RadiationEquivalentDoseRate(milliroentgensequivalentmanperhour, RadiationEquivalentDoseRateUnit.MilliroentgenEquivalentManPerHour);

        /// <summary>
        ///     Creates a <see cref="RadiationEquivalentDoseRate"/> from <see cref="RadiationEquivalentDoseRateUnit.MillisievertPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RadiationEquivalentDoseRate FromMillisievertsPerHour(double millisievertsperhour) => new RadiationEquivalentDoseRate(millisievertsperhour, RadiationEquivalentDoseRateUnit.MillisievertPerHour);

        /// <summary>
        ///     Creates a <see cref="RadiationEquivalentDoseRate"/> from <see cref="RadiationEquivalentDoseRateUnit.NanosievertPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RadiationEquivalentDoseRate FromNanosievertsPerHour(double nanosievertsperhour) => new RadiationEquivalentDoseRate(nanosievertsperhour, RadiationEquivalentDoseRateUnit.NanosievertPerHour);

        /// <summary>
        ///     Creates a <see cref="RadiationEquivalentDoseRate"/> from <see cref="RadiationEquivalentDoseRateUnit.RoentgenEquivalentManPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RadiationEquivalentDoseRate FromRoentgensEquivalentManPerHour(double roentgensequivalentmanperhour) => new RadiationEquivalentDoseRate(roentgensequivalentmanperhour, RadiationEquivalentDoseRateUnit.RoentgenEquivalentManPerHour);

        /// <summary>
        ///     Creates a <see cref="RadiationEquivalentDoseRate"/> from <see cref="RadiationEquivalentDoseRateUnit.SievertPerHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RadiationEquivalentDoseRate FromSievertsPerHour(double sievertsperhour) => new RadiationEquivalentDoseRate(sievertsperhour, RadiationEquivalentDoseRateUnit.SievertPerHour);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RadiationEquivalentDoseRateUnit" /> to <see cref="RadiationEquivalentDoseRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RadiationEquivalentDoseRate unit value.</returns>
        public static RadiationEquivalentDoseRate From(double value, RadiationEquivalentDoseRateUnit fromUnit)
        {
            return new RadiationEquivalentDoseRate(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(RadiationEquivalentDoseRateUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this RadiationEquivalentDoseRate to another RadiationEquivalentDoseRate with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A RadiationEquivalentDoseRate with the specified unit.</returns>
                public RadiationEquivalentDoseRate ToUnit(RadiationEquivalentDoseRateUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new RadiationEquivalentDoseRate(convertedValue, unit);
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
                        RadiationEquivalentDoseRateUnit.MicrosievertPerHour => (_value) * 1e-6d,
                        RadiationEquivalentDoseRateUnit.MilliroentgenEquivalentManPerHour => (_value / 100) * 1e-3d,
                        RadiationEquivalentDoseRateUnit.MillisievertPerHour => (_value) * 1e-3d,
                        RadiationEquivalentDoseRateUnit.NanosievertPerHour => (_value) * 1e-9d,
                        RadiationEquivalentDoseRateUnit.RoentgenEquivalentManPerHour => _value / 100,
                        RadiationEquivalentDoseRateUnit.SievertPerHour => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(RadiationEquivalentDoseRateUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        RadiationEquivalentDoseRateUnit.MicrosievertPerHour => (baseUnitValue) / 1e-6d,
                        RadiationEquivalentDoseRateUnit.MilliroentgenEquivalentManPerHour => (baseUnitValue * 100) / 1e-3d,
                        RadiationEquivalentDoseRateUnit.MillisievertPerHour => (baseUnitValue) / 1e-3d,
                        RadiationEquivalentDoseRateUnit.NanosievertPerHour => (baseUnitValue) / 1e-9d,
                        RadiationEquivalentDoseRateUnit.RoentgenEquivalentManPerHour => baseUnitValue * 100,
                        RadiationEquivalentDoseRateUnit.SievertPerHour => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}
