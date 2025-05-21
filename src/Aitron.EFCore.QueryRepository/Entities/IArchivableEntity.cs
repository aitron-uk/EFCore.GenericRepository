namespace Aitron.EFCore.GenericRepository.Entities;

public abstract class IArchivableEntity: IEntity
{
    public bool IsArchived { get; set; }
}