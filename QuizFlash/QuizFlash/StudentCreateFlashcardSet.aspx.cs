using System;
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
    public partial class StudentCreateFlashcardSet : System.Web.UI.Page
    {
        public static List<FlashcardClass> flashcards;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Session["username"].ToString();
            if(!IsPostBack)
            {
                btnAddFlashcardSet.Visible = false;
                flashcards = new List<FlashcardClass>();
                MakeTxtBoxesBlank();
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnAddFlashcard_Click(object sender, EventArgs e)
        {
            FlashcardClass flashcard = new FlashcardClass();
            if(IsFlashcardValid())
            {
                flashcard.FlashcardSet = txtFlashcardSetName.Text;
                flashcard.FlashcardSubject = txtFlashcardSetSubject.Text;
                flashcard.FlashcardQuestion = txtFlashcardQuestion.Text;
                flashcard.FlashcardAnswer = txtFlashcardAnswer.Text;
                flashcard.FlashcardImage = txtImage.Text;
                flashcard.FlashcardUsername = lblUserName.Text;
                flashcards.Add(flashcard);
                //lblError.ForeColor = "green";
                lblError.Visible = true;
                lblError.Text = "Added flashcard to set!";
                btnAddFlashcardSet.Visible = true;
                MakeTxtBoxesBlank();
            }
        }

        private Boolean IsFlashcardValid()
        {
            Boolean retVal = true;
            if(String.IsNullOrWhiteSpace(txtFlashcardSetName.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Set name is empty...";
                retVal = false;
            }
            else if (String.IsNullOrWhiteSpace(txtFlashcardSetSubject.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Subject is empty...";
                retVal = false;
            }
            else if (String.IsNullOrWhiteSpace(txtFlashcardQuestion.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Question is empty...";
                retVal = false;
            }
            else if (String.IsNullOrWhiteSpace(txtFlashcardAnswer.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Answer is empty...";
                retVal = false;
            }
            return retVal;
        }

        protected void btnAddFlashcardSet_Click(object sender, EventArgs e)
        {
            //check text boxes to see if valid
            if(IsSetValid())
            {

                // Serialize a list of flashcards into a JSON string.
                JavaScriptSerializer js = new JavaScriptSerializer();
                String jsonFlashcards = js.Serialize(flashcards);

                try
                {
                    // Setup an HTTP POST Web Request and get the HTTP Web Response from the server.
                    WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/insertflashcardset/");
                    request.Method = "POST";
                    request.ContentLength = jsonFlashcards.Length;
                    request.ContentType = "application/json";
                    
                    // Write the JSON data to the Web Request
                    StreamWriter writer = new StreamWriter(request.GetRequestStream());
                    writer.Write(jsonFlashcards);
                    writer.Flush();
                    writer.Close();
                    
                    WebResponse response = request.GetResponse();
                    Stream theDataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(theDataStream);
                    String data = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                    
                    if (data == "true")
                    {
                        lblError.Visible = true;
                        //lblError.ForeColor = "green";
                        lblError.Text = "Successfully made a set of flashcards!";
                        MakeTxtBoxesBlank();
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Error making set of flashcards...";

                    }
                }
                catch (Exception ex)
                {
                    lblError.Visible = true;
                    lblError.Text = "Error: " + ex.Message;
                }
            }
        }

        private Boolean IsSetValid()
        {
            Boolean retVal = true;
            if (flashcards.Count == 0)
            {
                lblError.Visible = true;
                lblError.Text = "Add a flashcard first to add a set...";
                retVal = false;
            }
            
            return retVal;
        }
        
        private void MakeTxtBoxesBlank()
        {
            txtFlashcardSetName.Text = "";
            txtFlashcardSetSubject.Text = "";
            txtFlashcardQuestion.Text = "";
            txtFlashcardAnswer.Text = "";
            txtImage.Text = "";
        }

        
        


    } // class
} // ns
