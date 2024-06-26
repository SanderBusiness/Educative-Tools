using Domain.Abstract;
using Domain.Authentication;

namespace Domain.Quizzes;

/// <summary>
/// A user who is attending a session
/// </summary>
public class Participator : Entity
{
    public required Session Session { get; set; }
    public required ApplicationUser User { get; set; }
}