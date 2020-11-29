using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashcardsWebAPI.Models
{
    public class FlashcardSet
    {

        private String flashcardSetName;
        private String subject;
        private String username;

        public string FlashcardSetName { get => flashcardSetName; set => flashcardSetName = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Username { get => username; set => username = value; }

        public FlashcardSet()
        {

        }

    }
}
