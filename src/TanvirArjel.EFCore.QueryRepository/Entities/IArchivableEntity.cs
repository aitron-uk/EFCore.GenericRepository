namespace TanvirArjel.EFCore.GenericRepository.Entities;

public interface IArchivableEntity: IEntity
{
    public bool IsArchived { get; set; }
}