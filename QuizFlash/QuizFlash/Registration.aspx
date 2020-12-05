<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="QuizFlash.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <link rel="stylesheet" href="Styles/LoginStyle.css" />

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>


</head>
<body style="background-color: #cfffe4;">

    <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="LoginPage.aspx">
                <img src="/Images/QuizFlashLogo.png" alt="" />
            </a>
    </nav>


    <form id="frmRegistration" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-5 mx-auto">
                    <div class="centered  w-25 p-3">
                        <div class="card" style="border-width:5px; border-color:lightseagreen">
                            <div class="logo mb-3" Style="background-color:lightseagreen">
                                <div class="card-header text-center">
                                    <h1 style= "color:white;" >Registration</h1>

                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblUserType" CssClass ="form-control" style="border-width:2px; border-color:#ffa74a" runat="server" Text="User Type: " Font-Bold="True"></asp:Label>
                                <asp:DropDownList ID="ddlUserType" style="border-width:2px; border-color:lightseagreen" CssClass ="form-control" runat="server">
                                    <asp:ListItem>Student</asp:ListItem>
                                    <asp:ListItem>Teacher</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblUsername" CssClass="form-control" style="border-width:2px; border-color:#ffa74a" runat="server" Text="Username" Font-Bold="True"></asp:Label>
                                <asp:TextBox ID="txtUsername" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblPassword" CssClass="form-control" style="border-width:2px; border-color:#ffa74a" runat="server" Text="Password" Font-Bold="True"></asp:Label>
                                <asp:TextBox ID="txtPassword" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblFirstName" CssClass="form-control" style="border-width:2px; border-color:#ffa74a" runat="server" Text="First Name" Font-Bold="True"></asp:Label>
                                <asp:TextBox ID="txtFirstName" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblLastName" CssClass="form-control" style="border-width:2px; border-color:#ffa74a" runat="server" Text="Last Name" Font-Bold="True"></asp:Label>
                                <asp:TextBox ID="txtLastName" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblEmail" CssClass="form-control" style="border-width:2px; border-color:#ffa74a" runat="server" Text="Email" Font-Bold="True"></asp:Label>
                                <asp:TextBox ID="txtEmail" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">

                            </div>
                            <div class="col-md-12 mb-3 text-center">
                                <div class="form-group">
                                    <asp:Button ID="btnRegister" Width="40%" CssClass="btn btn-primary" runat="server" Text="Register" OnClick="btnRegister_Click" />
                                    
                                    <asp:Button ID="btnCancel" Width="40%" CssClass="btn btn-primary" runat="server" Text="Cancel" OnClick="btnCancel_Click" />

                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblErrorMessage" runat="server" CssClass="form-control text-center" Text="Error" Visible="false" ForeColor="Red" Font-Size="Large"></asp:Label>

                                </div>
                            </div>
                            
                            
                        </div>

                    </div>
                </div>
            </div>
        </div>
        

    </form>
</body>
</html>
