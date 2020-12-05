<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherCreate.aspx.cs" Inherits="QuizFlash.TeacherCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Create</title>

    <link rel="stylesheet" href="StudyStyle.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>


</head>
<body>
    <form id="frmTeacherCreate" runat="server">
        
        <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="TeacherHomepage.aspx">
                <img src="/Images/QuizFlashLogo.png" alt="" /></a>
            
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav mr-auto">
                   
                    
                </ul>
                <div class="form-inline my-2 my-lg-0">
                    <asp:Label ID="lblUserName" runat="server" CssClass="navbar-brand text-light" Text="Username"></asp:Label>
                    &nbsp; &nbsp;
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-info" OnClick="btnLogout_Click" />
                </div>
            </div>
        </nav>


        <div class="centered">
            <div class="card text-center">
                <div class="card-header">
                    <asp:Button ID="btnCreateFlashcard" CssClass="btn btn-primary" runat="server" Text="Create Flashcard" OnClick="btnCreateFlashcard_Click" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnCreateClass" CssClass="btn btn-primary" runat="server" Text="Create Class" OnClick="btnCreateClass_Click" />

                </div>
                <div class="card-header">
                    <h1><asp:Label ID="lblCreate" runat="server" Text="Create..." Visible="False"></asp:Label></h1>
                </div>
            </div>

            <div class="card text-center">
                <div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="lblSetName" runat="server" Text="Flashcard Set Name: " Visible="false"></asp:Label> &nbsp <asp:TextBox ID="txtFlashcardSetName" Visible="false" Width="200px" CssClass="card-text" runat="server"></asp:TextBox></h5>
                    <h5 class="card-title">
                        <asp:Label ID="lblSetSubject" runat="server" Text="Flashcard Set Subject: " Visible="false"></asp:Label>&nbsp <asp:TextBox Visible="false" ID="txtFlashcardSetSubject" Width="200px" CssClass="card-text" runat="server"></asp:TextBox></h5>
                    <p class="card-text">
                        <asp:Label ID="lblQuestion" runat="server" Text="Flashcard Question: " Visible="false"></asp:Label>&nbsp <asp:TextBox Visible="false" ID="txtFlashcardQuestion" CssClass="card-text" Width="200px" runat="server"></asp:TextBox></p>
                    <p class="card-text">
                        <asp:Label ID="lblAnswer" runat="server" Text="Flashcard Answer:" Visible="false"></asp:Label> &nbsp <asp:TextBox Visible="false" ID="txtFlashcardAnswer" CssClass="card-text" runat="server" Width="200px"></asp:TextBox></p>
                    <p class="card-text">
                        <asp:Label ID="lblImage" runat="server" Text="Flashcard Image:" Visible="false"></asp:Label> &nbsp <asp:TextBox Visible="false" ID="txtImage" CssClass="card-text" Width="200px" runat="server"></asp:TextBox></p>
                    <p class="card-text"><asp:Label ID="lblError" runat="server" Visible="false" CssClass="text-danger" Text="Error"></asp:Label></p>

                    <asp:Button ID="btnAddFlashcard" Visible="false" runat="server" class="btn btn-primary" Text="Add Flashcard" OnClick="btnAddFlashcard_Click" />
                    &nbsp;
                    <asp:Button ID="btnAddFlashcardSet" Visible="false" runat="server" class="btn btn-primary" Text="Add Flashcard Set" OnClick="btnAddFlashcardSet_Click" />

                </div>
            </div>
        </div>

        

    </form>
</body>
</html>
