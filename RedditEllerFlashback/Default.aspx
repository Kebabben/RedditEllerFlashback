<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RedditEllerFlashback._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="top">
        
        <p>
            <asp:Label runat="server" ID="ThreadLabel" 
            style="font-size: 50px; font-weight: bold;" Text="Sweddit eller Flashback?">
            </asp:Label>
        </p>
        
        <br/><br/>

        <p>
            <asp:Label runat="server" ID="Label1" 
                       style="font-size: 30px; font-weight: bold;" Text="Gissa om trådens namn är från flashback eller Sweddit!">
            </asp:Label>
        </p>

        <p>
            <asp:Label runat="server" ID="Label2" 
                       style="font-size: 20px; font-weight: bold;" Text="För varje rätt svar får du en poäng.">
            </asp:Label>
        </p>

        <p>
            <asp:Label runat="server" ID="Label3" 
                       style="font-size: 20px; font-weight: bold;" Text="Vid ett fel svar förlorar du alla poäng.">
            </asp:Label>
        </p>
        
        <br/>
        <asp:Button class="buttons" Text="Start" OnClick="StartClick"
            runat="server"/>

    </div>

    
</asp:Content>