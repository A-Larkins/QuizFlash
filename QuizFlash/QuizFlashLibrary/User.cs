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

    }
}
