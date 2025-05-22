using System;
using System.ComponentModel.DataAnnotations;
using Aitron.EFCore.GenericRepository.Entities;

namespace AspNetCoreApp.Data.Models;

public class Employee : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime DateModified { get; set; } = DateTime.UtcNow;

    [Key]
    public long EmployeeId { get; set; }

    public int DepartmentId { get; set; }

    [Required]
    public string EmployeeName { get; set; }

    [Required]
    public string DepartmentName { get; set; }

    public Department Department { get; set; }
}
