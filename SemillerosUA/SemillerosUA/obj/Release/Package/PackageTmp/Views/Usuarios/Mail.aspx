<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mail.aspx.cs" Inherits="SemillerosUA.Views.Usuarios.Mail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Correos</title>
    <link href="../../Content/Images/Fondo/logo.png" rel="shortcut icon" type="image/x-icon" />
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="../../public/content/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <link rel="stylesheet" href="../../public/content/plugins/fullcalendar/fullcalendar.min.css">
    <link rel="stylesheet" href="../../public/content/plugins/fullcalendar/fullcalendar.print.css" media="print">
    <link rel="stylesheet" href="../../public/content/dist/css/AdminLTE.min.css">
    <link rel="stylesheet" href="../../public/content/dist/css/skins/_all-skins.min.css">
    <link rel="stylesheet" href="../../public/content/plugins/iCheck/flat/blue.css">
    <link rel="stylesheet" href="../../public/content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css">

    <script language="javascript" type="text/javascript">

        function ocultar(id) {
            var nuevo = document.getElementById("nuevocorreo"); //se define la variable "elDiv" igual a nuestro div
            var fallido = document.getElementById("noenviado"); //se define la variable "elDiv" igual a nuestro div
            if (id == 1) {
                fallido.style.display = 'none';
                nuevo.style.display = 'block';
            } else {
                nuevo.style.display = 'none';
                fallido.style.display = 'block';
            }
        }
    </script>
</head>
<body class="hold-transition skin-blue sidebar-mini">
    <form id="Form1" runat="server">
        <div class="wrapper" style="background-color: white">

            <header class="main-header">
                <!-- Logo -->
                <a href="Menu.aspx" class="logo">
                    <!-- mini logo for sidebar mini 50x50 pixels -->

                </a>
                <!-- Header Navbar: style can be found in header.less -->
                <nav class="navbar navbar-static-top" role="navigation">
                    <!-- Sidebar toggle button-->
                    <div class="navbar-custom-menu">
                        <ul class="nav navbar-nav">
                            <li id="NewCorreo" class="pull-left" runat="server"><a href="../../Views/Home/Main.aspx" class="text-muted"><i class="glyphicon glyphicon-menu-hamburger"></i>Regresar al menú</a></li>
                        </ul>
                    </div>


                </nav>
            </header>


            <!-- Content Header (Page header) -->
            <section class="content-header">
                <h1>Gestionar correos
           <%-- <small>13 new messages</small>--%>
                </h1>
                <ol class="breadcrumb">
                    <li><a href="#"><i class="fa fa-dashboard"></i>Correos</a></li>
                    <li class="active">Nuevo</li>
                </ol>
            </section>

            <!-- Main content -->
            <section class="content">
                <div class="row">
                    <div class="col-md-3">
                        <div class="box box-solid">
                            <div class="box-header with-border">
                                <h3 class="box-title">Carpetas</h3>
                                <div class="box-tools">
                                    <button class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                                </div>
                            </div>
                            <div class="box-body no-padding">
                                <ul class="nav nav-pills nav-stacked">
                                    <%--<li>
					   <i class="fa fa-refresh"></i>
					  <asp:Button ID="Refrescar" CssClass="btn-link" runat="server" Text="Refrescar"></asp:Button>
                   </li>--%>
                                    <li class="checked"><a href="#" onclick="ocultar(1)"><i class="fa fa-plus-circle"></i>Redactar nuevo</a></li>
                                    <li><a href="#" onclick="ocultar(2)"><i class="fa fa-file-text-o"></i>No enviados</a></li>
                                    <%--<li><a href="#"><i class="fa fa-trash-o"></i> Eliminados</a></li>--%>
                                </ul>
                            </div>
                            <!-- /.box-body -->
                        </div>
                        <!-- /. box -->
                    </div>
                    <!-- /.col -->
                    <div class="col-md-9">
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
                        <div id="nuevocorreo" class="box box-primary">
                            <div class="box-header with-border">
                                <h3 class="box-title">Nuevo mensaje</h3>
                            </div>
                            <!-- /.box-header -->
                            <div class="box-body">

                                <div class="row">
                                    <div class="col-md-9">
                                        <!-- Custom Tabs -->
                                        <div class="nav-tabs-custom">
                                            <ul class="nav nav-tabs">
                                                <li class="active"><a href="#tab_1" data-toggle="tab">Cursos</a></li>
                                                <li><a href="#tab_2" data-toggle="tab">Maratones</a></li>
                                                <li><a href="#tab_3" data-toggle="tab">Semillero</a></li>
                                                <li class="pull-right"><a href="#" class="text-muted"><i class="fa fa-gear"></i></a></li>
                                            </ul>
                                            <div class="tab-content">
                                                <div class="tab-pane active" id="tab_1">
                                                    <div class="row">
                                                        <div class="col-lg-12">
                                                            <div class="form-group">
                                                                <asp:DropDownList ID="t_curso" Height="100" multiple="" AutoPostBack="true" runat="server" OnSelectedIndexChanged="t_curso_SelectedIndexChanged" CssClass="form-control">
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- /.tab-pane -->
                                                <div class="tab-pane" id="tab_2">
                                                    <div class="row">
                                                        <div class="col-lg-12">
                                                            <div class="form-group">
                                                                <asp:DropDownList ID="t_competencia" Height="100" multiple="" OnSelectedIndexChanged="t_competencia_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass="form-control">
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- /.tab-pane -->
                                                <div class="tab-pane" id="tab_3">
                                                    <div class="row">
                                                        <div class="col-lg-12">
                                                            <div class="form-group">
                                                                <asp:DropDownList ID="t_semillero" Height="100" multiple="" OnSelectedIndexChanged="t_semillero_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="0" Text=""></asp:ListItem>
                                                                    <asp:ListItem Value="1" Text="INSCRITOS AL SEMILLERO DE PROGRAMACIÓN"></asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- /.tab-pane -->
                                            </div>
                                            <!-- /.tab-content -->
                                        </div>
                                        <!-- nav-tabs-custom -->
                                    </div>
                                    <!-- /.col -->
                                    <div class="col-md-2">
                                        <div class="form-group">
                                            <label>Inscritos</label>
                                            <asp:TextBox ID="t_cantidad" runat="server" Enabled="false" TextMode="Number" CssClass="form-control" required></asp:TextBox>
                                        </div>
                                    </div>


                                </div>
                                <!-- /.row -->
                                <div class="form-group">
                                    <asp:TextBox ID="t_destinos" runat="server" Height="110px" placeholder="Para:" CssClass="form-control" TextMode="MultiLine" required></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="t_asunto" runat="server" CssClass="form-control" placeholder="Asunto:" required></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="t_mensaje" runat="server" Height="250px" CssClass="form-control" TextMode="MultiLine" required></asp:TextBox>

                                </div>
                                <div class="form-group">
                                    <div class="btn btn-default btn-file">
                                        <i class="fa fa-paperclip"></i>Adjuntar
                      <asp:FileUpload ID="t_file" runat="server" CssClass="form-control" />
                                    </div>
                                </div>
                            </div>
                            <!-- /.box-body -->
                            <div class="box-footer">
                                <div class="pull-right">
                                    <asp:Button ID="Enviar" runat="server" CssClass="btn btn-primary" Text="Enviar" OnClick="Enviar_Click" />
                                </div>
                            </div>
                        </div>
                        <div id="noenviado" style="display: none" class="box box-primary">
                            <div class="box-header with-border">
                                <h3 class="box-title">Correos fallidos</h3>
                            </div>
                            <!-- /.box-header -->
                            <div class="box-body">
                                <div class="row">
                                    <div class="col-lg-12">
                                        <div class="table-responsive">
                                            <asp:Panel ID="PanelGrilla" runat="server" ScrollBars="Auto" Visible="false">
                                                <asp:GridView ID="Grilla" runat="server" CssClass="table table-bordered table-striped"
                                                    OnRowCommand="Grilla_RowCommand" AllowPaging="True" PageSize="100" Enabled="True" SelectedRowStyle-BorderColor="#003300" ShowFooter="False">
                                                    <Columns>
                                                        <asp:ButtonField CommandName="Evacuar" HeaderText="" Text="Enviar correo" />
                                                    </Columns>
                                                </asp:GridView>
                                            </asp:Panel>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <!-- /.box-body -->

                        </div>
                    </div>
                </div>
            </section>
        </div>

        <div class="control-sidebar-bg"></div>
    </form>
    <script src="../../public/content/plugins/jQuery/jQuery-2.1.4.min.js"></script>
    <script src="../../public/content/bootstrap/js/bootstrap.min.js"></script>
    <script src="../../public/content/plugins/slimScroll/jquery.slimscroll.min.js"></script>
    <script src="../../public/content/plugins/fastclick/fastclick.min.js"></script>
    <script src="../../public/content/dist/js/app.min.js"></script>
    <script src="../../public/content/dist/js/demo.js"></script>
    <script src="../../public/content/plugins/iCheck/icheck.min.js"></script>
    <script src="../../public/content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"></script>
    <script>
        $(function () {
            $("#t_mensaje").wysihtml5();
        });
    </script>

</body>
</html>
