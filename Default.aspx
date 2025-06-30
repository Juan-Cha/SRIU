<%@ Page Title="Bienvenido al SRIU" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SRIU.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card animate__animated animate__fadeInDown" style="text-align:center;">
        <i class="ri-building-2-line" style="font-size: 4rem; color: #4fa3ff; margin-bottom: 1rem;"></i>
        <h2>Bienvenido al Sistema de Reportes Urbanos Inteligente</h2>
        <p style="font-size:1.2rem; color:#b8c6db;">
            Gestiona, consulta y resuelve incidencias urbanas con eficiencia y estilo.<br />
            Elige una opción para comenzar:
        </p>
        <div style="display:flex; flex-wrap:wrap; justify-content:center; gap:1.5rem; margin-top:2rem;">
            <a href="/Pages/AltaReporte.aspx" class="btn animate__animated animate__fadeInUp" style="animation-delay:0.1s;">
                <i class="ri-add-circle-line"></i> Alta de Reporte
            </a>
            <a href="/Pages/ConsultaReporte.aspx" class="btn animate__animated animate__fadeInUp" style="animation-delay:0.2s;">
                <i class="ri-search-eye-line"></i> Consultar Reportes
            </a>
        </div>
        <p style="margin-top:2.5rem; color:#7b61ff; font-size:0.97rem;">
            Desarrollado en C# | ASP.NET WebForms | SQL Server | SweetAlert2 | Tema Oscuro
        </p>
    </div>
</asp:Content>
