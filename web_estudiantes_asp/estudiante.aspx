<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="estudiante.aspx.cs" Inherits="web_estudiantes_asp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Formulario Estudiante</h1>
    <p>
        <asp:Label ID="lbl_carne" runat="server" Text="Carne" BorderStyle="Dotted" CssClass="badge" ForeColor="White"></asp:Label>
         <asp:TextBox ID="txt_carne" runat="server" CssClass="form-control" placeholder="ejemplo 1290-19-5032"></asp:TextBox>
        <asp:Label ID="lbl_nombres" runat="server" Text="Nombres" BorderStyle="Dotted" CssClass="badge" ForeColor="White"></asp:Label>
         <asp:TextBox ID="txt_nombres" runat="server" CssClass="form-control" placeholder="ejemplo Bryan Joseph"></asp:TextBox>
        <asp:Label ID="lbl_apellidos" runat="server" Text="Apellidos" BorderStyle="Dotted" CssClass="badge" ForeColor="White"></asp:Label>
         <asp:TextBox ID="txt_apellidos" runat="server" CssClass="form-control" placeholder="ejemplo Chacaj Corado"></asp:TextBox>
        <asp:Label ID="lbl_direccion" runat="server" Text="Direccion" BorderStyle="Dotted" CssClass="badge" ForeColor="White"></asp:Label>
         <asp:TextBox ID="txt_direccion" runat="server" CssClass="form-control" placeholder="ejemplo Guatemala 1-22"></asp:TextBox>
        <asp:Label ID="lbl_correo" runat="server" Text="Correo Electronico" BorderStyle="Dotted" CssClass="badge" ForeColor="White"></asp:Label>
         <asp:TextBox ID="txt_correo" runat="server" CssClass="form-control" placeholder="ejemplo bryan4565@gmail.com"></asp:TextBox>
         <asp:Label ID="lbl_tipo_sangre" runat="server" Text="Tipo Sangre" BorderStyle="Dotted" CssClass="badge" ForeColor="White"></asp:Label>
        <asp:DropDownList ID="drop_sangre"  CssClass="form-control" runat="server"></asp:DropDownList>
        <asp:Label ID="lbl_fn" runat="server" Text="Fecha Nacimiento" BorderStyle="Dotted" CssClass="badge" ForeColor="White"></asp:Label>
         <asp:TextBox ID="txt_fn" runat="server" CssClass="form-control" placeholder="DD-MM-YYYY" TextMode="Date"></asp:TextBox>

          <asp:Button ID="btn_crear" runat="server" Text="Crear" CssClass="btn-info disabled focus" OnClick="btn_crear_Click" />
        <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar" CssClass="btn-warning active focus" OnClick="btn_actualizar_Click" />
      
       
        <asp:Label ID="lbl_mensaje" runat="server" BorderStyle="Dotted" CssClass="badge" ForeColor="White"></asp:Label>
      
       
        <asp:GridView ID="grid_estudiante" runat="server" AutoGenerateColumns="False" CssClass="table-bordered" DataKeyNames="id,id_tipo_sangre" OnSelectedIndexChanged="grid_estudiante_SelectedIndexChanged" OnRowDeleting="grid_estudiante_RowDeleting">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btn_select" runat="server" CausesValidation="False" CommandName="Select" CssClass="btn-info disabled focus" Text="Seleccionar" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btn_eliminar" runat="server" CausesValidation="False" CommandName="Delete" CssClass="btn-danger active focus" Text="Eliminar" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField=" carne" HeaderText="Carne" />
                <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="correo_electronico" HeaderText="Correo Electronico" />
                <asp:BoundField DataField="tipo_sangre" HeaderText="Tipo Sangre" />
                <asp:BoundField DataField="fecha_nacimiento" HeaderText="Fecha Nacimiento" />
            </Columns>
            <EmptyDataTemplate>
                tabla vacia
            </EmptyDataTemplate>
        </asp:GridView>
&nbsp;&nbsp;&nbsp; 
</asp:Content>
