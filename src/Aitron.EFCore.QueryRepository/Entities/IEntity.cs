using System;

namespace Hazelnut.EFCore.GenericRepository.Entities;

public interface IEntity
{
    Guid Id { get; set; }

    DateTime DateCreated { get; set; }

    DateTime DateModified { get; set; }
}