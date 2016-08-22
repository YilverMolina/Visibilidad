<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="SemillerosUA.Views.Documentos.Upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>Cargar documentos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content-header">
        <h1>Cargar documento nuevo
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Documentos</a></li>
            <li class="active">Cargar nuevo</li>
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
                        <li class="active"><a href="#tab_1" data-toggle="tab">Cargar documento</a></li>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane active" id="tab_1">
                            <div class="row">

                                <div class="col-lg-12">
                                    <div class="panel panel-default">
                                        <div class="panel-body">

                                            <div class="box">
                                                <div class="box-body" id="div_table">
                                                    <div class="row">
                                                        <div class="col-lg-12">
                                                            <div class="panel-body">
                                                                <div class="row">
                                                                    <div class="col-lg-6">
                                                                        <div class="form-group">
                                                                            <label>Nombre</label>
                                                                            <asp:TextBox ID="t_nombre" runat="server" MaxLength="50" CssClass="form-control" required></asp:TextBox>

                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-6">
                                                                        <div class="form-group">
                                                                            <label>Comentarios</label>
                                                                            <asp:TextBox ID="t_comentarios" runat="server" MaxLength="200" TextMode="MultiLine" CssClass="form-control" required></asp:TextBox>

                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-6">
                                                                        <div class="form-group">
                                                                            <label>Archivo fuente</label>
                                                                            <asp:FileUpload ID="t_fuente" runat="server" CssClass="form-control" />
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-2">
                                                                        <div class="form-group">
                                                                            <label style="visibility: hidden">Archivo fuente</label>
                                                                            <asp:Button ID="Cargar" runat="server" CssClass="btn btn-success" Text="Cargar" OnClick="Cargar_Click" />
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
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title"><b>Devolver ejercicio</b></h4>
                </div>
                <div class="modal-body">
                    <p>¿Está seguro de cancelar la asignación de este ejercicio?</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                    <asp:Button ID="Devolver" runat="server" Text="Aceptar" class="btn btn-success" />
                    <%--<button type="button" >Aceptar</button>--%>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
