// <copyright file="Specification.cs" company="TanvirArjel">
// Copyright (c) TanvirArjel. All rights reserved.
// </copyright>

using TanvirArjel.EFCore.GenericRepository.Entities;

namespace TanvirArjel.EFCore.GenericRepository
{
    /// <summary>
    /// This object hold the query specifications.
    /// </summary>
    /// <typeparam name="T">The database entity.</typeparam>
    public class Specification<T> : SpecificationBase<T>
        where T : IEntity
    {
        /// <summary>
        /// Gets or sets the value of number of item you want to skip in the query.
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// Gets or sets the value of number of item you want to take in the query.
        /// </summary>
        public int? Take { get; set; }
    }
}
