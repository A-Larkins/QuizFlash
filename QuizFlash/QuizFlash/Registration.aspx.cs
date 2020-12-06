using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizFlashLibrary;

// code behind for registration page that will insert a new user
// into the db to be used in login

namespace QuizFlash
{
    public partial class Registration : System.Web.UI.Page
    {

        LoginClass login = new LoginClass();
        Encrypt encrypt = new Encrypt();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String userType = ddlUserType.SelectedValue;

            if (userType == "Student")
            {
                try
                {
                    User student = CreateUser();
                    if (ValidUser(student))
                    {
                        int ret = login.InsertStudent(student);
                        if (ret == 1)
                        {
                            Response.Redirect("LoginPage.aspx");

                            
                        }
                        else
                        {
                            lblErrorMessage.Visible = true;
                            lblErrorMessage.Text = "Invalid...";
                        }
                    }
                    else return;
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = ex.Message;
                }
            }
            else if (userType == "Teacher")
            {
                try
                {
                    User teacher = CreateUser();
                    if (ValidUser(teacher))
                    {
                        int ret = login.InsertTeacher(teacher);
                        if (ret == 1)
                        {
                            Response.Redirect("LoginPage.aspx");
                        }
                        else
                        {
                            lblErrorMessage.Visible = true;
                            lblErrorMessage.Text = "Invalid...";
                        }
                    }
                    else return;
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = ex.Message;
                }
            }

        }

        private User CreateUser()
        {
            User user = new User();
            if (!String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                user.Email = txtEmail.Text;

            }
            if (!String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                user.Username = txtUsername.Text;
            }
            if (!String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                String passwordEncrypted = encrypt.DoEncryption(txtPassword.Text);
                user.Password = passwordEncrypted;
            }
            if(!String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                user.FirstName = txtFirstName.Text;

            }
            if(!String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                user.LastName = txtLastName.Text;

            }
            if (!String.IsNullOrWhiteSpace(txtSecurityQ1.Text))
            {
                user.Question1 = txtSecurityQ1.Text;

            }
            if (!String.IsNullOrWhiteSpace(txtSecurityA1.Text))
            {
                user.Answer1 = txtSecurityA1.Text;

            }
            if (!String.IsNullOrWhiteSpace(txtSecurityQ2.Text))
            {
                user.Question2 = txtSecurityQ2.Text;

            }
            if (!String.IsNullOrWhiteSpace(txtSecurityA2.Text))
            {
                user.Answer2 = txtSecurityA2.Text;

            }
            if (!String.IsNullOrWhiteSpace(txtSecurityQ3.Text))
            {
                user.Question3 = txtSecurityQ3.Text;

            }
            if (!String.IsNullOrWhiteSpace(txtSecurityA3.Text))
            {
                user.Answer3 = txtSecurityA3.Text;

            }


            return user;
        }

        private bool ValidUser(User user)
        {
            String userType = ddlUserType.SelectedValue;
            bool ret = true;
            if (String.IsNullOrWhiteSpace(user.Username))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter a username...";
                ret = false;
            }
            else
            {
                User check = login.GetUserByUsername(user.Username, userType);
                if (!string.IsNullOrWhiteSpace(check.Username))
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "That username has been taken...";
                    ret = false;
                }
            }
            if (String.IsNullOrWhiteSpace(user.Password))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter a password...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.FirstName))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter a first name...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.LastName))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter a last name...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.Email))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter an email address...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.Question1))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter security question 1...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.Question2))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter security question 2...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.Question3))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter security question 3...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.Answer1))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter security answer 1...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.Answer2))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter security answer 2...";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(user.Answer3))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter security answer 3...";
                ret = false;
            }

            return ret;
        }



    }
}