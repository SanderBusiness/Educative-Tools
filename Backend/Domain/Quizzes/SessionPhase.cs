namespace Domain.Quizzes;

public enum SessionPhase
{
    Created = 0,
    Ready = 1,
    Started = 2,
    Finished = 3,
    Expired = 4,
}