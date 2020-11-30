using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Serialization;

namespace QuizFlashLibrary
{
    public class FlashcardSetClass
    {
        public String NameOfFlashcardSet { get; set; }
        public String SubjectOfFlashcardSet { get; set; }
        public String UsernameOfFlashcardSet { get; set; }

        public FlashcardSetClass()
        {

        }
        
        public FlashcardSetClass(String name, String subject, String username)
        {
            this.NameOfFlashcardSet = name;
            this.SubjectOfFlashcardSet = subject;
            this.UsernameOfFlashcardSet = username;
        }

    }
}
