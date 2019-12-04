using AutoMapper;
using QuizNet.BusinessLogic.DTOs;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using QuizNet.DataAccess.Models;
using System.Collections.Generic;

namespace QuizNet.BusinessLogic
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionsRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionsRepository questionsRepository, IMapper mapper)
        {
            _questionRepository = questionsRepository;
            _mapper = mapper;
        }
        public List<QuestionDto> GetAll()
        {
            var questions = _questionRepository.GetAll();
            var questionDto = _mapper.Map<List<QuestionDto>>(questions);
            return questionDto;

        }

        public QuestionDto GetById(int id)
        {
            var question = _questionRepository.GetById(id);
            var questionDto = _mapper.Map<QuestionDto>(question);
            return questionDto;
        }

        public QuestionDto Add(QuestionDto questionDto)
        {
            var question = _mapper.Map<Question>(questionDto);
            _questionRepository.Add(question);

            var createdQuestion = _mapper.Map<QuestionDto>(question);
            return createdQuestion;
        }

        public void Update(QuestionDto questionDto)
        {
            var question = _mapper.Map<Question>(questionDto);
            _questionRepository.Update(question);
        }

        public void Delete(int id)
        {
            _questionRepository.Delete(id);
        }
    }
}