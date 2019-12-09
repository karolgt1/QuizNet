using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using QuizNet.BusinessLogic.DTOs;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using QuizNet.DataAccess.Models;
using AutoMapper;

namespace QuizNet.BusinessLogic
{
    public class QuizService : IQuizService
    {
        private readonly IQuestionsRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuizService(IQuestionsRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }
        public List<QuestionDto> GenerateQuiz()
        {
            List<Question> questions = _questionRepository.GetAll().ToList();
            List<Question> randomQuestions = questions.OrderBy(x => Guid.NewGuid()).Take(3).ToList();

            List<QuestionDto> randomQuestionsDto = _mapper.Map<List<QuestionDto>>(randomQuestions);
            return randomQuestionsDto;
        }

        public List<QuestionDto> GenerateRecentlyAddedQuestionsQuiz()
        {
            List<Question> questions = _questionRepository.GetAll().ToList();
            questions.Sort((x,y) => DateTime.Compare(y.Time,x.Time));
            List<Question> recentlyQuestions = questions.Take(3).ToList();
            List<QuestionDto> recentlyQuestionsDtos = _mapper.Map<List<QuestionDto>>(recentlyQuestions);
            return recentlyQuestionsDtos;
        }

        public int CheckQuiz(List<QuestionDto> questions, int[] userAnswers)
        {
            int correctAnswers = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                questions[i] = _mapper.Map<QuestionDto>(_questionRepository.GetById(questions[i].Id));
            }

            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].CorrectAnswerIndex == userAnswers[i])
                {
                    correctAnswers++;
                }
            }

            return correctAnswers;
        }
    }
}
