<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioCliente.aspx.cs" Inherits="TP_Web_Promo_WEB.FormularioCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row g-3 needs-validation" novalidate runat="server">

        <div class="col-12">
            <label for="txtDocumento" class="form-label">DNI</label>
            <asp:TextBox runat="server" ID="txtDocumento" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtDocumento_TextChanged" />
            <div class="invalid-feedback">Ingrese un DNI válido.</div>
            <div class="valid-feedback">DNI correcto.</div>
        </div>

        <div class="col-md-4">
            <label for="txtNombre" class="form-label">Nombre</label>
            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" required="true" />
            <div class="invalid-feedback">Ingrese un nombre.</div>
        </div>

        <div class="col-md-4">
            <label for="txtApellido" class="form-label">Apellido</label>
            <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" required="true" />
            <div class="invalid-feedback">Ingrese un apellido.</div>
        </div>

        <div class="col-md-4">
            <label for="txtEmail" class="form-label">Email</label>
            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email" required="true" />
            <div class="invalid-feedback">Ingrese un email válido.</div>
        </div>

        <div class="col-md-4">
            <label for="txtDireccion" class="form-label">Dirección</label>
            <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" required="true" />
            <div class="invalid-feedback">Ingrese una dirección válida.</div>
        </div>

        <div class="col-md-4">
            <label for="txtCiudad" class="form-label">Ciudad</label>
            <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control" required="true" />
            <div class="invalid-feedback">Ingrese una ciudad válida.</div>
        </div>

        <div class="col-md-4">
            <label for="txtCodPostal" class="form-label">Código Postal</label>
            <asp:TextBox runat="server" ID="txtCodPostal" CssClass="form-control" MaxLength="4" required="true" />
            <div class="invalid-feedback">Ingrese un código postal válido (4 números).</div>
        </div>

        <div class="col-12">
            <div class="form-check">
                <input type="checkbox" class="form-check-input" id="chkAceptoHtml" required />
                <label class="form-check-label" for="chkAceptoHtml">Acepto los términos y condiciones</label>
                <div class="invalid-feedback">Debe aceptar los términos para continuar.</div>
            </div>
            <asp:CheckBox runat="server" ID="chkAcepto" CssClass="d-none" />
        </div>

        <div class="col-12">
            <asp:Button runat="server" Text="Participar" ID="btnParticipar" CssClass="btn btn-primary" OnClick="btnParticipar_Click" />
        </div>
    </div>
</asp:Content>
