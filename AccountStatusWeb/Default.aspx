<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AccountStatusWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="container">
    
    <asp:GridView CssClass="table table-striped" ID="GridReports" runat="server" AutoGenerateColumns="True" CellPadding="4" DataKeyNames="idReport"  ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />

       
    </asp:GridView>

   

    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>

    </div>

   

</asp:Content>
