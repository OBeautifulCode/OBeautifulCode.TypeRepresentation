﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IModelViaCodeGen.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Type
{
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;

    /// <summary>
    /// Represents an object that is expected to be an
    /// <see cref="IModel{T}"/> that is implemented with generated code.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Justification = ObcSuppressBecause.CA1040_AvoidEmptyInterfaces_NeedToIdentifyGroupOfTypesAndPreferInterfaceOverAttribute)]

    // ReSharper disable once UnusedMember.Global
    public interface IModelViaCodeGen : IDeepCloneableViaCodeGen, IEquatableViaCodeGen, IHashableViaCodeGen, IStringRepresentableViaCodeGen
    {
    }
}
