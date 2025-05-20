// <copyright file="StateFilter.cs" company="TanvirArjel">
// Copyright (c) TanvirArjel. All rights reserved.
// </copyright>

namespace TanvirArjel.EFCore.GenericRepository
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