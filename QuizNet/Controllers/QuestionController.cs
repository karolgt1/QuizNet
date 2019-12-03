using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QuizNet.BusinessLogic.DTOs;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using QuizNet.DataAccess.Models;
using QuizNet.Models;


namespace QuizNet.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionsRepository _questionRepository;
        private readonly IQuizService _quizService;

        public QuestionController(IQuestionsRepository questionRepository, IQuizService quizService)
        {
            _questionRepository = questionRepository;
            _quizService = quizService;
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
            var newQuestion = new QuestionFormViewModel();
            return View("QuestionForm",newQuestion);
        }
        public IActionResult Edit(int id)
        {
            var questionToEdit = _questionRepository.GetById(id);
            var questionViewModel = new QuestionFormViewModel(questionToEdit);
            return View("QuestionForm", questionToEdit);
        }

        [HttpPost]
        public IActionResult Save(QuestionFormViewModel updatedQuestion)
        {
            if (!ModelState.IsValid)
                return View("QuestionForm", updatedQuestion);

            var question = updatedQuestion.GetQuestion();
            if (question.Id != 0)
                _questionRepository.Update(question);
            else
                _questionRepository.Add(question);

            return RedirectToAction("Get", new { Id = question.Id });
        }
        public IActionResult GenerateQuiz()
        {
            List<QuestionDto> quiz = _quizService.GenerateQuiz();
            return View("Quiz", quiz);
        }
    }

}