using System;

namespace Aitron.EFCore.GenericRepository.Entities;

public interface IEntity
{
    Guid Id { get; }

    DateTime DateCreated { get; set; }

    DateTime DateModified { get; set; }
}