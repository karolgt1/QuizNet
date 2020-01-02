﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizNet.BusinessLogic.DTOs;
using QuizNet.DataAccess.Models;

namespace QuizNet.Models
{
    public class QuestionFormViewModel
    {
        public QuestionFormViewModel(QuestionDto question)
        {
            Question = question;
            CorrectAnswerIndex = Question.Answers.ToList().FindIndex(a => a.IsCorrect);
        }
        public QuestionFormViewModel()
        {
            Question = new QuestionDto();
        }





        public QuestionDto Question { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public string ActionType
        {
            get
            {
                if (Question.Id == 0)
                    return "Create";
                else
                    return "Edit";
            }
        }
    }
}