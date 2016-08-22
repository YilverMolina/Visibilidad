<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="MisCursos.aspx.cs" Inherits="SemillerosUA.Views.Cursos.MisCursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>Cursos registrados</title>
    <script lang="javascript" type="text/javascript">
        function abrir() {
            $('.modal').modal()
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content">
        <div class="row">
            <div class="col-xs-8">
                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Inscribir curso</h3>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-lg-12">
                                <div class="form-group">
                                    <label>Cursos disponibles</label>
                                    <asp:DropDownList ID="t_curso" Height="100" multiple="" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="pull-right">
                                    <asp:Button ID="Inscribir" CssClass="btn btn-default" runat="server" Text="Inscribirse" OnClick="Inscribir_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-6">
                <asp:Panel ID="Resultados" Visible="false" runat="server" CssClass="alert alert-danger">
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                    <h4><i id="Icono" runat="server" class="icon fa fa-ban"></i>
                        <asp:Label ID="LTitulo" runat="server" Text=""></asp:Label></h4>
                    <asp:Label ID="LResultado" runat="server" Text=""></asp:Label>
                </asp:Panel>
            </div>
        </div>
        <div class="row">
            <div class="col-md-11">
                <!-- Custom Tabs -->
                <div class="nav-tabs-custom">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#tab_1" data-toggle="tab">Mis cursos</a></li>
                        <%--<li><a href="#tab_2" data-toggle="tab">Inscribir curso</a></li>--%>
                        <%--<li class="pull-right"><a href="#" class="text-muted"><i class="fa fa-refresh"></i>	Refrescar
                                         </a></li>--%>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane active" id="tab_1">
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="box-body">

                                        <asp:Panel ID="PanelGrilla" runat="server" ScrollBars="Auto" Visible="false">
                                            <asp:GridView ID="Grilla" runat="server" CssClass="table table-bordered table-striped" OnSelectedIndexChanging="Grilla_SelectedIndexChanging"
                                                OnRowDataBound="Grilla_RowDataBound" OnRowCommand="Grilla_RowCommand" AllowPaging="True" PageSize="100" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                                <Columns>
                                                    <asp:ButtonField CommandName="Cancelar" ControlStyle-CssClass="btn btn-block btn-default btn-xs" HeaderText="" Text="Cancelar inscripción" />
                                                </Columns>
                                            </asp:GridView>
                                        </asp:Panel>
                                    </div>
                                    <!-- /.box-body -->
                                </div>
                                <!-- /.col -->
                            </div>
                        </div>
                        <!-- /.tab-pane -->
                        <div class="tab-pane" id="tab_2">
                            <%--Contenido aquí--%>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>
    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title"><b>Cancelar inscripción</b></h4>
                </div>
                <div class="modal-body">
                    <p>¿Está seguro de cancelar la inscripción al curso?</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                    <asp:Button ID="CancelarCurso" runat="server" Text="Aceptar" class="btn btn-success" OnClick="CancelarCurso_Click" />
                    <%--<button type="button" >Aceptar</button>--%>
                </div>
            </div>
        </div>
    </div>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

    <%--<script src="../../Content/Styles/plugins/jQuery/jQuery-2.1.4.min.js"></script>
    <script src="../../Content/Styles/bootstrap/js/bootstrap.min.js"></script>--%>
    <script src="../../Content/Styles/plugins/datatables/jquery.dataTables.min.js"></script>
    <script src="../../Content/Styles/plugins/datatables/dataTables.bootstrap.min.js"></script>
    <script src="../../Content/Styles/plugins/slimScroll/jquery.slimscroll.min.js"></script>
    <script src="../../Content/Styles/plugins/fastclick/fastclick.min.js"></script>
    <script src="../../Content/Styles/dist/js/app.min.js"></script>
    <script src="../../Content/Styles/dist/js/demo.js"></script>
    <script>
        $(function () {
            $("#example1").DataTable();
            $('#example2').DataTable({
                "paging": true,
                "lengthChange": false,
                "searching": false,
                "ordering": true,
                "info": true,
                "autoWidth": false
            });
        });
    </script>
</asp:Content>
