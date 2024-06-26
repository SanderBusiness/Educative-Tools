using System.ComponentModel.DataAnnotations;
using Domain.Abstract;
using Domain.Authentication;

namespace Domain.Quizzes;

/// <summary>
/// Represents a set of questions
/// </summary>
public class Quiz : Entity
{
    [MaxLength(255)] public string Title { get; set; } = null!;
    [MaxLength(3000)] public string? Description { get; set; }
    
    public required ApplicationUser Creator { get; set; }
    
    public ICollection<Question> Questions { get; set; } = new HashSet<Question>();
}