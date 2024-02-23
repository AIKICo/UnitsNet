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

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToRadiationEquivalentDose
{
    /// <summary>
    /// A number to RadiationEquivalentDose Extensions
    /// </summary>
    public static class NumberToRadiationEquivalentDoseExtensions
    {
        /// <inheritdoc cref="RadiationEquivalentDose.FromMicrosieverts(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDose Microsieverts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDose.FromMicrosieverts(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDose.FromMilliroentgensEquivalentMan(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDose MilliroentgensEquivalentMan<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDose.FromMilliroentgensEquivalentMan(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDose.FromMillisieverts(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDose Millisieverts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDose.FromMillisieverts(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDose.FromNanosieverts(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDose Nanosieverts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDose.FromNanosieverts(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDose.FromRoentgensEquivalentMan(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDose RoentgensEquivalentMan<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDose.FromRoentgensEquivalentMan(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDose.FromSieverts(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDose Sieverts<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDose.FromSieverts(Convert.ToDouble(value));

    }
}