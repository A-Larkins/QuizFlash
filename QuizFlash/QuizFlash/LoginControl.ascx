<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="QuizFlash.LoginControl" %>


<div class="centered">
    <div class="form-group">
        <asp:Label ID="lblUserType" CssClass ="form-control" runat="server" Text="User Type: "></asp:Label>
        <asp:DropDownList ID="ddlUserType" Width="300px" CssClass ="form-control" runat="server">
            <asp:ListItem>Student</asp:ListItem>
            <asp:ListItem>Teacher</asp:ListItem>

        </asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:Label ID="lblUsername" CssClass="form-control" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblPassword" CssClass="form-control" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-check">
        <asp:CheckBox ID="chkRememberMe" runat="server" />
        <asp:Label ID="lblRememberMe" runat="server" Text="Remember Me"></asp:Label>
    </div>
    <br />
    <div class="form-group">
        <asp:Button ID="btnLogin" CssClass="form-control" runat="server" Text="Login" OnClick="btnLogin_Click"  />
    </div>
    <div class="form-group">
        <asp:Button ID="btnRegister" CssClass="form-control" runat="server" Text="Register" OnClick="Register_Click" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnGuest" CssClass="form-control" runat="server" Text="Continue As Guest" OnClick="btnGuest_Click" />
    </div>
    <div class="form-group">
        <asp:Label ID="lblErrorMessage" CssClass="text-danger" runat="server" Text="Error" Visible="False"></asp:Label>
    </div>

</div>