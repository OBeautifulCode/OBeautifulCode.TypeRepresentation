﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeepCloneExtensions.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.Type.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Type.Recipes
{
    using global::System;
    using global::System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.CodeAnalysis.Recipes;

    /// <summary>
    /// Extension methods to deep clone various types.
    /// </summary>
#if !OBeautifulCodeTypeSolution
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.Type.Recipes", "See package version number")]
    internal
#else
    public
#endif
    static class DeepCloneExtensions
    {
        /// <summary>
        /// Deep clones a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">The value to deep clone.</param>
        /// <returns>
        /// A deep clone of the specified value.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1057:StringUriOverloadsCallSystemUriOverloads", Justification = ObcSuppressBecause.CA_ALL_NotApplicable)]
        public static string DeepClone(
            this string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            // string should be cloned using it's existing interface.
            // note that this just returns the same reference, it doesn't result in a new reference
            // the ToString() is needed because Clone() returns an Object.
            // https://stackoverflow.com/questions/3465377/whats-the-use-of-string-clone
            var result = value.Clone().ToString();

            return result;
        }

        /// <summary>
        /// Deep clones a <see cref="Version"/> value.
        /// </summary>
        /// <param name="value">The value to deep clone.</param>
        /// <returns>
        /// A deep clone of the specified value.
        /// </returns>
        public static Version DeepClone(
            this Version value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var result = (Version)value.Clone();

            return result;
        }

        /// <summary>
        /// Deep clones a <see cref="Uri"/> value.
        /// </summary>
        /// <param name="value">The value to deep clone.</param>
        /// <returns>
        /// A deep clone of the specified value.
        /// </returns>
        public static Uri DeepClone(
            this Uri value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            // Not entirely sure how to deep clone a relative URI,
            // which is why we are not simply calling new Uri(value.ToString(), UriKind.RelativeOrAbsolute)
            var result = value.IsAbsoluteUri
                ? new Uri(value.AbsoluteUri, UriKind.Absolute)
                : new Uri(value.ToString(), UriKind.Relative);

            return result;
        }
    }
}
