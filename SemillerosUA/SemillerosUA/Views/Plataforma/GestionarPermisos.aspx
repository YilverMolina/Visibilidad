<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="GestionarPermisos.aspx.cs" Inherits="SemillerosUA.Views.Plataforma.GestionarPermisos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>Administrar permisos</title>
    <script language="javascript" type="text/javascript">
        function abrir() {
            $('.modal').modal()
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Administrar permisos
          </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Plataforma</a></li>
            <li class="active">Configuración</li>
        </ol>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-lg-12">
                <asp:Panel ID="Resultados" Visible="false" runat="server" CssClass="alert alert-danger">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                    <asp:Label ID="LResultado" runat="server" Text=""></asp:Label>
                </asp:Panel>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <!-- Custom Tabs -->
                <div class="nav-tabs-custom">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#tab_1" data-toggle="tab">Permisos y roles</a></li>
                        <li class="pull-right">

                            <%--<a href="#" onclick="abrir()"><i class="fa fa-refresh"></i>	Configuración</a>--%>
                        </li>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane active" id="tab_1">
                            <div class="row">

                                <div class="col-lg-12">
                                    <div class="panel panel-default">
                                        <div class="panel-body">
                                            <div class="row">
                                                <div class="col-lg-3">
                                                    <div class="form-group">
                                                        <label>Rol</label>
                                                        <asp:DropDownList ID="t_rol" Height="80" AutoPostBack="true" OnSelectedIndexChanged="t_rol_SelectedIndexChanged" multiple="" runat="server" CssClass="form-control" required>
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                                <div class="col-lg-6">
                                                    <div class="form-group">
                                                        <label>Estudiante</label>
                                                        <asp:DropDownList ID="t_estudiante" runat="server" CssClass="form-control" required>
                                                        </asp:DropDownList>
                                                        <br />
                                                        <asp:Button ID="UpdateStudent" runat="server" CssClass="btn btn-primary" Text="Cambiar rol" OnClick="UpdateStudent_Click" />
                                                    </div>
                                                </div>
                                                <div class="col-lg-3">
                                                    <div class="form-group">
                                                        <label>Nuevo rol</label>
                                                        <asp:TextBox ID="t_nrol" runat="server" CssClass="form-control" required></asp:TextBox>
                                                        <br />
                                                        <asp:Button ID="CreateRol" runat="server" CssClass="btn btn-primary" Text="Crear rol" OnClick="CreateRol_Click" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <div class="box box-primary">
                                                        <div class="box-header">
                                                            <ul class="nav nav-tabs">
                                                                <li class="active">
                                                                    <h3 class="box-title">
                                                                        <asp:Label ID="TituloPermisos" runat="server" Text="Permisos asignados al rol"></asp:Label>
                                                                    </h3>
                                                                </li>
                                                            </ul>
                                                        </div>
                                                        <!-- /.box-header -->
                                                        <div class="box-body">
                                                            <div class="form-group">
                                                                <div class="checkbox">
                                                                    <asp:CheckBoxList CssClass="table" ID="PermisosGenerales" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"></asp:CheckBoxList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="box-footer">
                                            <div class="pull-right">
                                                <asp:Button ID="Actualizar" runat="server" CssClass="btn btn-primary" Text="Actualizar" OnClick="Actualizar_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
    </section>
</asp:Content>
