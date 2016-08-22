<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inscritos.aspx.cs" Inherits="SemillerosUA.Views.Competencias.Inscritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>Inscritos</title>
    <script language="javascript" type="text/javascript">
        function abrir() {
            $('.modal').modal()
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Estudiantes inscritos
          </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Cursos</a></li>
            <li class="active">Listado inscritos</li>
        </ol>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-lg-6">
                <asp:Panel ID="Resultados" Visible="false" runat="server" CssClass="alert alert-danger">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                    <h4><i id="Icono" runat="server" visible="true" class="icon fa fa-ban"></i>
                        <asp:Label ID="LTitulo" runat="server" Text=""></asp:Label></h4>
                    <asp:Label ID="LResultado" runat="server" Text=""></asp:Label>
                </asp:Panel>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <div class="box">
                    <div class="box-body">
                        <div class="row">
                            <div class="col-lg-6">
                                <div class="form-group">
                                    <label>Seleccione la competencia</label>
                                    <asp:DropDownList ID="t_competencia" OnSelectedIndexChanged="t_competencia_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-lg-3">
                                <div class="form-group">
                                    <label>Nivel</label>
                                    <asp:DropDownList ID="t_nivel" OnSelectedIndexChanged="t_nivel_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-lg-3">
                                <div class="form-group">
                                    <label>Programa</label>
                                    <asp:DropDownList ID="t_programa" OnSelectedIndexChanged="t_programa_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <div class="box">
                    <div class="box-body">

                        <label>Atributos</label>
                        <%--<div class="checkbox">
                          <label>--%>
                        <asp:CheckBoxList CssClass="table" ID="Atributos" runat="server" RepeatColumns="7" RepeatDirection="Horizontal"></asp:CheckBoxList>
                        <%-- </label>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <!-- Custom Tabs -->
                <div class="nav-tabs-custom">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#tab_1" data-toggle="tab">Listado</a></li>
                        <li><a href="#tab_2" data-toggle="tab">Reportes</a></li>
                        <li style="text-align: center">
                            <asp:Label ID="CountGroup" runat="server" Font-Size="20pt"></asp:Label>
                        </li>
                        <li class="pull-right">
                            <i class="fa fa-refresh"></i>
                            <asp:Button ID="Regrescar" CssClass="btn-link" runat="server" Text="Refrescar" OnClick="Regrescar_Click"></asp:Button>
                        </li>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane active" id="tab_1">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="panel panel-default">
                                        <div class="panel-body">
                                            <div class="table-responsive">
                                                <asp:Panel ID="PanelGrilla" runat="server" ScrollBars="Auto" Visible="false">
                                                    <asp:GridView ID="Grilla" runat="server" CssClass="table table-bordered table-striped" OnSelectedIndexChanging="Grilla_SelectedIndexChanging"
                                                        OnRowDataBound="Grilla_RowDataBound" OnRowCommand="Grilla_RowCommand" AllowPaging="True" PageSize="100" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                                        <Columns>
                                                            <asp:ButtonField CommandName="Ver" HeaderText="" Text="Ver grupo" />
                                                        </Columns>
                                                    </asp:GridView>
                                                </asp:Panel>
                                            </div>
                                        </div>
                                    </div>
                                    <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Visible="false">
                                        <asp:GridView ID="GrillaReporte" runat="server" CssClass="table table-bordered table-striped"
                                            AllowPaging="True" PageSize="100" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                            <Columns>
                                            </Columns>
                                        </asp:GridView>
                                    </asp:Panel>
                                </div>
                                <div id="myModal" class="modal fade" role="dialog">
                                    <div id="ModalGrupo" runat="server" visible="false" class="modal-dialog">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                <h4 class="modal-title"><b>Participantes</b></h4>
                                                <h4 class="modal-title"><b>Grupo: </b>
                                                    <asp:Label ID="Group" runat="server" Text=""></asp:Label>
                                                </h4>
                                            </div>
                                            <div class="modal-body">
                                                <%--<p>¿Está seguro de cancelar la inscripción al curso?</p>--%>
                                                <asp:Panel ID="Listado" runat="server" ScrollBars="Auto" Visible="false">
                                                    <asp:GridView ID="GrillaListado" runat="server" CssClass="table table-bordered table-striped"
                                                        AllowPaging="True" PageSize="100" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                                        <Columns>
                                                        </Columns>
                                                    </asp:GridView>
                                                </asp:Panel>
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-default" data-dismiss="modal">Aceptar</button>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="ModalReporte" runat="server" visible="false" class="modal-dialog">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                <h4 class="modal-title"><b>Consulta personalizada</b></h4>
                                            </div>
                                            <div class="modal-body">
                                                <div class="row">
                                                    <div class="col-lg-12">
                                                        <div class="form-group">
                                                            <label>SQL:</label>
                                                            <asp:TextBox ID="t_sql" runat="server" Text="SELECT * FROM pmaraton." CssClass="form-control" TextMode="MultiLine" required></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-default" data-dismiss="modal">Aceptar</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="tab_2">
                            <div class="row">

                                <div class="col-lg-8">
                                    <div class="panel panel-default">
                                        <div class="panel-body">
                                            <div class="table-responsive">
                                                <asp:Panel ID="PanelReportes" runat="server" ScrollBars="Auto">
                                                    <asp:GridView ID="GrillaReportes" runat="server" CssClass="table table-bordered table-striped"
                                                        OnRowCommand="GrillaReportes_RowCommand" AllowPaging="True" PageSize="100" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                                        <Columns>

                                                            <asp:ButtonField CommandName="Generar" ControlStyle-CssClass="btn btn-block btn-default btn-xs" HeaderText="" Text="Descargar" />
                                                        </Columns>
                                                    </asp:GridView>
                                                </asp:Panel>
                                            </div>
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
