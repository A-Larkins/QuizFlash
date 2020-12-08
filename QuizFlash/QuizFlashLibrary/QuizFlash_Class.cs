using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFlashLibrary
{
    public class QuizFlash_Class
    {
        String classID;
        String className;
        String classSubject;
        String classUsername;
        String classUserType;


        public QuizFlash_Class()
        {

        }

        public string ClassID { get => classID; set => classID = value; }
        public string ClassName { get => className; set => className = value; }
        public string ClassSubject { get => classSubject; set => classSubject = value; }
        public string ClassUsername { get => classUsername; set => classUsername = value; }
        public string ClassUserType { get => classUserType; set => classUserType = value; }
    } // end class
} // end ns
