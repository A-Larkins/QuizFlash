<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditFlashcardSet.aspx.cs" Inherits="QuizFlash.EditFlashcardSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Flashcard Set</title>

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
<body>
    <form id="frmEditFlashcardSet" runat="server">

    
    <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
        <a class="navbar-brand text-light" href="StudentHomepage.aspx">
            <img src="/Images/QuizFlashLogo.png" alt="" /></a>
        
        <div class="collapse navbar-collapse">
            <ul class="navbar-nav mr-auto">
               
            </ul>
            <div class="form-inline my-2 my-lg-0">
                <asp:Label ID="lblUserName" runat="server" CssClass="navbar-brand text-light" Text="Username"></asp:Label>
                &nbsp; &nbsp;
                <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-info" OnClick="btnLogout_Click1"  />
            </div>
        </div>
    </nav>
    
    <div class="d-flex justify-content-center">
        <h1><asp:Label ID="lblEditFlashcardSets" runat="server" Text="Edit Flashcard Set"></asp:Label></h1>
    </div>

        
        <table>
            <tr>
                <th>Flashcard Set</th>
                <th>Subject</th>
                <th>Question</th>
                <th>Answer</th>
                <th>Image</th>
                <th>Username</th>
            </tr>

            <asp:Repeater ID="rptEdit" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label ID="lblSetName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FlashcardSet") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblSubject" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FlashcardSubject") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtQuestion" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FlashcardQuestion") %>'></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAnswer" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FlashcardAnswer") %>'></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtImage" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FlashcardImage") %>'></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblUsername" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FlashcardUsername") %>'></asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>

            </asp:Repeater>
        </table>

        <div class="container">
            <asp:Button ID="btnEdit" CssClass="btn btn-primary" runat="server" Text="Edit" />
        </div>

    </form>


</body>
</html>
