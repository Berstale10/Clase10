<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaProvincia.aspx.cs" Inherits="Lab03Parte3.Pages.ConsultaProvincia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="grv_Provincias" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grv_Provincias_SelectedIndexChanged">
    <Columns>
        <asp:CommandField ShowSelectButton="True" />
        <asp:BoundField DataField="id_Provincia" HeaderText="ID" />
        <asp:BoundField DataField="Nombre" HeaderText="Provincia" />
        <asp:BoundField DataField="fechaCreacion" HeaderText="Fecha de creacion" />
        <asp:BoundField DataField="estado" HeaderText="Estado" />
    </Columns>
</asp:GridView>
</asp:Content>
