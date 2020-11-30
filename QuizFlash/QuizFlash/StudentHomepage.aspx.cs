﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;  // needed for JSON serializers
using System.IO;                        // needed for Stream and Stream Reader
using System.Net;                       // needed for the Web Request
using QuizFlashLibrary;

namespace QuizFlash
{
    public partial class StudentHomepage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblUserName.Text = Session["username"].ToString();

                // Create an HTTP Web Request and get the HTTP Web Response from the server.
                //WebRequest request = WebRequest.Create("https://cis-iis2.temple.edu/fall2020/CIS3342_tuh34847/webapitest/api/flashcards/getallsetsofflashcards");
                WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/getallsetsofflashcards");
                WebResponse response = request.GetResponse();
                
                // Read the data from the Web Response, which requires working with streams.
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();

                reader.Close();
                response.Close();
                
                // Deserialize a JSON string that contains an array of JSON objects into an Array of flashcardset objects.
                JavaScriptSerializer js = new JavaScriptSerializer();
                FlashcardSetClass[] sets = js.Deserialize<FlashcardSetClass[]>(data);

                gvAllFlashcardSets.DataSource = sets;
                gvAllFlashcardSets.DataBind();
            }
        }
        
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("LoginPage.aspx");
        }
    }
}
