<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="GameCreate.aspx.cs" Inherits="Project_web_app2.GameCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbGameName" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="gamename"></asp:Label>
            <br />
            <asp:TextBox ID="tbMatchStart" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="celkem zapalek"></asp:Label>
        </div>
        <asp:TextBox ID="tbMatchRound" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="zapalek v jednom kole max:"></asp:Label>
        <p>
            <asp:Button ID="btSubmit" runat="server" OnClick="btSubmit_Click" Text="Submit" Width="127px" />
            <asp:Button ID="btContinue" runat="server" OnClick="btContinue_Click" Text="Continue" Width="108px" />
        </p>
        <asp:Label ID="lblState" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblGameid" runat="server" Text="Label" Visible="False"></asp:Label>
        <p>
            <asp:ListBox ID="lbGames" runat="server" CausesValidation="True" OnSelectedIndexChanged="lbGames_SelectedIndexChanged" ></asp:ListBox>
            <asp:Button ID="btnSet" runat="server" OnClick="btnSet_Click" Text="Set" />
            <asp:ListBox ID="lbIds" runat="server" CausesValidation="True" OnSelectedIndexChanged="lbGames_SelectedIndexChanged" Visible="False" ></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="lbljoin" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btnredirect" runat="server" OnClick="btnredirect_Click" Text="Continue" />
        </p>
    </form>
</body>
</html>
