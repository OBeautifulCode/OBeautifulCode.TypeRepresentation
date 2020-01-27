﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEquatableViaCodeGen.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Type
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Type.Internal;

    /// <summary>
    /// Represents an object that is expected to be an
    /// <see cref="IEquatable{T}"/> that is implemented with generated code.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Justification = ObcSuppressBecause.CA1040_AvoidEmptyInterfaces_NeedToIdentifyGroupOfTypesAndPreferInterfaceOverAttribute)]

    // ReSharper disable once UnusedMember.Global
    public interface IEquatableViaCodeGen
    {
    }
}
