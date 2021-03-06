<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="Project_web_app2.Game" %>

<!DOCTYPE html>

<html 
    xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">      
    <title></title>      
   <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>  
    <script src="js/bootstrap.min.js"></script>    
    <link href="css/bootstrap.min.css" rel="stylesheet" />    
</head> 
<body>
    <div class="row">  
    <div class="col-lg-12">  
        <form id="form1" class="" runat="server">
        <div>
            <div class="container text-center">
                <div class="row">
                    <div class="col-lg-3"></div>  
                    <div class="col-lg-6">
                        <h1>Lets play!</h1>
                        <div>
            <asp:Label ID="lblGameNameText" runat="server" Text="Game name: "></asp:Label>
            <asp:Label ID="lblGameName" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblRemainingText" runat="server" Text="Remaining matches:"></asp:Label>
            <asp:Label ID="lblRemainingInfo" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblLastCount" runat="server" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblMaxText" runat="server" Text="Max in one round:"></asp:Label>
&nbsp;
        <asp:Label ID="lblMaxPerRound" runat="server"></asp:Label>

            <br />
                    <asp:Label ID="Label3" runat="server" Text="Next move: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblWhoTurn" runat="server" Text=""></asp:Label>


            <br />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="I take "></asp:Label>

        <asp:TextBox ID="tbMove" runat="server" Width="30px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text=" matches"></asp:Label>

        <br />

        <br />
        <asp:Button ID="btnPlay" runat="server" OnClick="btnPlay_Click" Text="Play" Width="60px" />
        <asp:Button ID="btnReload" runat="server" OnClick="btnReload_Click" Text="Reload" Visible="False" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblState" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblError" runat="server" Text="" Visible ="false"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            
        


    </form>
        </div>
        </div>

    <div class="text-center p-6 fixed-bottom" style="background-color: gray">
        @2022 Copyright: Game of matches
        <p>David Strouhal,
        Martin Zarecky</p>
        
                </div>

</body>
</html>

