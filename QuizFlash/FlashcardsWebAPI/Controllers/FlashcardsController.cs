﻿using System;
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
        [HttpGet] // route: api/flashcards
        public String Get()
        {
            return "Hello there";
        }

        [HttpGet("GetFlashcardByID/{ID}")] // route: api/flashcards/getflashcardbyid/0
        public Flashcard GetFlashcardByID(int id)
        {
            DBConnect db = new DBConnect();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "TP_GetFlashcardByID";
            sqlCmd.Parameters.AddWithValue("ID", id);

            DataSet ds = db.GetDataSetUsingCmdObj(sqlCmd);
            DataRow record;
            Flashcard flashcard = new Flashcard();

            if (ds.Tables[0].Rows.Count > 0)
            {
                record = ds.Tables[0].Rows[0];
                flashcard.FlashcardID = int.Parse(record["Flashcard_ID"].ToString());
                flashcard.FlashcardSet = record["Flashcard_Set"].ToString();
                flashcard.FlashcardSubject = record["Subject"].ToString();
                flashcard.FlashcardQuestion = record["Question"].ToString();
                flashcard.FlashcardAnswer = record["Answer"].ToString();
                flashcard.FlashcardImage = record["Image"].ToString();
                flashcard.FlashcardUsername = record["Username"].ToString();   
            }
            return flashcard;
        }

        // Get set of flashcards by set name
        // route: api/flashcards/getflashcardset/Biology
        [HttpGet("GetFlashcardSet/{flashcard_set}")] 
        public List<Flashcard> GetFlashcardSet(String flashcard_set)
        {
            DBConnect db = new DBConnect();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "TP_GetFlashcardSet";
            sqlCmd.Parameters.AddWithValue("FlashcardSet", flashcard_set);

            DataSet ds = db.GetDataSetUsingCmdObj(sqlCmd);

            List<Flashcard> set = new List<Flashcard>();
            Flashcard flashcard;

            foreach(DataRow record in ds.Tables[0].Rows)
            {
                flashcard = new Flashcard();
                flashcard.FlashcardID = int.Parse(record["Flashcard_ID"].ToString());
                flashcard.FlashcardSet = record["Flashcard_Set"].ToString();
                flashcard.FlashcardSubject = record["Subject"].ToString();
                flashcard.FlashcardQuestion = record["Question"].ToString();
                flashcard.FlashcardAnswer = record["Answer"].ToString();
                flashcard.FlashcardImage = record["Image"].ToString();
                flashcard.FlashcardUsername = record["Username"].ToString();
                set.Add(flashcard);
            }
            return set;
        }

        // test
        [HttpPost()] // route: POST api/flashcards
        public String Post([FromBody]Flashcard flashcard)
        {
            return "WebAPI received: " + flashcard.FlashcardID + ", " + flashcard.FlashcardSet;
        }

        // Insert a flashcard
        [HttpPost("AddFlashcard")] // route: POST api/flashcards/addflashcard
        public Boolean AddFlashcard([FromBody]Flashcard flashcard)
        {
            if(flashcard != null)
            {
                DBConnect db = new DBConnect();
                SqlCommand sqlCmd = new SqlCommand();
     
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "TP_CreateNewFlashcard";
                sqlCmd.Parameters.AddWithValue("@FlashcardID", flashcard.FlashcardID);
                sqlCmd.Parameters.AddWithValue("@FlashcardSet", flashcard.FlashcardSet);
                sqlCmd.Parameters.AddWithValue("@FlashcardSubject", flashcard.FlashcardSubject);
                sqlCmd.Parameters.AddWithValue("@FlashcardQuestion", flashcard.FlashcardQuestion);
                sqlCmd.Parameters.AddWithValue("@FlashcardAnswer", flashcard.FlashcardAnswer);
                sqlCmd.Parameters.AddWithValue("@FlashcardImage", flashcard.FlashcardImage);
                sqlCmd.Parameters.AddWithValue("@FlashcardUsername", flashcard.FlashcardUsername);

                int retval = db.DoUpdateUsingCmdObj(sqlCmd);
                if (retval > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        // Update flashcard
        [HttpPut()] // route: PUT api/flashcards/
        [HttpPut("UpdateFlashcard")]  // PUT api/flashcards/updateflashcard
        public Boolean UpdateFlashcard([FromBody]Flashcard flashcard)
        {
            if (flashcard != null)
            {
                DBConnect db = new DBConnect();
                SqlCommand sqlCmd = new SqlCommand();

                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "TP_UpdateFlashcard";
                sqlCmd.Parameters.AddWithValue("@FlashcardID", flashcard.FlashcardID);
                sqlCmd.Parameters.AddWithValue("@FlashcardSet", flashcard.FlashcardSet);
                sqlCmd.Parameters.AddWithValue("@FlashcardSubject", flashcard.FlashcardSubject);
                sqlCmd.Parameters.AddWithValue("@FlashcardQuestion", flashcard.FlashcardQuestion);
                sqlCmd.Parameters.AddWithValue("@FlashcardAnswer", flashcard.FlashcardAnswer);
                sqlCmd.Parameters.AddWithValue("@FlashcardImage", flashcard.FlashcardImage);
                sqlCmd.Parameters.AddWithValue("@FlashcardUsername", flashcard.FlashcardUsername);

                int retval = db.DoUpdateUsingCmdObj(sqlCmd);
                if (retval > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        
        // Delete flashcard
        [HttpDelete()] // route: DELETE api/flashcards
        public Boolean DeleteFlashcard([FromBody]Flashcard flashcard)
        {
            if (flashcard != null)
            {
                DBConnect db = new DBConnect();
                SqlCommand sqlCmd = new SqlCommand();

                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "TP_DeleteFlashcard";
                sqlCmd.Parameters.AddWithValue("@FlashcardID", flashcard.FlashcardID);

                int retval = db.DoUpdateUsingCmdObj(sqlCmd);
                if (retval > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }


    }
}
