// <copyright file="DataReaderExtensions.cs" company="Aitron">
// Copyright (c) Aitron. All rights reserved.
// </copyright>

using System;
using System.Data;

namespace Aitron.EFCore.GenericRepository
{
    internal static class DataReaderExtensions
    {
        public static bool ColumnExists(this IDataReader reader, string columnName)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
