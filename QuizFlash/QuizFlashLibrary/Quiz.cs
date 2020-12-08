using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFlashLibrary
{
    public class Quiz
    {
        private int quizID;
        private String quizName;
        private String quizClass;
        private String quizSubject;
        private String quizTeacher;
        private String quizFlashcardSet;
        private String password;

        public int QuizID { get => quizID; set => quizID = value; }
        public string QuizName { get => quizName; set => quizName = value; }
        public string QuizClass { get => quizClass; set => quizClass = value; }
        public string QuizSubject { get => quizSubject; set => quizSubject = value; }
        public string QuizTeacher { get => quizTeacher; set => quizTeacher = value; }
        public string QuizFlashcardSet { get => quizFlashcardSet; set => quizFlashcardSet = value; }
        public string Password { get => password; set => password = value; }

        public Quiz()
        {

        }



    }
}
