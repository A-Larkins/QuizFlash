using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuizFlashLibrary;

namespace QuizFlash
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        // classes in utilities class library
        // used for component based design
        LoginClass login = new LoginClass();
        Encrypt encrypt = new Encrypt();

        protected void Page_Load(object sender, EventArgs e)
        {
            // check if user has a cookie
            if (!IsPostBack && Request.Cookies["LoginCookie"] != null)
            {
                HttpCookie cookie = Request.Cookies["LoginCookie"];
                txtUsername.Text = cookie.Values["Username"];
                String passwordEncrypted = cookie.Values["Password"];
                String textPassword = encrypt.DoDecryption(passwordEncrypted);
                txtPassword.Text = textPassword;
            }
        }

        // login button event handler
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblErrorMessage.Text = "";
                String username = txtUsername.Text;
                String password = txtPassword.Text;
                String userType = ddlUserType.SelectedValue;

                if (!ValidLogin())
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "Cound not login";
                    return;
                }
                User objUser = GetUserLogin(username, userType);
                objUser.UserType = ddlUserType.SelectedValue;
                Session["userID"] = objUser.UserID;
                Session["username"] = objUser.Username;
                Session["userType"] = objUser.UserType;

                // remember me option creates a user cookie so user can
                // skip login page upon re-entry.
                if (chkRememberMe.Checked)
                {
                    String encryptedPassword = encrypt.DoEncryption(password);
                    HttpCookie cookie = new HttpCookie("LoginCookie");
                    cookie.Values["Username"] = username;
                    cookie.Values["Password"] = encryptedPassword;
                    cookie.Expires = new DateTime(2030, 1, 1);
                    Response.Cookies.Add(cookie);
                }

                if (objUser.UserType == "Student")
                {
                    Response.Redirect("StudentHomepage.aspx");
                }
                else if (objUser.UserType == "Teacher")
                {
                    Response.Redirect("TeacherHomepage.aspx");
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        private User GetUserLogin(String username, String userType)
        {
            User user = login.GetUserByUsername(username, userType);
            return user;
        }


        private bool ValidLogin()
        {
            lblErrorMessage.Text = "";
            bool ret = true;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String userType = ddlUserType.SelectedValue;
            User objUser = new User();

            if (String.IsNullOrWhiteSpace(username))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Error - Username";
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Error - Password";
                ret = false;
            }
            if (!String.IsNullOrWhiteSpace(username) && !String.IsNullOrWhiteSpace(password))
            {
                objUser = login.GetUserByUsername(username, userType);
                if (String.IsNullOrWhiteSpace(objUser.Username))
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "Cannot find username";
                    ret = false;
                }
                else
                {
                    String passwordEncrypted = encrypt.EncryptPassword(password);
                    if (!String.Equals(passwordEncrypted, objUser.Password))
                    {
                        lblErrorMessage.Visible = true;
                        lblErrorMessage.Text = "Incorrect password...";
                        ret = false;
                    }
                }
            }
            return ret;
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void btnGuest_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["userType"] = "Guest";
            Response.Redirect("GuestHomepage.aspx");
        }

    }
}
