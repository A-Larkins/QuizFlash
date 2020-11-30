using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFlashLibrary
{
    public class FlashcardSetClass
    {

        public String nameOfFlashcardSet;
        public String subjectOfFlashcardSet;
        public String usernameOfFlashcardSet;

        public FlashcardSetClass()
        {

        }

        public FlashcardSetClass(String flashcardSetName, String subject, String username)
        {
            this.nameOfFlashcardSet = flashcardSetName;
            this.subjectOfFlashcardSet = subject;
            this.usernameOfFlashcardSet = username;
        }


    }
}
