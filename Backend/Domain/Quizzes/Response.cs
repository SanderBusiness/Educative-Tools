using Domain.Abstract;

namespace Domain.Quizzes;

/// <summary>
/// The Participator's pick to an Option in a Question
/// </summary>
public class Response : Entity
{
    public required Participator Participator { get; set; }
    public Option? Option { get; set; }
}