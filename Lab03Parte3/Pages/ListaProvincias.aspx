<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProvincias.aspx.cs" Inherits="Lab03Parte3.Pages.ListaProvincias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/ >
    <asp:Label ID="Label3" runat="server" Text="Provincias:"></asp:Label>
    <asp:GridView ID="gv_Provincias" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gv_Provincias_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="nombre" HeaderText="Provincia" />
            <asp:BoundField DataField="estado" HeaderText="Estado" />
            <asp:BoundField DataField="fechaCreacion" HeaderText="Fecha de creacion" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><br/ >
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br/ >
    <asp:Label ID="Label2" runat="server" Text="Estado"></asp:Label><br/ >
    <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox><br/ >
    <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
</asp:Content>
