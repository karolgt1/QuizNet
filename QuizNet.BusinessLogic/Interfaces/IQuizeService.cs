﻿using System.Collections.Generic;
using QuizNet.BusinessLogic.DTOs;
using QuizNet.DataAccess.Models;

namespace QuizNet.BusinessLogic.Interfaces
{
    public interface IQuizService
    {
        List<QuestionDto> GenerateQuiz();
        List<QuestionDto> GenerateRecentlyAddedQuestionsQuiz();
        int CheckQuiz(List<QuestionDto> questions, int[] userAnswers);
    }
}
