<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="SemillerosUA.Views.Competencias.Inscripciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>Inscribir grupo</title>
    <script language="javascript" type="text/javascript">
        function abrir() {
            $('.modal').modal()
        }
        function welcome() {
            $('#welcome').modal()
        }

        function validarNivel() {
            //document.getElementById("MainContent_Inscribirse").disabled = true;
            var indice = document.getElementById("MainContent_t_nivel");
            if (indice.selectedIndex == null || indice.selectedIndex == 0) {
                indice.focus();
                alert("Seleccione el nivel");
                return false;

            } else {
                return true;
            }
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content">
        <div class="row">
            <div class="col-lg-12">
                <asp:Panel ID="Resultados" Visible="false" runat="server" CssClass="alert alert-danger">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                    <%--<h4><asp:Label ID="LTitulo" runat="server" Text=""></asp:Label></h4>--%>
                    <asp:Label ID="LResultado" runat="server" Text=""></asp:Label>
                </asp:Panel>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-11">
                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Inscribir grupo</h3>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-lg-7">
                                <div class="form-group">
                                    <label>Competencias disponibles</label>
                                    <asp:DropDownList ID="t_competencia" Height="100" multiple="" runat="server" OnSelectedIndexChanged="t_competencia_SelectedIndexChanged" CssClass="form-control" AutoPostBack="true">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div id="Div1" class="col-lg-3" runat="server">
                                <div class="form-group">
                                    <label>Nivel</label>
                                    <asp:DropDownList ID="t_nivel" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-lg-5">
                                <div class="form-group">
                                    <label>Nombre del grupo</label>
                                    <asp:TextBox ID="t_nombre" runat="server" MaxLength="45" CssClass="form-control" required></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-11">
                <!-- Custom Tabs -->
                <div class="nav-tabs-custom">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#tab_1" data-toggle="tab">Información de los participantes</a></li>
                        <%--<li><a href="#tab_2" data-toggle="tab">Historial de competencias</a></li>--%>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane active" id="tab_1">
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="box-body">

                                        <div class="row">
                                            <div class="col-lg-9">
                                                <div class="table-responsive">
                                                    <asp:Panel ID="PanelGrilla" runat="server" ScrollBars="Auto">
                                                        <asp:GridView ID="Grilla" runat="server" CssClass="table table-bordered table-striped" OnSelectedIndexChanging="Grilla_SelectedIndexChanging"
                                                            AutoGenerateColumns="false" OnRowDataBound="Grilla_RowDataBound" OnRowCommand="Grilla_RowCommand" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                                            <Columns>
                                                                <asp:BoundField DataField="Id" HeaderText="N°" ItemStyle-Width="40" />
                                                                <asp:TemplateField HeaderText="Nro Identificación" ItemStyle-Width="200">
                                                                    <ItemTemplate>
                                                                        <asp:TextBox ID="TPersona" CssClass="form-control" runat="server" pattern="[0-9]+" required></asp:TextBox>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="Nombre">
                                                                    <ItemTemplate>
                                                                        <asp:Label ID="LPersona" runat="server" />
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                            </Columns>
                                                        </asp:GridView>
                                                    </asp:Panel>
                                                </div>
                                                <%--<div class="col-lg-3">
                                                    <div class="form-group">
                                                        <asp:Button ID="Validar" runat="server" CssClass="btn btn-default" Text="Validar participantes" OnClick="Validar_Click" />
                                                    </div>
                                                </div>--%>
                                                <div class="col-lg-3">
                                                    <div class="form-group">
                                                        <asp:Button ID="Inscribirse" runat="server" CssClass="btn btn-block btn-success" Text="Inscribir grupo" OnClientClick="return validarNivel()" OnClick="Inscribirse_Click" />
                                                    </div>
                                                </div>

                                            </div>
                                        </div>

                                    </div>
                                    <!-- /.box-body -->
                                </div>
                                <!-- /.col -->
                            </div>
                        </div>
                        <!-- /.tab-pane -->
                        <div class="tab-pane" id="tab_2">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="panel panel-default">
                                        <div class="panel-body">
                                            <div class="table-responsive">
                                                <asp:Panel ID="PanelGrillaHistorial" runat="server" ScrollBars="Auto" Visible="false">
                                                    <asp:GridView ID="GrillaHistorial" runat="server" CssClass="table table-bordered table-striped" OnSelectedIndexChanging="GrillaHistorial_SelectedIndexChanging"
                                                        OnRowDataBound="GrillaHistorial_RowDataBound" OnRowCommand="GrillaHistorial_RowCommand" AllowPaging="True" PageSize="100" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                                        <Columns>
                                                            <asp:ButtonField CommandName="Cancelar" HeaderText="" Text="Cancelar inscripción" />
                                                            <asp:ButtonField CommandName="VerGrupo" HeaderText="" Text="Ver grupo" />
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
    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div id="PCancelar" class="modal-content" runat="server" visible="false">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title"><b>Cancelar inscripción</b></h4>
                </div>
                <div class="modal-body">
                    <p>¿Está seguro de cancelar la inscripción a la competencia?</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                    <asp:Button ID="CancelarMaraton" runat="server" Text="Aceptar" class="btn btn-success" OnClick="CancelarMaraton_Click" />
                    <%--<button type="button" >Aceptar</button>--%>
                </div>
            </div>
            <div id="PVer" class="modal-content" runat="server" visible="false">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title"><b>Composición del grupo</b></h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-5">
                            <div class="form-group">
                                <label>Nivel</label>
                                <asp:DropDownList ID="t_nivelh" runat="server" CssClass="form-control" required>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <asp:Panel ID="PanelView" runat="server" ScrollBars="Auto">
                        <asp:GridView ID="GrillaView" runat="server" CssClass="table table-bordered table-striped"
                            AutoGenerateColumns="false" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="N°" ItemStyle-Width="40" />
                                <asp:TemplateField HeaderText="Nro Identificación" ItemStyle-Width="200">
                                    <ItemTemplate>
                                        <asp:TextBox ID="TPersona" CssClass="form-control" runat="server" pattern="[0-9]+" required></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre">
                                    <ItemTemplate>
                                        <asp:Label ID="LPersona" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                    <%--<div class="col-lg-3">
						<div class="form-group">
							<asp:Button ID="Validar" runat="server" CssClass="btn btn-default" Text="Validar participantes" OnClick="Validar_Click" />
						</div>
					</div>--%>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                    <asp:Button ID="Actualizar" runat="server" Text="Actualizar" class="btn btn-success" OnClick="Actualizar_Click" />
                    <%--<button type="button" >Aceptar</button>--%>
                </div>
            </div>
        </div>
    </div>
    <div id="welcome" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body text-center">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="box box-primary">
                                <div class="box-body box-profile">
                                    <img class="profile-user-img img-responsive img-circle" src="../../Content/Images/Fondo/SP.png" alt="User profile picture">
                                    <h3>Informamos que el proceso de inscripciones a la Maratón de Programación 2016-I se encuentra inhabilitado temporalmente por mantenimiento.</h3>
                                    <h4>Lamentamos las molestias causadas. En el transcurso del día se habilitará nuevamente.</h4>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
</asp:Content>
