using System.Collections.Generic;
using QuizNet.BusinessLogic.DTOs;

namespace QuizNet.BusinessLogic.Interfaces
{
    public interface IQuestionService
    {
        List<QuestionDto> GetAll();
        QuestionDto GetById(int id);
        QuestionDto Add(QuestionDto questionDto);
        void Update(QuestionDto questionDto);
        void Delete(int id);

    }
}