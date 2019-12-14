using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuizNet.DataAccess.Models;

namespace QuizNet.DataAccess
{
    public class InMemoryQuestionRepository : IQuestionsRepository
    {
        //private static readonly List<Question> _questions = new List<Question>()
        //{
        //    new Question()
        //    {
        //        Id = 1,
        //        Text = "Jakie jest hasło admia?",
        //        CorrectAnswerIndex = 1,
        //        Time = new DateTime(2019,11,20,15,36,46),
        //        Answers = new Answer[]
        //        {
        //            new Answer()
        //            {
        //                Id = 1,
        //                QuestionId = 1,
        //                Text = "qwerty"
        //            },
        //            new Answer()
        //            {
        //                Id = 2,
        //                QuestionId = 1,
        //                Text = "admin"
        //            },
        //            new Answer()
        //            {
        //                Id = 3,
        //                QuestionId = 1,
        //                Text = "haslo1"
        //            },
        //            new Answer()
        //            {
        //                Id = 4,
        //                QuestionId = 1,
        //                Text = "123"
        //            }
        //        }
        //    },
        //    new Question()
        //    {
        //        Id = 2,
        //        Text = "Jaki jest najlepszy język programowania?",
        //        CorrectAnswerIndex = 2,
        //        Time = new DateTime(2019,11,24,17,39,53),
        //        Answers = new Answer[]
        //        {
        //            new Answer()
        //            {
        //                Id = 5,
        //                QuestionId = 2,
        //                Text = "HTML"
        //            },
        //            new Answer()
        //            {
        //                Id = 6,
        //                QuestionId = 2,
        //                Text = "Java"
        //            },
        //            new Answer()
        //            {
        //                Id = 7,
        //                QuestionId = 2,
        //                Text = "C#"
        //            },
        //            new Answer()
        //            {
        //                Id = 8,
        //                QuestionId = 2,
        //                Text = "JavaScript"
        //            }
        //        }
        //    },
        //    new Question()
        //    {
        //        Id = 3,
        //        Text = "Jakiej metody HTTP używamy aby pobrać dane z serwera?",
        //        CorrectAnswerIndex = 3,
        //        Time = new DateTime(2019,11,27,13,12,26),
        //        Answers = new Answer[]
        //        {
        //            new Answer()
        //            {
        //                Id = 9,
        //                QuestionId = 3,
        //                Text = "POST"
        //            },
        //            new Answer()
        //            {
        //                Id = 10,
        //                QuestionId = 3,
        //                Text = "PUT"
        //            },
        //            new Answer()
        //            {
        //                Id = 11,
        //                QuestionId = 3,
        //                Text = "DELETE"
        //            },
        //            new Answer()
        //            {
        //                Id = 12,
        //                QuestionId = 3,
        //                Text = "GET"
        //            },
        //        }
        //    },
        //    new Question()
        //    {
        //        Id = 4,
        //        Text = "Na jakim systemie operacyjnym możemy uruchomić aplikację napisaną w .NET Core?",
        //        Time = new DateTime(2019,10,12,18,31,16),
        //        CorrectAnswerIndex = 3,
        //        Answers = new Answer[]
        //        {
        //            new Answer()
        //            {
        //                Id = 13,
        //                QuestionId = 4,
        //                Text = "Windows"
        //            },
        //            new Answer()
        //            {
        //                Id = 14,
        //                QuestionId = 4,
        //                Text = "Linux"
        //            },
        //            new Answer()
        //            {
        //                Id = 15,
        //                QuestionId = 4,
        //                Text = "Mac OS"
        //            },
        //            new Answer()
        //            {
        //                Id = 16,
        //                QuestionId = 4,
        //                Text = "Wszystkie wymienione"
        //            },
        //        }
        //    },
        //    new Question()
        //    {
        //        Id = 5,
        //        Text = "Które zdanie najlepiej opisuje kontroler?",
        //        Time = new DateTime(2019,11,12,11,16,46),
        //        CorrectAnswerIndex = 2,
        //        Answers = new Answer[]
        //        {
        //            new Answer()
        //            {
        //                Id = 17,
        //                QuestionId = 5,
        //                Text = "Wykonuje operacje przeszukiwania i modyfikacji bazy danych"
        //            },
        //            new Answer()
        //            {
        //                Id = 18,
        //                QuestionId = 5,
        //                Text = "Realizuje algorytmy sztucznej inteligencji"
        //            },
        //            new Answer()
        //            {
        //                Id = 19,
        //                QuestionId = 5,
        //                Text = "Odpowiada na zapytania wysyłane przez klienta"
        //            },
        //            new Answer()
        //            {
        //                Id = 20,
        //                QuestionId = 5,
        //                Text = "Tworzy instancje obiektów zainicjalizowane w kontenerze DI"
        //            },
        //        }
        //    }
        //};
        public IEnumerable<Question> GetAll()
        {
            throw new NotImplementedException();
        }

        public Question GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Question question)
        {
            throw new NotImplementedException();
        }

        public void Update(Question updatedQuestion)
        {
            throw new NotImplementedException();
        }

        public void Delete(int questionId)
        {
            throw new NotImplementedException();
        }
    }
}
