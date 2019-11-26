using Microsoft.AspNetCore.Mvc;
using QuizNet.DataAccess;
using QuizNet.DataAccess.Models;

namespace QuizNet.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionsRepository _questionRepository;

        public QuestionController(IQuestionsRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public IActionResult GetAll()
        {
            var questions = _questionRepository.GetAll();
            return View(questions);
        }

        public IActionResult Get(int id)
        {
            var question = _questionRepository.GetById(id);
            return View(question);
        }

        public IActionResult Delete(int id)
        {
            _questionRepository.Delete(id);
            return RedirectToAction("GetAll");
        }

        public IActionResult Create()
        {
            var newQuestion = new Question();
            return View("QuestionForm",newQuestion);
        }
        public IActionResult Edit(int id)
        {
            var questionToEdit = _questionRepository.GetById(id);
            return View("QuestionForm", questionToEdit);
        }

        [HttpPost]
        public IActionResult Save(Question updatedQuestion)
        {
            if (updatedQuestion.Id != 0)
                _questionRepository.Update(updatedQuestion);
            else
                _questionRepository.Add(updatedQuestion);

            return RedirectToAction("Get", new { Id = updatedQuestion.Id });
        }
    }
}