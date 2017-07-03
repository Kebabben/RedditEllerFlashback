<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="RedditEllerFlashback.Start" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="body">
        <div id="top">
            
            <p>
                <asp:Label runat="server" Text="Trådnamn:" style="font-size: 28px; font-weight: bold; text-align: center"></asp:Label>

            </p>
        
            <p>
            <asp:Label runat="server" ID="ThreadLabel" 
                       style="font-size: 30px; font-weight: bold; text-align: center" >
            </asp:Label>
            </p>
        
    

            <br/>
            <br/>
            <br/>
            


        <%-- <asp:Label runat="server" ID="RedditPostLabel" style="font-size: 30px; font-style: oblique; text-align: right;"></asp:Label>
        
        --%>
    
        <%--<div id="bottom">--%>
            <%--<div id="left">--%>    
            <p>
                <asp:Button class="buttons" Text="Flashback" ID="FlashbackButton" runat="server" OnClick="VoteFlashback"/>     
            <%--</div>--%>
            </p>     
        
            <%--<div id="right">  --%>
            <p>
                <asp:Button class="buttons" Text="Reddit" ID="RedditButton" runat="server" OnClick="VoteReddit"/>        
            <%--</div>--%>
            </p>
        <%--</div>--%>
            
        </div>
    </div>



</asp:Content>
