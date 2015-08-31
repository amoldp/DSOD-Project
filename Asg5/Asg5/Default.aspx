<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Asg5._Default" %>
<%@ OutputCache duration="10" varybyparam="None" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>Enter a city name<br />
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <br />
                    enter a state abbrev<br />
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Height="52px" Text="Submit" Width="184px" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox5" runat="server" Height="173px" Width="597px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Date and Time"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox10" runat="server" Height="149px" Width="606px"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="get map" OnClick="Button2_Click" />
                    <br />
                    <iframe id="frameid" name="frameid" runat="server"
  width="450"
  height="250"
  ></iframe>
                </h1>
            </hgroup>
            <hgroup class="title">
                <h1>
                    <br />
                    <br />
                    enter a zip code<br />
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Submit" OnClick="Button3_Click" />
                    <br />
                    <asp:TextBox ID="TextBox8" runat="server" Height="108px" Width="289px"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <br />
                </h1>
            </hgroup>
           
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
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
            <a href="http://go.microsoft.com/fwlink/?LinkId=245146">Learn more…</a>
        </li>
        <li class="two">
            <h5>Add NuGet packages and jump-start your coding</h5>
            NuGet makes it easy to install and update free libraries and tools.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245147">Learn more…</a>
        </li>
        <li class="three">
            <h5>Find Web Hosting</h5>
            You can easily find a web hosting company that offers the right mix of features and price for your applications.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245143">Learn more…</a>
        </li>
    </ol>
</asp:Content>
