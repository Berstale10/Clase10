<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mantenimiento de usuarios.aspx.cs" Inherits="Lab03Parte3.Pages.Mantenimiento_de_usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>    Mantenimiento de usuarios</h1>
    <br />
    <h3>Lista de datos</h3>
    <asp:GridView ID="gv_Usuarios" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gv_Usuarios_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="Nombre_usuario" HeaderText="Nombre de Usuario" />
            <asp:BoundField DataField="Nickname" HeaderText="Nickname" />
            <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" />
            <asp:BoundField DataField="Fecha_creacion" HeaderText="Fecha de Creación" />
            <asp:BoundField DataField="Ultima_actualizacion" HeaderText="Ultima Actualización" />
        </Columns>
    </asp:GridView>
    <br />
    <h4>Datos</h4>
    <div>
    <asp:Label ID="lblId" runat="server" Text="Identificador" height="16px"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtID" runat="server" width="128px" height="22px"></asp:TextBox>
    <br />
    <asp:Label ID="lblNombre" runat="server" Text="Nombre de Usuario" height="16px"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtNombre" runat="server" height="22px" width="128px"></asp:TextBox>
    <br />
    <asp:Label ID="lblnname" runat="server" Text="Nickname"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNick" runat="server" height="22px" width="128px"></asp:TextBox>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Contraseña" height="16px"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtContra" runat="server" height="22px" width="128px"></asp:TextBox>
    <br />
    <asp:Label ID="lblFCreacion" runat="server" Text="Fecha de Creación" height="16px"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtFechaCrea" runat="server" height="22px" width="128px"></asp:TextBox>
    <br />
    <asp:Label ID="lblUActualizacion" runat="server" Text="Ultima Actualización" height="16px"></asp:Label>
    &nbsp;<asp:TextBox ID="txtUActua" runat="server" height="22px" width="128px"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="btnCrear" runat="server" Text="Agregar" OnClick="btnCrear_Click" />
        &nbsp;<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
        &nbsp;<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    </div>
</asp:Content>
