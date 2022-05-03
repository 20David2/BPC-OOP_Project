<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="GameCreate.aspx.cs" Inherits="Project_web_app2.GameCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
                        <h3>Setup new game or choose from already created</h3>
                        <div>
            
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Name of the game:"></asp:Label>
            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="tbGameName" runat="server" Height="20px" style="margin-left: 0px"></asp:TextBox>
        <asp:Label ID="lblNameOfGame" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Number of matches:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DDNumMatches" runat="server" Height="30px" Width="45px" style="margin-left: 0px">
                <asp:ListItem ></asp:ListItem>
                <asp:ListItem Value="" Text =""></asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>35</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>45</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
            </asp:DropDownList>
        <asp:Label ID="lblNumOfMatches" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <asp:Label ID="Label3" runat="server" Text="Max. number of matches in one turn: "></asp:Label>
&nbsp;&nbsp;&nbsp;
&nbsp; <asp:DropDownList ID="DDMatchRound" runat="server" Height="30px" Width="46px" style="margin-left: 0px">
                <asp:ListItem Value="" ></asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
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
