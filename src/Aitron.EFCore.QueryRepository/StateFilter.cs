// <copyright file="StateFilter.cs" company="Aitron">
// Copyright (c) Aitron. All rights reserved.
// </copyright>

namespace Hazelnut.EFCore.GenericRepository
{
    /// <summary>
    /// Enum to set record state.
    /// </summary>
    public enum StateFilter
    {
        /// <summary>
        /// Returns only active records.
        /// </summary>
        Active,

        /// <summary>
        /// Returns only archived records.
        /// </summary>
        Archived,

        /// <summary>
        /// Returns all records.
        /// </summary>
        All,
    }
}