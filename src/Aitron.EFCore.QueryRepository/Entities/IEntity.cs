using System;

namespace Hazelnut.EFCore.GenericRepository.Entities;

public interface IEntity
{
    Guid Id { get; }

    DateTime DateCreated { get; set; }

    DateTime DateModified { get; set; }
}