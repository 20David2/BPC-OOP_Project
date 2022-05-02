<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="GameCreate.aspx.cs" Inherits="Project_web_app2.GameCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Set the new game"></asp:Label>
            &nbsp;or choose from prepared<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Name of the game:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="tbGameName" runat="server"></asp:TextBox>
        <asp:Label ID="lblNameOfGame" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Number of matches:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DDNumMatches" runat="server" Height="16px" Width="45px">
                <asp:ListItem Value="" Text =""></asp:ListItem>
                <asp:ListItem Value="27" >27</asp:ListItem>
                <asp:ListItem Value="20" >20</asp:ListItem>
                <asp:ListItem Value="15" >15</asp:ListItem>
                <asp:ListItem Value="12" >12</asp:ListItem>
            </asp:DropDownList>
        <asp:Label ID="lblNumOfMatches" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <asp:Label ID="Label3" runat="server" Text="Max. number of matches in one turn: "></asp:Label>
&nbsp; <asp:DropDownList ID="DDMatchRound" runat="server" Height="30px" Width="46px">
                <asp:ListItem Value="" ></asp:ListItem>
                <asp:ListItem Value="4" >4</asp:ListItem>
                <asp:ListItem Value="3" >3</asp:ListItem>
                <asp:ListItem Value="2" >2</asp:ListItem>
            </asp:DropDownList>
        <asp:Label ID="lblNumOfTurns" runat="server" Text="Label" Visible="False"></asp:Label>
        <p>
            <asp:Button ID="btSubmit" runat="server" OnClick="btSubmit_Click" Text="Submit" Width="127px" />
            <asp:Button ID="btContinue" runat="server" OnClick="btContinue_Click" Text="Continue" Width="108px" />
        </p>
        <asp:Label ID="lblState" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblGameid" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="lblInfoError" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblInfoSet" runat="server" Text="To choose => choose game then click set then join" Visible="False"></asp:Label>
        <p>
            <asp:ListBox ID="lbGames" runat="server" CausesValidation="True" OnSelectedIndexChanged="lbGames_SelectedIndexChanged" ></asp:ListBox>
            <asp:Button ID="btnSet" runat="server" OnClick="btnSet_Click" Text="Set" />
            <asp:ListBox ID="lbIds" runat="server" CausesValidation="True" OnSelectedIndexChanged="lbGames_SelectedIndexChanged" Visible="False" ></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="lbljoin" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnredirect" runat="server" OnClick="btnredirect_Click" Text="Join" />
        </p>
    </form>
</body>
</html>
