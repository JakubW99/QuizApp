using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
   public class QuizItem
    {
        public int Id { get; }
        public string Question { get;}
        public string Title { get; }
        public string CorrrectAnswer { get; }
        public List<string> IncorrectAnswers { get; }

        public QuizItem(int id, string question, string title, string corrrectAnswer, List<string> incorrectAnswers)
        {
            Id = id;
            Question = question;
            Title = title;
            CorrrectAnswer = corrrectAnswer;
            IncorrectAnswers = incorrectAnswers;
        }
    }
}
