﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizNet.BusinessLogic.DTOs;

namespace QuizNet.Models
{
    public class QuizSummaryViewModel
    {
        public List<QuestionDto> Questions { get; set; }
        public int[] UserAnswersIndex { get; set; }
        public int CorrectAnswers { get; set; }
        public double PercentageCorrect => 100 * (double)CorrectAnswers / Questions.Count;

        public string SummaryText
        {
            get
            {
                if (PercentageCorrect > 50)
                {
                    return "Well done!";
                }
                else
                {
                    return "So bad!";
                }
            }
        }

        public string ProgressBarColor
        {
            get
            {
                if (PercentageCorrect > 50)
                {
                    return "bg-success";
                }
                else
                {
                    return "bg-danger";
                }
            }
        }

        public string ClassNamesForAnswer(int questionIndex, int answerIndex)
        {
            if (Questions[questionIndex].CorrectAnswerIndex == answerIndex)
            {
                return "list-group-item-success";
            }
            else if (UserAnswersIndex[questionIndex] == answerIndex)
            {
                return "list-group-item-danger";
            }
            else
            {
                return "";
            }
        }
    }
}