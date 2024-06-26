using DAL.EF;
using DAL.Generic;
using DAL.Repositories.Interfaces;
using Domain.Quizzes;

namespace DAL.Repositories.Implementations;

public class QuizRepository(ApplicationContext db) : EntityRepository<Quiz, Guid>(db), IQuizRepository
{
    
}