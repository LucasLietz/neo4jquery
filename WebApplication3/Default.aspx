<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Neo4JDemo.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>NEO4J</h1>
        <p class="lead">A little test project using neo4j...</p>
        <p class="lead">
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Label ID="Hinweis" runat="server" Visible="False" Text="Achtung. Ihre Eingabe war nicht lang genug."></asp:Label>
        </p>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p class="lead">
            <asp:Label ID="Ergebnisse" Visible="False" runat="server" Text=""></asp:Label>
            
        </p>
        <p class="lead">
            <asp:ListBox ID="actorslist" runat="server" Height="167px" Width="219px"></asp:ListBox>
            
        </p>

    </div>

</asp:Content>
