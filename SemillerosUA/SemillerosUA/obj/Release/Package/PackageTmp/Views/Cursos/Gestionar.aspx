<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Gestionar.aspx.cs" Inherits="SemillerosUA.Views.Cursos.Gestionar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>Gestionar</title>
    <script lang="javascript" type="text/javascript">

        function openSave() {

            var id1 = document.getElementById("P1");
            var id2 = document.getElementById("P2");

            var id3 = document.getElementById("MainContent_t_nombre");
            var id4 = document.getElementById("MainContent_t_finicio");
            var id5 = document.getElementById("MainContent_t_ffin");
            var id6 = document.getElementById("MainContent_t_cupos");

            id1.style.display = "block";
            id2.style.display = "none";

            id3.value = "";
            id4.value = "";
            id5.value = "";
            id6.value = "";

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
        <h1>Gestionar cursos
          </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Cursos</a></li>
            <li class="active">Gestionar</li>
        </ol>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box">
                    <div class="box-header">

                        <ul class="nav nav-tabs">
                            <li class="active">
                                <h3 class="box-title">Cursos registrados</h3>
                            </li>
                            <li class="pull-right"><a href="#" class="text-muted" onclick="openSave()"><i class="fa fa-fw fa-plus-circle"></i>Crear curso</a></li>
                        </ul>
                    </div>
                    <!-- /.box-header -->

                    <div class="box-body">
                        <div class="row">
                            <div class="col-lg-6">
                                <asp:Panel ID="Resultados" runat="server" Visible="false" CssClass="alert alert-danger">
                                    <asp:Label ID="LResultado" runat="server" Text=""></asp:Label>
                                </asp:Panel>
                            </div>
                        </div>
                        <asp:Panel ID="PanelGrilla" runat="server" ScrollBars="Auto" Visible="false">
                            <asp:GridView ID="Grilla" runat="server" CssClass="table table-bordered table-striped"
                                AllowPaging="True" PageSize="100" OnRowCommand="Grilla_RowCommand" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                <Columns>
                                    <asp:ButtonField CommandName="Administrar" ControlStyle-CssClass="btn btn-block btn-default btn-xs" HeaderText="" Text="Administrar" />
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
        <div id="myModal" class="modal fade" role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title"><b>Crear nuevo curso</b></h4>
                    </div>
                    <div class="modal-body">
                        <div id="PanelInformacion" class="row" runat="server">
                            <div class="col-lg-12">
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <div class="form-group">
                                                <label>Nombre del curso</label>
                                                <asp:TextBox ID="t_nombre" runat="server" MaxLength="49" CssClass="form-control" onkeyup="javascript:this.value=this.value.toUpperCase();" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-6">
                                            <label>Fecha de inicio</label>
                                            <div class="form-group input-group">
                                                <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                <asp:TextBox ID="t_finicio" runat="server" TextMode="Date" CssClass="form-control" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-6">
                                            <label>Fecha de finalización</label>
                                            <div class="form-group input-group">
                                                <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                <asp:TextBox ID="t_ffin" runat="server" TextMode="Date" CssClass="form-control" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3">
                                            <div class="form-group">
                                                <label>Cupos</label>
                                                <asp:TextBox ID="t_cupos" runat="server" TextMode="Number" CssClass="form-control" MaxLength="5" required></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3">
                                            <div class="form-group">
                                                <label>Tipo</label>
                                                <asp:DropDownList ID="t_tipo" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="Abierto" Text="Abierto"></asp:ListItem>
                                                    <asp:ListItem Value="Cerrado" Text="Cerrado"></asp:ListItem>
                                                </asp:DropDownList>
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
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer" id="P1">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                        <asp:Button ID="Registrar" runat="server" Text="Guardar" class="btn btn-success" OnClick="Registrar_Click" />
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
