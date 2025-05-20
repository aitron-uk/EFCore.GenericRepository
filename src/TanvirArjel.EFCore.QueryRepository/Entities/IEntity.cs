using System;

namespace TanvirArjel.EFCore.GenericRepository.Entities;

public abstract class IEntity
{
    Guid Id { get; }

    DateTime DateCreated { get; set; }

    DateTime DateModified { get; set; }
}