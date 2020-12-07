using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassSOAPWS
{
    public class TeacherClass
    {
        public String Name { get; set; }
        public String Subject { get; set; }
        public String Username { get; set; }
        public String User_Type { get; set; }

        //Default Class Constructor
        public TeacherClass()
        {

        }

        //parameterized constructor
        public TeacherClass(String name, String subject, String username, String usertype)
        {
            this.Name = name;
            this.Subject = subject;
            this.Username = username;
            this.User_Type = usertype;
        }
    }
}