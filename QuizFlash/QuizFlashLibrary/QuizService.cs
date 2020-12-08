using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFlashLibrary
{
    public class QuizService
    {
        DBConnect db = new DBConnect();

        public List<Quiz> GetQuizzesByClass(String className)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "TP_GetQuizzesByClass";
            sqlCmd.Parameters.AddWithValue("ClassName", className);
            
            DataSet ds = db.GetDataSetUsingCmdObj(sqlCmd);

            List<Quiz> theQuizzes = new List<Quiz>();
            Quiz theQuiz;

            foreach (DataRow record in ds.Tables[0].Rows)
            {
                theQuiz = new Quiz();
                theQuiz.QuizName = record["Name"].ToString();
                
                theQuizzes.Add(theQuiz);
            }


            return theQuizzes;

        }

        public String GetFlashcardSetName(String quizName)
        {
            String ret = "";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "TP_GetFlashcardSetName";
            sqlCmd.Parameters.AddWithValue("QuizName", quizName);

            DataSet ds = db.GetDataSetUsingCmdObj(sqlCmd);

            Quiz quiz = new Quiz();

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow record;
                record = ds.Tables[0].Rows[0];
                quiz.QuizFlashcardSet = record["Flashcard_Set"].ToString();

            }


            return quiz.QuizFlashcardSet.ToString();
        }

        


    } // class
} // ns
