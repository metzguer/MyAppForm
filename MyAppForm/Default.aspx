<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyAppForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row">
         <div style="height:200px; width:500px;">
             <asp:Label ID="lblMensaje" runat="Server" ForeColor="Red" Font-Size="35px"/>
         </div>
          <div style="height:200px; width:500px;">
             <asp:Button ID="lblButton" Text="Mostrar mensaje" ForeColor="Red" Font-Size="35px" runat="server" OnClick="lblButton_Click"/>
         </div>
     </div>

</asp:Content>
