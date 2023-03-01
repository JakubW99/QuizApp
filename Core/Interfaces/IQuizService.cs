using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IQuizService
    {
        Quiz FindByID(int id);
        void SaveQuizItemUserAnswer(QuizItemUserAnswer answer);

        int CountCorrectAnswerForQuizAndUser(int quizId, int userId);
    }
}
