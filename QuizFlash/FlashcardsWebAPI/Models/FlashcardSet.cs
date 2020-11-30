using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json.Serialization;

namespace FlashcardsWebAPI.Models
{
    public class FlashcardSet
    {

        public String NameOfFlashcardSet { get; set; }
        public String SubjectOfFlashcardSet { get; set; }
        public String UsernameOfFlashcardSet { get; set; }


        public FlashcardSet()
        {

        }

        public FlashcardSet(String flashcardSetName, String subject, String username)
        {
            this.NameOfFlashcardSet = flashcardSetName;
            this.SubjectOfFlashcardSet = subject;
            this.UsernameOfFlashcardSet = username;
        }

    }
}
