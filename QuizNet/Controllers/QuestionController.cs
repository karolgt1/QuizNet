using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using QuizNet.BusinessLogic.DTOs;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.Models;


namespace QuizNet.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;

        public QuestionController(IQuestionService questionService, IQuizService quizService)
        {
            _questionService = questionService;
            _quizService = quizService;
        }

        public IActionResult GetAll()
        {
            var questions = _questionService.GetAll();
            return View(questions);
        }

        public IActionResult Get(int id)
        {
            var question = _questionService.GetById(id);
            return View(question);
        }

        public IActionResult Delete(int id)
        {
            _questionService.Delete(id);
            return RedirectToAction("GetAll");
        }

        public IActionResult Create()
        {
            var newQuestion = new QuestionFormViewModel();
            return View("QuestionForm",newQuestion);
        }
        public IActionResult Edit(int id)
        {
            var questionToEdit = _questionService.GetById(id);
            var questionViewModel = new QuestionFormViewModel(questionToEdit);

            return View("QuestionForm", questionViewModel);
        }

        [HttpPost]
        public IActionResult Save(QuestionFormViewModel updatedQuestion)
        {
            if (!ModelState.IsValid)
            {
                return View("QuestionForm", updatedQuestion);
            }
            var question = updatedQuestion.Question;
            question.Answers[updatedQuestion.CorrectAnswerIndex].IsCorrect = true;
            if (question.Id != 0)
            {
                _questionService.Update(question);
            }
            else
            {
                question = _questionService.Add(question);
            }

            return RedirectToAction("Get", new { Id = question.Id });
        }
        public IActionResult GenerateQuiz()
        {
            List<QuestionDto> quiz = _quizService.GenerateQuiz();
            var quizViewModel = new QuizViewModel(quiz);
            return View("Quiz", quizViewModel);
        }

        public IActionResult GenerateRecentlyAddedQuestionsQuiz()
        {
            List<QuestionDto> quiz = _quizService.GenerateRecentlyAddedQuestionsQuiz();
            var quizViewModel = new QuizViewModel(quiz);
            return View("Quiz", quizViewModel);
        }
        [HttpPost]
        public IActionResult CheckQuiz(QuizViewModel quizViewModel)
        {
            
            var correctAnswers = _quizService.CheckQuiz(quizViewModel.Questions, quizViewModel.UserAnswerIds);
            var summaryViewModel = new QuizSummaryViewModel()
            {
                Questions = quizViewModel.Questions,
                UserAnswersIds = quizViewModel.UserAnswerIds,
                CorrectAnswers = correctAnswers
            };
            return View("QuizSummary", summaryViewModel);
        }
    }

}