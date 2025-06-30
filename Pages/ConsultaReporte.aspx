<%@ Page Title="Consulta de Reportes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaReporte.aspx.cs" Inherits="SRIU.Pages.ConsultaReporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card animate__animated animate__fadeIn">
        <h2>Consulta de Incidencias Urbanas</h2>
        <asp:Panel ID="pnlConsulta" runat="server">
            <asp:GridView 
    ID="gvReportes"
    runat="server"
    CssClass="table-reportes"
    AutoGenerateColumns="False"
    AllowPaging="True"
    PageSize="10"
    DataKeyNames="IdReporte"
    OnPageIndexChanging="gvReportes_PageIndexChanging"
    OnSelectedIndexChanged="gvReportes_SelectedIndexChanged"
    OnRowEditing="gvReportes_RowEditing"
    OnRowDeleting="gvReportes_RowDeleting"
    OnRowDataBound="gvReportes_RowDataBound"
>
    <Columns>
        <asp:BoundField DataField="IdReporte" HeaderText="#" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="th-center" />
        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
        <asp:BoundField DataField="FechaReporte" HeaderText="Fecha" DataFormatString="{0:yyyy-MM-dd}" ItemStyle-HorizontalAlign="Center" />
        <asp:BoundField DataField="EstatusAtendido" HeaderText="Atendido" ItemStyle-HorizontalAlign="Center" />
        <asp:BoundField DataField="Latitud" HeaderText="Lat" ItemStyle-HorizontalAlign="Center" />
        <asp:BoundField DataField="Longitud" HeaderText="Lon" ItemStyle-HorizontalAlign="Center" />
        <asp:BoundField DataField="CodigoZona" HeaderText="Zona" ItemStyle-HorizontalAlign="Center" />
        <asp:BoundField DataField="PresupuestoEstimado" HeaderText="$" DataFormatString="{0:C}" ItemStyle-HorizontalAlign="Right" />

        
        <asp:TemplateField>
            <ItemTemplate>
                <a href="ActualizaReporte.aspx?id=<%# Eval("IdReporte") %>" class="action-btn" title="Editar">
                    <i class="ri-edit-2-fill"></i>
                </a>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField>
            <ItemTemplate>
                <a href="DetalleReporte.aspx?id=<%# Eval("IdReporte") %>" class="action-btn" title="Ver Detalle">
                    <i class="ri-eye-line"></i>
                </a>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="btnEliminar" runat="server" CommandName="Delete" CommandArgument='<%# Eval("IdReporte") %>' CssClass="action-btn" OnClientClick="return confirmarEliminacion(this);" ToolTip="Eliminar">
                    <i class="ri-delete-bin-6-line"></i>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
        </asp:Panel>
    </div>
</asp:Content>
