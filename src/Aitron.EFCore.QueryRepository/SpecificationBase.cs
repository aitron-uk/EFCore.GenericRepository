﻿// <copyright file="SpecificationBase.cs" company="Aitron">
// Copyright (c) Aitron. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using Hazelnut.EFCore.GenericRepository.Entities;

namespace Hazelnut.EFCore.GenericRepository
{
    /// <summary>
    /// This object hold the query specifications.
    /// </summary>
    /// <typeparam name="T">The database entity.</typeparam>
    public class SpecificationBase<T>
        where T : IEntity
    {
        /// <summary>
        /// Gets or sets the <see cref="Expression{TDelegate}"/> list you want to pass with your EF Core query.
        /// </summary>
        public List<Expression<Func<T, bool>>> Conditions { get; set; } = new List<Expression<Func<T, bool>>>();

        /// <summary>
        /// Gets or sets the navigation entities to be eager loaded with EF Core query.
        /// </summary>
        public Func<IQueryable<T>, IIncludableQueryable<T, object>> Includes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Func{T, TResult}"/> to order by your query.
        /// </summary>
        public Func<IQueryable<T>, IOrderedQueryable<T>> OrderBy { get; set; }

        /// <summary>
        /// Gets or sets dynamic order by option in string format.
        /// </summary>
        public (string ColumnName, string SortDirection) OrderByDynamic { get; set; }


        /// <summary>
        /// Gets or sets StateFilter option.
        /// </summary>
        public StateFilter StateFilter { get; set; } = StateFilter.Active;
    }
}