<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_Web_Promo_WEB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/PersonalizarDefault.css" rel="stylesheet" />

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
        </section>

        <div class="row justify-content-center">
            <section class="col-md-6 text-center" aria-labelledby="txtBoxIngresarVoucher">
                <h2 id="txtBoxIngresarVoucher">Ingrese el voucher</h2>
                <hr />
                <div>
                    <asp:Label Text="Ingresar código" runat="server" />
                    <asp:TextBox ID="txtBoxVoucher" runat="server" CssClass="tamanioTxt" OnTextChanged="btnValidar_Click"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnValidar" runat="server" Text="Validar" CssClass="btn btn-primary" OnClick="btnValidar_Click"/>
                    <div>
                        <asp:Label ID="lblMensaje" CssClass="mje" runat="server" Text=""></asp:Label>
                    </div>
                    
                </div>
            </section>
        </div>

    </main>

</asp:Content>
