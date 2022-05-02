<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="Project_web_app2.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCount" runat="server" Text="Počet zápalek: "></asp:Label>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Tah: "></asp:Label>
        <asp:TextBox ID="tbMove" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnPlay" runat="server" OnClick="btnPlay_Click" Text="Button" />
        <p>
            <asp:Button ID="btnReload" runat="server" Text="Reload" />
        </p>
        <asp:Label ID="lblState" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
