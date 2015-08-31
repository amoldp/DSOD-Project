<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>Enter a search term</h1>
            </hgroup>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <p>
                <asp:Label ID="Label2" runat="server" Text="Enter a location"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Height="44px" OnClick="Button1_Click" Text="Search" Width="150px" />
            </p>
            <p>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>
<ol class="round">
    <li class="one">
        <h5>Getting Started</h5>
            ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245146">Learn more…</a> </li>
    <li class="two">
        <h5>Add NuGet packages and jump-start your coding</h5>
            NuGet makes it easy to install and update free libraries and tools.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245147">Learn more…</a> </li>
    <li class="three">
        <h5>Find Web Hosting</h5>
            You can easily find a web hosting company that offers the right mix of features and price for your applications.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Learn more…</a> </li>
</ol>
</asp:Content>
