<%@ Page Title="Actualizar Reporte" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizaReporte.aspx.cs" Inherits="SRIU.Pages.ActualizaReporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card animate__animated animate__fadeIn">
    <h2 class="text-center">Actualizar Estatus de Incidencia</h2>
    <div class="form-table-container">
        <table class="form-table" style="margin: 0 auto; width: 520px;">
            <tr>
                <th>ID Reporte</th>
                <td><asp:TextBox ID="txtIdReporte" runat="server" CssClass="input" ReadOnly="true" /></td>
            </tr>
            <tr>
                <th>Descripción</th>
                <td><asp:TextBox ID="txtDescripcion" runat="server" CssClass="input" ReadOnly="true" /></td>
            </tr>
            <tr>
                <th>Fecha de Reporte</th>
                <td><asp:TextBox ID="txtFechaReporte" runat="server" CssClass="input" ReadOnly="true" /></td>
            </tr>
            <tr>
                <th>Latitud</th>
                <td><asp:TextBox ID="txtLatitud" runat="server" CssClass="input" ReadOnly="true" /></td>
            </tr>
            <tr>
                <th>Longitud</th>
                <td><asp:TextBox ID="txtLongitud" runat="server" CssClass="input" ReadOnly="true" /></td>
            </tr>
            <tr>
                <th>Código de Zona</th>
                <td><asp:TextBox ID="txtCodigoZona" runat="server" CssClass="input" ReadOnly="true" /></td>
            </tr>
            <tr>
                <th>Presupuesto Estimado</th>
                <td><asp:TextBox ID="txtPresupuesto" runat="server" CssClass="input" ReadOnly="true" /></td>
            </tr>
            <tr>
                <th>¿Atendido?</th>
                <td style="text-align:center;">
                    <label class="switch">
                        <input type="checkbox" id="chkAtendidoHtml" runat="server" class="input-switch" />
                        <span class="slider round"></span>
                    </label>
                </td>
            </tr>
        </table>
        <div class="btn-group-center">
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Estatus" CssClass="btn" OnClick="btnActualizar_Click" />
            <asp:Button ID="btnRegresar" runat="server" Text="⟵ Regresar" CssClass="btn-secondary" OnClick="btnRegresar_Click" />
        </div>
    </div>
</div>
</asp:Content>
