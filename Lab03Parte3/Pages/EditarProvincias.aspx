<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProvincias.aspx.cs" Inherits="Lab03Parte3.Pages.EditarProvincias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblTitulo" runat="server" Text="Editar Provincias" Font-Size="XX-Large"></asp:Label><br />
    <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label><br />
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox><br />
    <asp:Label ID="lblNombre" runat="server" Text="Provincia"></asp:Label><br />
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
</asp:Content>
