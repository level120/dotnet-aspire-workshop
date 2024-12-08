using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public sealed class RentalOfficeModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid OfficeId { get; init; }

    [Required]
    [MaxLength(100)]
    public required string Name { get; init; } = null!;

    [Required]
    [MaxLength(100)]
    public required string Region { get; init; } = null!;

    public double? Latitude { get; init; }

    public double? Longitude { get; init; }
}