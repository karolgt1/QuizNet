﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizNet.BusinessLogic.DTOs;

namespace QuizNet.Models
{
    public class QuizViewModel
    {
        public QuizViewModel()
        {
            
        }

        public QuizViewModel(List<QuestionDto> questions)
        {
            Questions = questions;
            UserAnswerIds = new int[Questions.Count];
        }
        public List<QuestionDto> Questions { get; set; }
        public int[] UserAnswerIds { get; set; }
    }
}