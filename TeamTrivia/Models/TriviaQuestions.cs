﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamTrivia.Models
{
    public class TriviaQuestions
    {
        public int Id { get; set; }

        public string Question { get; set; }
        public string Answer { get; set; }

        // Foreign Key
        public int AnswerId { get; set; }

    }
}