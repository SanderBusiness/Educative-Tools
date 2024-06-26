using System.ComponentModel.DataAnnotations;
using Domain.Abstract;

namespace Domain.Quizzes;

/// <summary>
/// Represents an option to a quiz question
/// </summary>
public class Option : Entity
{
    [MaxLength(255)] public required string Text { get; set; }
    public bool IsCorrect { get; set; }
    
    public required Question Question { get; set; }
}