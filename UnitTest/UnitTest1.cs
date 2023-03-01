using Core.Interfaces;
using Core.Models;
using Core.Service;
using Infrastructure;

namespace UnitTest
{
    public class UnitTest1
    {
        IQuizService service = new QuizService(
            new MemoryGenericRepository<QuizItemUserAnswer>(),
            new MemoryGenericRepository<Quiz>()
            );
        [Fact]
        public void GetAllFromQuizService()
        {

        }
    }
}