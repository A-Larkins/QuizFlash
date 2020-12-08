using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFlashLibrary
{
    public class ClassService
    {

        DBConnect db = new DBConnect();

        public List<QuizFlash_Class> GetClassesByUsername(String username)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "TP_GetClassesByUsername";
            sqlCmd.Parameters.AddWithValue("Username", username);

            DataSet ds = db.GetDataSetUsingCmdObj(sqlCmd);

            List<QuizFlash_Class> listOfClasses = new List<QuizFlash_Class>();
            QuizFlash_Class studentClass;

            foreach (DataRow record in ds.Tables[0].Rows)
            {
                studentClass = new QuizFlash_Class();
                studentClass.ClassName = record["Name"].ToString();

                
                listOfClasses.Add(studentClass);
            }

            return listOfClasses;
        }



    } // end class
} // end ns
