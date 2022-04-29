<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameCreate.aspx.cs" Inherits="Project_web_app2.GameCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbGameName" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="tbMatchStart" runat="server"></asp:TextBox>
        </div>
        <asp:TextBox ID="tbMatchRound" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btSubmit" runat="server" OnClick="btSubmit_Click" Text="Submit" Width="127px" />
        </p>
        <asp:Label ID="lblState" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
