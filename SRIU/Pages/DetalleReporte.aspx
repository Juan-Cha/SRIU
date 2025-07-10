<%@ Page Title="Detalle de Reporte" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleReporte.aspx.cs" Inherits="SRIU.Pages.DetalleReporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Aquí puedes poner estilos o scripts específicos después -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card animate__animated animate__fadeIn">
        <h2>Detalle de Incidencia Urbana</h2>
        <asp:Panel ID="pnlDetalle" runat="server">
            <table class="table">
                <tr><th>ID:</th><td><asp:Label ID="lblId" runat="server" /></td></tr>
                <tr><th>Descripción:</th><td><asp:Label ID="lblDescripcion" runat="server" /></td></tr>
                <tr><th>Fecha:</th><td><asp:Label ID="lblFecha" runat="server" /></td></tr>
                <tr><th>¿Atendido?</th><td><asp:Label ID="lblAtendido" runat="server" /></td></tr>
                <tr><th>Latitud:</th><td><asp:Label ID="lblLatitud" runat="server" /></td></tr>
                <tr><th>Longitud:</th><td><asp:Label ID="lblLongitud" runat="server" /></td></tr>
                <tr><th>Código Zona:</th><td><asp:Label ID="lblCodigoZona" runat="server" /></td></tr>
                <tr><th>Presupuesto:</th><td><asp:Label ID="lblPresupuesto" runat="server" /></td></tr>
            </table>
            <a href="ConsultaReporte.aspx" class="btn" style="margin-top:1rem;">Regresar</a>
        </asp:Panel>
    </div>
</asp:Content>
