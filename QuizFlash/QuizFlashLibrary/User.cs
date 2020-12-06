using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFlashLibrary
{
    public class User
    {

        private int userID;
        private String username;
        private String password;
        private String firstName;
        private String lastName;
        private String userType;
        private String email;
        private String question1;
        private String answer1;
        private String question2;
        private String answer2;
        private String question3;
        private String answer3;

        public User()
        {

        }
        

        public int UserID { get => userID; set => userID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserType { get => userType; set => userType = value; }
        public string Email { get => email; set => email = value; }
        public string Question1 { get => question1; set => question1 = value; }
        public string Answer1 { get => answer1; set => answer1 = value; }
        public string Question2 { get => question2; set => question2 = value; }
        public string Answer2 { get => answer2; set => answer2 = value; }
        public string Question3 { get => question3; set => question3 = value; }
        public string Answer3 { get => answer3; set => answer3 = value; }
    }
}
