<%@ Page Title="Alta de Reporte" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaReporte.aspx.cs" Inherits="SRIU.Pages.AltaReporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Aquí puedes poner scripts específicos del formulario si lo requieres después -->
    <script>
        function validarFormulario() {
            let descripcion = document.getElementById('<%= txtDescripcion.ClientID %>').value.trim();
            let fecha = document.getElementById('<%= txtFechaReporte.ClientID %>').value.trim();
            let latitud = document.getElementById('<%= txtLatitud.ClientID %>').value.trim();
    let longitud = document.getElementById('<%= txtLongitud.ClientID %>').value.trim();
    let zona = document.getElementById('<%= txtCodigoZona.ClientID %>').value.trim();
            let presupuesto = document.getElementById('<%= txtPresupuesto.ClientID %>').value.trim();

            if (!descripcion || !fecha || !latitud || !longitud || !zona || !presupuesto) {
                Swal.fire({
                    icon: 'error',
                    title: 'Campos Vacíos',
                    text: 'Todos los campos son obligatorios.',
                    background: '#23272a',
                    color: '#e0e0e0'
                });
                return false; // Bloquea el postback
            }
            // Validaciones extra por campo
            if (isNaN(latitud) || isNaN(longitud) || isNaN(presupuesto)) {
                Swal.fire({
                    icon: 'error',
                    title: 'Dato Inválido',
                    text: 'Latitud, Longitud y Presupuesto deben ser numéricos.',
                    background: '#23272a',
                    color: '#e0e0e0'
                });
                return false;
            }

            if (zona.length > 4) {
                Swal.fire({
                    icon: 'error',
                    title: 'Código de Zona demasiado largo',
                    text: 'Solo se permiten hasta 4 caracteres.',
                    background: '#23272a',
                    color: '#e0e0e0'
                });
                return false;
            }

            return true; // Permite el postback si todo es correcto
        }

    </script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card animate__animated animate__fadeIn">
        <h2>Registrar Nueva Incidencia Urbana</h2>
        <asp:Panel ID="pnlForm" runat="server">
            <div class="form-group">
                <label>Descripción</label>
                <asp:TextBox ID="txtDescripcion" runat="server" MaxLength="200" CssClass="input" onkeypress="return validarTexto(event);"/>
            </div>
            <div class="form-group">
                <label>Fecha de Reporte</label>
                <asp:TextBox ID="txtFechaReporte" runat="server" CssClass="input" TextMode="Date" />
            </div>
            <div class="form-group">
                <label for="chkAtendidoSwitch">¿Atendido?</label>
                <label class="switch">
                    <input type="checkbox" id="chkAtendidoSwitch" name="chkAtendidoSwitch">
                    <span class="slider"></span>
                </label>
            </div>
            <div class="form-group">
                <label>Latitud</label>
                <asp:TextBox ID="txtLatitud" runat="server" CssClass="input" onkeypress="return validarNumeroDecimal(event, this);"/>
            </div>
            <div class="form-group">
                <label>Longitud</label>
                <asp:TextBox ID="txtLongitud" runat="server" CssClass="input" onkeypress="return validarNumeroDecimal(event, this);"/>
            </div>
            <div class="form-group">
                <label>Código de Zona</label>
                <asp:TextBox ID="txtCodigoZona" runat="server" MaxLength="4" CssClass="input" onkeypress="return validarZona(event);"/>
            </div>
            <div class="form-group">
                <label>Presupuesto Estimado</label>
                <asp:TextBox ID="txtPresupuesto" runat="server" CssClass="input" onkeypress="return validarNumeroDecimal(event, this);"/>
            </div>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn" OnClick="btnRegistrar_Click" OnClientClick="return validarFormulario();"/>
        </asp:Panel>
        <asp:Label ID="lblMensaje" runat="server" CssClass="mensaje" />
    </div>
</asp:Content>
