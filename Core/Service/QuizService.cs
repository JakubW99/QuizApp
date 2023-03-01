using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class QuizService : IQuizService
    {
        private IGenericRepository<QuizItemUserAnswer> _userAnswerRepository;
        private IGenericRepository<Quiz> _quizRepository;

        public QuizService(IGenericRepository<QuizItemUserAnswer> userAnswerRepository, IGenericRepository<Quiz> quizRepository)
        {
            _userAnswerRepository = userAnswerRepository;
            _quizRepository = quizRepository;
        }

        public int CountCorrectAnswerForQuizAndUser(int quizId, int userId)
        {
            return _userAnswerRepository.GetAll()
                 .Where(x => x.QuizId == quizId)
                 .Where(x => x.UserId == userId)
                  .Count(x => x.isCorrect());
        }

        public Quiz FindByID(int id)
        {
            return _quizRepository.Find(id);
        }

        public void SaveQuizItemUserAnswer(QuizItemUserAnswer answer)
        {
            _userAnswerRepository.Add(answer);
        }
    }
}
