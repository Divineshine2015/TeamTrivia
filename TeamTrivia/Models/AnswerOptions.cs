using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamTrivia.Models
{
    public class AnswerOptions
    {

        public int Id { get; set; }
        public string Answers { get; set; }

        

        // Foreign Key
        public int TrueAnswerId { get; set; }
        // Navigation property
        public virtual TriviaQuestions TrueAnswer { get; set; }
    }
    public class AnswerOptionDTO
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }
    }
}