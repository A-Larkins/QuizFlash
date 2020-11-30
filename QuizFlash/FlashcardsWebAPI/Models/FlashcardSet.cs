using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json.Serialization;

namespace FlashcardsWebAPI.Models
{
    public class FlashcardSet
    {

        public String nameOfFlashcardSet;
        public String subjectOfFlashcardSet;
        public String usernameOfFlashcardSet;


        public FlashcardSet()
        {

        }

        public FlashcardSet(String flashcardSetName, String subject, String username)
        {
            this.nameOfFlashcardSet = flashcardSetName;
            this.subjectOfFlashcardSet = subject;
            this.usernameOfFlashcardSet = username;
        }

    }
}
