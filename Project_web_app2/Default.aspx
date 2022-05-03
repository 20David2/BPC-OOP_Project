<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_web_app2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" class="" runat="server">
        <div>
            <asp:Label ID="lblText_SignOrLogin" runat="server" Text="Sign or Login"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblText_PlayerEmail" runat="server" Text="Player email:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="160px"></asp:TextBox>
            <asp:Label ID="lblText_PlayerName" runat="server" Text="Player name:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="160px" ></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="btn_Click" Width="70px"/>
        </p>
        <p>
            <asp:Label ID="lbl_id" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <asp:Label ID="lbl_errorMessage" runat="server"></asp:Label>

        <p>
            <asp:Label ID="lblSign" runat="server"></asp:Label>
            <asp:Button ID="btnSign" runat="server" Text="Yes" Width="79px" Height="24px" OnClick="Button3_Click" Enabled ="True"/>
        </p>

        <p>
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnLogin" runat="server" OnClick="Button2_Click" Text="Continue" Enabled ="True" />
        </p>

    </form>
</body>
</html>
