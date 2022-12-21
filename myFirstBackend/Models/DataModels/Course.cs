namespace UniversityApiBackend.Models.DataModels;

using myFirstBackend.Models.DataModels;
using System.ComponentModel.DataAnnotations;
using UniversityApiBackend.Models.Enums;

public class Course : BaseEntity
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required, StringLength(280)]
    public string ShortDescription { get; set; } = string.Empty;

    [Required]
    public string LongDescription { get; set; } = string.Empty;

    [Required]
    public string TargetPeople { get; set; } = string.Empty;

    [Required]
    public string Objetives { get; set; } = string.Empty;

    [Required]
    public Levels Level { get; set; }
}
