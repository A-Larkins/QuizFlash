using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFlashLibrary
{
    [Serializable]

    public class FlashcardClass
    {

        private int flashcardID;
        private String flashcardSet;
        private String flashcardSubject;
        private String flashcardQuestion;
        private String flashcardAnswer;
        private String flashcardImage;
        private String flashcardUsername;

        public FlashcardClass()
        {

        }

        public FlashcardClass(int flashcardID, String flashcardSet, String flashcardSubject,
            String flashcardQuestion, String flashcardAnswer, String flashcardImage, String flashcardUsername)
        {
            this.FlashcardID = flashcardID;
            this.FlashcardSet = flashcardSet;
            this.FlashcardSubject = flashcardSubject;
            this.FlashcardQuestion = flashcardQuestion;
            this.FlashcardAnswer = flashcardAnswer;
            this.FlashcardImage = flashcardImage;
            this.FlashcardUsername = flashcardUsername;
        }

        public int FlashcardID { get => flashcardID; set => flashcardID = value; }
        public string FlashcardSet { get => flashcardSet; set => flashcardSet = value; }
        public string FlashcardSubject { get => flashcardSubject; set => flashcardSubject = value; }
        public string FlashcardQuestion { get => flashcardQuestion; set => flashcardQuestion = value; }
        public string FlashcardAnswer { get => flashcardAnswer; set => flashcardAnswer = value; }
        public string FlashcardImage { get => flashcardImage; set => flashcardImage = value; }
        public string FlashcardUsername { get => flashcardUsername; set => flashcardUsername = value; }

    }
}
