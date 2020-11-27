using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using FlashcardsWebAPI.Models;
using QuizFlashLibrary;
using System.Data;
using System.Data.SqlClient;

namespace FlashcardsWebAPI.Controllers
{
    [Route("api/flashcards")]
    
    public class FlashcardsController : Controller
    {

        [HttpGet("GetFlashcardByID/{Username}")] // route: api/flashcards/getflashcardbyid/0
        public Flashcard GetFlashcardByID(int id)
        {
            Flashcard flashcard = new Flashcard();
            DBConnect db = new DBConnect();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "TP_GetFlashcardByID";
            sqlCmd.Parameters.AddWithValue("ID", id);

            DataSet ds = db.GetDataSetUsingCmdObj(sqlCmd);
            DataTable flashcardDT = ds.Tables[0];



            return flashcard;
        }




    }
}
