<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_web_app2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" class="" runat="server">
        <div>
            <asp:Label ID="Label6" runat="server" Text="Sign a new player"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Player email:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="160px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Player name:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="160px" ></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btn_Click" Width="70px"/>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

        <p>
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Yes" Width="35px" Height="23px" OnClick="Button3_Click" Enabled ="True"/>
        </p>

        <p>
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Continue" Enabled ="True" />
        </p>

    </form>
</body>
</html>
