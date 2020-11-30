<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHomepage.aspx.cs" Inherits="QuizFlash.StudentHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Homepage</title>

    <link rel="stylesheet" href="Styles/HomepageStyle.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

</head>

<body>
    <form id="frmStudentHomepage" runat="server">
        
        <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="StudentHomepage.aspx">
                <img src="/Images/QuizFlashLogo.png" alt="" /></a>
            
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item mx-1">
                        <asp:TextBox ID="txtSearchSets" CssClass="form-control" Width="200px" runat="server"></asp:TextBox>
                    </li>
                    <li>
                        <asp:Button ID="btnSearchSets" runat="server" Text="Search" CssClass="btn btn-info" />
                        &nbsp; &nbsp; &nbsp;
                    </li>
                    <li class="nav-item mx-1">
                        <a class="navbar-brand text-light" href="StudentClasses.aspx">Classes</a>
                    </li>
                    <li class="nav-item mx-1">
                        <a class="navbar-brand text-light" href="StudentCreateFlashcardSet.aspx">Create</a>
                    </li>
                    
                </ul>
                <div class="form-inline my-2 my-lg-0">
                    <asp:Label ID="lblUserName" runat="server" CssClass="navbar-brand text-light" Text="Username"></asp:Label>
                    &nbsp; &nbsp;
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-info" OnClick="btnLogout_Click" />
                </div>
            </div>
        </nav>

        <div class="container-fluid">
            <div class="d-flex justify-content-center">

                <div class="row">
                    <h1>My Flashcard Sets</h1>
                </div>
            </div>
        </div>

        <div class="container-fluid">
            <div class="d-flex justify-content-center">
                <div class="row">

                    *flashcard sets with edit and study buttons*
                    

                </div>
            </div>
        </div>

        <div class="container-fluid">
            <div class="d-flex justify-content-center">
                <div class="row">
                    <h1>All Flashcard Sets</h1>
                    <asp:GridView ID="gvAllFlashcardSets" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataFormatString="nameOfFlashcardSet" HeaderText="Flashcard Set" />
                            <asp:BoundField DataField="subjectOfFlashcardSet" HeaderText="Subject" />
                            <asp:BoundField DataField="usernameOfFlashcardSet" HeaderText="Created By" />
                            <asp:ButtonField ButtonType="Button" Text="Study" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
