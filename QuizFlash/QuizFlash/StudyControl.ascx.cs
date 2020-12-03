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
    public partial class StudyControl : System.Web.UI.UserControl
    {
        public static List<FlashcardClass> FlashcardList { get; set; }
        public static int Index { get; set; }
        public static Boolean HasHomeButtonInNavBeenClickOn { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // Override the OnPreRender method
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            // get the set name that was stored
            String setName = Session["setName"].ToString();
            lblSetName.Text = setName;

            if(FlashcardList == null && Index == 0)
            {
                HasHomeButtonInNavBeenClickOn = false;
                FlashcardList = new List<FlashcardClass>();
                Index = 0;
                GetFlashcardsForSet(setName);

            }
            else if(FlashcardList == null && Index == -1)
            {
                HasHomeButtonInNavBeenClickOn = false;
                // skip
            }
            else if (FlashcardList.Count == 0 && Index == -1)
            {
                HasHomeButtonInNavBeenClickOn = false;
                Index = 0;
                GetFlashcardsForSet(setName);

            }
            else if (FlashcardList.Count == 0 && Index == -2)
            {
                HasHomeButtonInNavBeenClickOn = false;
                Index = 0;

            }
            else if(FlashcardList != null || Index != 0 )
            {
                if (HasHomeButtonInNavBeenClickOn == true)
                {
                    FlashcardList = new List<FlashcardClass>();
                    Index = 0;
                    GetFlashcardsForSet(setName);
                }
                
            }
            

        }

        // quit studying button
        protected void btnRelax_Click(object sender, EventArgs e)
        {
            FlashcardList.Clear();
            Index = -1;
            String userType = Session["userType"].ToString();
            if(userType == "Guest")
            {
                Response.Redirect("GuestHomepage.aspx");

            }
            else if(userType == "Teacher")
            {
                Response.Redirect("TeacherHomepage.aspx");

            }
            else if(userType == "Student")
            {
                Response.Redirect("StudentHomepage.aspx");
            }
        }

        protected void btnShowAnswer_Click(object sender, EventArgs e)
        {
            HasHomeButtonInNavBeenClickOn = false;
            lblAnswer.Visible = true;
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            HasHomeButtonInNavBeenClickOn = false;
            if (FlashcardList.Count == 1)
            {
                ShowFin();
            }
            else if(Index == FlashcardList.Count-1)
            {
                FlashcardList.RemoveAt(Index);
                lblQuestion.Text = FlashcardList[Index - 1].FlashcardQuestion.ToString();
                lblAnswer.Visible = false;
                lblAnswer.Text = FlashcardList[Index - 1].FlashcardAnswer.ToString();
                Index--;
            }
            else if(Index == 0)
            {
                FlashcardList.RemoveAt(Index);
                lblQuestion.Text = FlashcardList[0].FlashcardQuestion.ToString();
                lblAnswer.Visible = false;
                lblAnswer.Text = FlashcardList[0].FlashcardAnswer.ToString();
            }
            else
            {
                FlashcardList.RemoveAt(Index);
                lblQuestion.Text = FlashcardList[Index-1].FlashcardQuestion.ToString();
                lblAnswer.Visible = false;
                lblAnswer.Text = FlashcardList[Index-1].FlashcardAnswer.ToString();
                Index--;
            }

            
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            HasHomeButtonInNavBeenClickOn = false;
            
            if (FlashcardList.Count == 1)
            {
                ShowFin();
            }
            else if(Index == FlashcardList.Count-1 && FlashcardList.Count != 1)
            {
                lblQuestion.Text = FlashcardList[0].FlashcardQuestion.ToString();
                lblAnswer.Visible = false;
                lblAnswer.Text = FlashcardList[0].FlashcardAnswer.ToString();
                Index = 0;
            }
            else
            {
                lblQuestion.Text = FlashcardList[Index + 1].FlashcardQuestion.ToString();
                lblAnswer.Visible = false;
                lblAnswer.Text = FlashcardList[Index + 1].FlashcardAnswer.ToString();
                Index++;
            }
        
        }

        private void GetFlashcardsForSet(String setName)
        {
            //WebRequest request = WebRequest.Create("https://cis-iis2.temple.edu/fall2020/CIS3342_tuh34847/webapitest/api/flashcards/getflashcardset/" + setName);
            WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/getflashcardset/" + setName);
            WebResponse response = request.GetResponse();

            // Read the data from the Web Response, which requires working with streams.
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();

            reader.Close();
            response.Close();

            // Deserialize a JSON string that contains an array of JSON objects into an Array of flashcardset objects.
            JavaScriptSerializer js = new JavaScriptSerializer();
            FlashcardClass[] sets = js.Deserialize<FlashcardClass[]>(data);


            foreach (FlashcardClass flashcard in sets)
            {
                FlashcardList.Add(flashcard);
            }


            lblQuestion.Text = FlashcardList[Index].FlashcardQuestion.ToString();
            lblAnswer.Text = FlashcardList[Index].FlashcardAnswer.ToString();
        }

        private void ShowFin()
        {
            lblAnswer.Text = "Woo you're done!";
            lblAnswer.Visible = true;
            lblQuestion.Visible = false;
            btnNext.Visible = false;
            btnRemove.Visible = false;
            btnShowAnswer.Visible = false;
            FlashcardList.Clear();
            Index = -2;

        }

        

    } // end class
} // end ns