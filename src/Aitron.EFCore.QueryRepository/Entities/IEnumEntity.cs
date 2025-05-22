namespace Aitron.EFCore.GenericRepository.Entities;

public interface IEnumEntity : IArchivableEntity
{
    public string Name { get; set; }
}