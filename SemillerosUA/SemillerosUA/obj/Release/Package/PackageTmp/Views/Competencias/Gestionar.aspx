<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Gestionar.aspx.cs" Inherits="SemillerosUA.Views.Competencias.Gestionar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>Gestionar</title>
    <script language="javascript" type="text/javascript">

        function openSave() {

            var id1 = document.getElementById("P1");
            var id2 = document.getElementById("P2");

            var id3 = document.getElementById("MainContent_t_nombre");
            var id4 = document.getElementById("MainContent_t_fecha");
            var id5 = document.getElementById("MainContent_t_fechalimite");
            var id6 = document.getElementById("MainContent_t_personas");
            var id7 = document.getElementById("MainContent_t_cupos");
            var id8 = document.getElementById("MainContent_t_ejercicios");
            var id9 = document.getElementById("MainContent_t_horainicio");
            var id10 = document.getElementById("MainContent_t_horafin");

            id1.style.display = "block";
            id2.style.display = "none";

            id3.value = "";
            id4.value = "";
            id5.value = "";
            id6.value = "";
            id7.value = "";
            id8.value = "";
            //id9.value = "";
            //id10.value = "";

            $('.modal').modal()
        }
        function openUpdate() {
            var id1 = document.getElementById("P1");
            var id2 = document.getElementById("P2");
            id2.style.display = "block";
            id1.style.display = "none";
            $('.modal').modal()
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Gestionar competencias
          </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Competencias</a></li>
            <li class="active">Gestionar</li>
        </ol>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-lg-12">
                <asp:Panel ID="Resultados" runat="server" Visible="false" CssClass="alert alert-danger">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                    <asp:Label ID="LResultado" runat="server" Text=""></asp:Label>
                </asp:Panel>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <div class="box">
                    <div class="box-header">

                        <ul class="nav nav-tabs">
                            <li class="active">
                                <h3 class="box-title">Competencias registradas</h3>
                            </li>
                            <li class="pull-right"><a href="#" class="text-muted" onclick="openSave()"><i class="fa fa-fw fa-plus-circle"></i>Crear competencia</a></li>
                        </ul>
                    </div>
                    <!-- /.box-header -->

                    <div class="box-body">

                        <asp:Panel ID="PanelGrilla" runat="server" ScrollBars="Auto" Visible="false">
                            <asp:GridView ID="Grilla" runat="server" CssClass="table table-bordered table-striped"
                                AllowPaging="True" PageSize="100" OnRowCommand="Grilla_RowCommand" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                <Columns>
                                    <asp:ButtonField CommandName="Administrar" ControlStyle-CssClass="btn btn-block btn-default btn-xs" HeaderText="" Text="Administrar" />
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>

                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
            <!-- /.col -->
        </div>
        <div id="myModal" class="modal fade" role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title"><b>Crear nueva competencia</b></h4>
                    </div>
                    <div class="modal-body">
                        <div id="PanelInformacion" class="row" runat="server">
                            <div class="col-lg-12">
                                <%--<div class="panel panel-default">--%>
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <div class="form-group">
                                                <label>Nombre de la competencia</label>
                                                <asp:TextBox ID="t_nombre" runat="server" CssClass="form-control" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-4">
                                            <div class="form-group">
                                                <label>Fecha de prueba</label>
                                                <asp:TextBox ID="t_fecha" runat="server" CssClass="form-control" TextMode="Date" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-4">
                                            <div class="form-group">
                                                <label>Límite inscripciones</label>
                                                <asp:TextBox ID="t_fechalimite" runat="server" CssClass="form-control" TextMode="Date" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-4">
                                            <div class="form-group">
                                                <label>Nro Participantes</label>
                                                <asp:TextBox ID="t_personas" runat="server" CssClass="form-control" MaxLength="2" pattern="[0-9]+" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-4">
                                            <div class="form-group">
                                                <label>Nro Ejercicios</label>
                                                <asp:TextBox ID="t_ejercicios" runat="server" CssClass="form-control" MaxLength="2" pattern="[0-9]+" required></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="col-lg-4">
                                            <div class="form-group">
                                                <label>Hora inicio</label>
                                                <asp:TextBox ID="t_horainicio" runat="server" CssClass="form-control" TextMode="Time" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-4">
                                            <div class="form-group">
                                                <label>Hora fin</label>
                                                <asp:TextBox ID="t_horafin" runat="server" CssClass="form-control" TextMode="Time" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3">
                                            <div class="form-group">
                                                <label>Estado</label>
                                                <asp:DropDownList ID="t_estado" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="T" Text="Activo"></asp:ListItem>
                                                    <asp:ListItem Value="F" Text="Inactivo"></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-lg-3">
                                            <div class="form-group">
                                                <label>Cupos</label>
                                                <asp:TextBox ID="t_cupos" runat="server" CssClass="form-control" pattern="[0-9]+" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-2">
                                            <label style="visibility: hidden">d</label>
                                            <div class="form-group">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer" id="P1">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                        <asp:Button ID="CrearComp" runat="server" Text="Crear competencia" CssClass="btn btn-success" OnClick="CrearComp_Click" />
                    </div>
                    <div class="modal-footer" id="P2">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                        <asp:Button ID="Modificar" runat="server" Text="Actualizar" class="btn btn-success" OnClick="Modificar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
