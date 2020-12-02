<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudyControl.ascx.cs" Inherits="QuizFlash.StudyControl" %>

<div class="card text-center">
  <div class="card-header">
      <asp:Label ID="lblSetName" runat="server" Text="Set Name" Font-Bold="True" Font-Size="XX-Large" ></asp:Label>
  </div>
  <div class="card-body">
    <h5 class="card-title"><asp:Label ID="lblQuestion" runat="server" Font-Size="X-Large" Text="Question Question Question?"></asp:Label></h5>
    
    <p class="card-text"><asp:Label ID="lblAnswer" runat="server" Font-Size="Large" Text="Answer Answer Answer" Visible="False"></asp:Label></p>
    <p class="card-text">
        <asp:Button ID="btnShowAnswer" runat="server" Font-Size="Medium" Text="Reveal" class="btn btn-primary" OnClick="btnShowAnswer_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
        <asp:Button ID="btnRemove" runat="server" Font-Size="Medium" Text="Remove" class="btn btn-primary" OnClick="btnRemove_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
        <asp:Button ID="btnRelax" runat="server" Font-Size="Medium" Text="Relax" class="btn btn-primary" OnClick="btnRelax_Click" />
    </p>
    <p class="card-text">
        <asp:Button ID="btnNext" runat="server" Width="40%" Font-Size="Large" Text="Next" class="btn btn-primary" OnClick="btnNext_Click" />
    </p>

  </div>
  <!-- <div class="card-footer text-muted">
    2 days ago
  </div> -->
</div>