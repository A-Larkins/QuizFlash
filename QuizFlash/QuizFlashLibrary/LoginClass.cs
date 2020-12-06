﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace QuizFlashLibrary
{

    public class LoginClass
    {
        DBConnect db = new DBConnect();

        public User GetUserByUsername(String username, String userType)
        {
            User user = new User();

            if (userType == "Student")
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetStudentByUsername";

                SqlParameter inputParameter = new SqlParameter("@Username", username);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                DataSet ds = db.GetDataSetUsingCmdObj(objCommand);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        user.UserID = int.Parse(row["Student_ID"].ToString());
                        user.Username = row["Username"].ToString();
                        user.Password = row["Password"].ToString();
                        user.FirstName = row["First_Name"].ToString();
                        user.LastName = row["Last_Name"].ToString();
                        user.Email = row["Email"].ToString();
                        user.UserType = "Student";
                    }
                }
            }
            else if (userType == "Teacher")
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetTeacherByUsername";

                SqlParameter inputParameter = new SqlParameter("@Username", username);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 50;
                objCommand.Parameters.Add(inputParameter);

                DataSet ds = db.GetDataSetUsingCmdObj(objCommand);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        user.UserID = int.Parse(row["Teacher_ID"].ToString());
                        user.Username = row["Username"].ToString();
                        user.Password = row["Password"].ToString();
                        user.FirstName = row["First_Name"].ToString();
                        user.LastName = row["Last_Name"].ToString();
                        user.Email = row["Email"].ToString();
                        user.UserType = "Teacher";
                    }
                }
            }
            return user;
        }

        public int InsertStudent(User user)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_InsertStudent";

            objCommand.Parameters.AddWithValue("@Username", user.Username);
            objCommand.Parameters.AddWithValue("@Password", user.Password);
            objCommand.Parameters.AddWithValue("@FirstName", user.FirstName);
            objCommand.Parameters.AddWithValue("@LastName", user.LastName);
            objCommand.Parameters.AddWithValue("@Email", user.Email);
            objCommand.Parameters.AddWithValue("@Question1", user.Question1);
            objCommand.Parameters.AddWithValue("@Answer1", user.Answer1);
            objCommand.Parameters.AddWithValue("@Question2", user.Question2);
            objCommand.Parameters.AddWithValue("@Answer2", user.Answer2);
            objCommand.Parameters.AddWithValue("Question3", user.Question3);
            objCommand.Parameters.AddWithValue("@Answer3", user.Answer3);

            return db.DoUpdateUsingCmdObj(objCommand);
        }

        public int InsertTeacher(User user)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_InsertTeacher";

            objCommand.Parameters.AddWithValue("@Username", user.Username);
            objCommand.Parameters.AddWithValue("@Password", user.Password);
            objCommand.Parameters.AddWithValue("@FirstName", user.FirstName);
            objCommand.Parameters.AddWithValue("@LastName", user.LastName);
            objCommand.Parameters.AddWithValue("@Email", user.Email);
            objCommand.Parameters.AddWithValue("@Question1", user.Question1);
            objCommand.Parameters.AddWithValue("@Answer1", user.Answer1);
            objCommand.Parameters.AddWithValue("@Question2", user.Question2);
            objCommand.Parameters.AddWithValue("@Answer2", user.Answer2);
            objCommand.Parameters.AddWithValue("Question3", user.Question3);
            objCommand.Parameters.AddWithValue("@Answer3", user.Answer3);

            return db.DoUpdateUsingCmdObj(objCommand);
        }


    }


}
