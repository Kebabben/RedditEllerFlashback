<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RedditEllerFlashback._Default" %>





<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
<div id="body">
    <div id="top">
        
        <asp:Label runat="server" ID="ThreadLabel" 
            style="font-size: 30px; font-style: oblique;" >
        </asp:Label>

    </div>
    




    <%-- <asp:Label runat="server" ID="RedditPostLabel" style="font-size: 30px; font-style: oblique; text-align: right;"></asp:Label>
        
        --%>
    
    <div id="bottom">
         <div id="left">         
                 <asp:Button Text="Flashback" runat="server" OnClick="VoteFlashback"/>     
         </div>
        
        <div id="right">  
            <asp:Button Text="Reddit" runat="server" OnClick="VoteReddit"/>        
         </div>

    </div>
</div>

    </div>

</asp:Content>
