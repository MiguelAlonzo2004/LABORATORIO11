<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LABORATORIO10._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Notas</h1>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Mesoamericana</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p class="lead">
            <asp:Label ID="Label1" runat="server" Text="Nombre del Alumno: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Label ID="Label2" runat="server" Text="Curso: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Notas: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" class="btn btn-warning btn-lg" Text="Ingresar Nota" OnClick="Button1_Click" />
        </p>
        <p class="lead">
            <asp:Button ID="Button2" runat="server" class="btn btn-primary btn-lg" Text="Ingresar Alumno" OnClick="Button2_Click" />
        </p>
    </div>

</asp:Content>
