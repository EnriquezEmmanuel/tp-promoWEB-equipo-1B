<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <p>Ingresá el codigo del vaucher y seguí los pasos.</p>
        <div class="input-group input-group-lg">
            <span class="input-group-text" id="inputGroup-sizing-lg">Código:</span>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="Siguiente" cssclass="btn btn-primary" onclick="Siguiente_Click" runat="server" Text="Siguiente" />
    </div>



</asp:Content>
