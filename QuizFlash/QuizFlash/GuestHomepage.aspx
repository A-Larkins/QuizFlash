<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestHomepage.aspx.cs" Inherits="QuizFlash.GuestHomepage" %>

<%@ Register Src="~/StudyControl.ascx" TagPrefix="uc1" TagName="StudyControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guest Homepage</title>
    
    <link rel="stylesheet" href="Styles/HomepageStyle.css" />
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
    <form id="frmGuestHomepage" runat="server">
        
        <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="GuestHomepage.aspx">
                <img src="/Images/QuizFlashLogo.png" alt="" /></a>
            

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item mx-1">
                        <asp:TextBox ID="txtSearchSets" CssClass="form-control" Width="200px" Text="Search..." runat="server" ></asp:TextBox>
                    </li>
                    <li>
                        <asp:Button ID="btnSearchSets" runat="server" Text="Search" CssClass="btn btn-info" OnClick="btnSearchSets_Click" />
                    </li>
                </ul>
                <div class="form-inline my-2 my-lg-0">
                    <asp:Button ID="btnCreateAnAccount" runat="server" Text="Account" CssClass="btn btn-info" OnClick="btnCreateAnAccount_Click" />
                </div>
            </div>
        </nav>

       
        <p></p><p></p>

        <div class="d-flex justify-content-center">
            <h1><asp:Label ID="lblAllFlashcardSets" runat="server" Text="All Flashcard Sets"></asp:Label></h1>
        </div>

        <p></p>
        
        <div class="row justify-content-center">
            <div class="col-8">
                <div class="table-responsive">
                    <div class="table">
                        <asp:GridView ID="gvAllFlashcardSets" BackColor="LightGreen" BorderWidth="4px" BorderColor="DarkCyan"  UseAccessibleHeader="true" CssClass="table table-striped" runat="server" AutoGenerateColumns="False" OnRowCommand="StudyFromAllSets">
                            <Columns>
                                <asp:BoundField HeaderStyle-BackColor="LightSeaGreen" DataField="NameOfFlashcardSet" HeaderText="Flashcard Set" />
                                <asp:BoundField HeaderStyle-BackColor="LightSeaGreen" DataField="SubjectOfFlashcardSet" HeaderText="Subject" />
                                <asp:BoundField HeaderStyle-BackColor="LightSeaGreen" DataField="UsernameOfFlashcardSet" HeaderText="Created By" />
                                <asp:ButtonField HeaderStyle-BackColor="LightSeaGreen" ControlStyle-Width="75%" ControlStyle-CssClass="btn btn-primary" ItemStyle-HorizontalAlign="Center" ButtonType="Button" CommandName="Study" Text="Study" />   
                            </Columns>
                        </asp:GridView> 
                    </div>
                </div>
            </div>
        </div>

        <div class="centered">
            <uc1:StudyControl runat="server" ID="StudyControl" Visible="false" />
        </div>


    </form>
</body>
</html>
