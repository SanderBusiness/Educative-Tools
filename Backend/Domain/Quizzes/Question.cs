using System.ComponentModel.DataAnnotations;
using Domain.Abstract;

namespace Domain.Quizzes;

/// <summary>
/// Represents a part of a Quiz, one of many
/// </summary>
public class Question : Entity
{
    [MaxLength(500)] public required string Text { get; set; }
    [MaxLength(1000)] public string? Description { get; set; }
    public string? Image { get; set; }
    
    public required Quiz Quiz { get; set; }
    
    public ICollection<Option> Options { get; set; } = new HashSet<Option>();
}