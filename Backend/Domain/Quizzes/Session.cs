using Domain.Abstract;
using Domain.Authentication;

namespace Domain.Quizzes;

/// <summary>
/// Represents a quiz session started by a User.
/// </summary>
public class Session : Entity
{
    public SessionPhase Phase { get; set; } = SessionPhase.Created;
    public DateTimeOffset? QuestionEndsAt { get; set; } // A response to the CurrentQuestion should not be accepted after this
    
    public required Quiz Quiz { get; set; }
    public required Question CurrentQuestion { get; set; } // Current visible question in the quiz
    public required ApplicationUser Admin { get; set; }
    public DateTimeOffset? StartedOn { get; set; }

    public ICollection<Participator> Participators { get; set; } = new HashSet<Participator>();
}