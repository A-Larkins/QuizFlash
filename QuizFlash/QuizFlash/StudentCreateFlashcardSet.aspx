<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentCreateFlashcardSet.aspx.cs" Inherits="QuizFlash.StudentCreateFlashcardSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Flashcard Set</title>

    
    <link rel="stylesheet" href="Styles/StudyStyle.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>


</head>
<body style="background-color: #d0d0d0">
    <form id="frmStudentCreateFlashcardSet" runat="server">
        
        <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="StudentHomepage.aspx">
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
            <div class="card text-center" style="width:700px; border-color:mediumseagreen; border-width:5px; " >
                <div class="card-header" style="background-color:lightseagreen">
                    <h1>Create A Flashcard Set</h1>
                </div>
                <div class="card-body">
                    <h5 class="card-title">Flashcard Set Name: &nbsp <asp:TextBox ID="txtFlashcardSetName" Width="400px" CssClass="card-text" runat="server"></asp:TextBox></h5>
                    <h5 class="card-title">Flashcard Set Subject: &nbsp <asp:TextBox ID="txtFlashcardSetSubject" Width="400px" CssClass="card-text" runat="server"></asp:TextBox></h5>
                    <p class="card-text">Flashcard Question: &nbsp <asp:TextBox ID="txtFlashcardQuestion" CssClass="card-text" Width="400px" runat="server"></asp:TextBox></p>
                    <p class="card-text">Flashcard Answer: &nbsp <asp:TextBox ID="txtFlashcardAnswer" CssClass="card-text" runat="server" Width="400px"></asp:TextBox></p>
                    <p class="card-text">Flashcard Image: &nbsp <asp:TextBox ID="txtImage" CssClass="card-text" Width="400px" runat="server"></asp:TextBox></p>
                    <p class="card-text"><asp:Label ID="lblError" runat="server" Visible="false" CssClass="text-danger" Text="Error"></asp:Label></p>

                    <asp:Button ID="btnAddFlashcard" runat="server" class="btn btn-primary" Text="Add Flashcard" OnClick="btnAddFlashcard_Click" />
                    &nbsp;
                    <asp:Button ID="btnAddFlashcardSet" runat="server" class="btn btn-primary" Text="Add Flashcard Set" OnClick="btnAddFlashcardSet_Click" />

                </div>
            </div>
        </div>

    </form>
</body>
</html>
