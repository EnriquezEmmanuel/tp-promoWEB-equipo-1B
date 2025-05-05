<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="EleccionPremio.aspx.cs" Inherits="web.Paginas.EleccionPremio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-style:oblique;color:orangered;" class="text-center">grilla de eleccion</p>
    <asp:Button ID="Siguiente" cssclass="btn btn-primary" onclick="Siguiente_Click" runat="server" Text="Siguiente" />
</asp:Content>
