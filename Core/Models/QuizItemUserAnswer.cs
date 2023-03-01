using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
 public class QuizItemUserAnswer
    {

        public int QuizId { get; }
        public int UserId { get; }
        public QuizItem QuizItem { get; }

        public string Answer { get; }

        public bool isCorrect()
        {
            return Answer.Equals(QuizItem.CorrrectAnswer);
        }
    }
}
