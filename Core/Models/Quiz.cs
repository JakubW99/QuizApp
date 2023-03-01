using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public  class Quiz
    {
        public int Id;
        public string Title { get; }
        public List<QuizItem> Items { get; }


    }
}
