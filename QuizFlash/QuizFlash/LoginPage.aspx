<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="QuizFlash.LoginPage" %>

<%@ Register Src="~/LoginControl.ascx" TagPrefix="uc1" TagName="LoginControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <link rel="stylesheet" href="Styles/LoginStyle.css" />
</head>
<body>
    <form id="frmLogin" runat="server">
        <div class="centered">
            <uc1:LoginControl runat="server" id="LoginControl" />
        </div>
    </form>
</body>
</html>
