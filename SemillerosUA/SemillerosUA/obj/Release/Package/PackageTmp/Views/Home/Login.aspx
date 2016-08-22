<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SemillerosUA.Views.Home.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Iniciar sesión</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="~/Content/Images/Fondo/logo.png" rel="shortcut icon" type="image/x-icon" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <link rel="stylesheet" href="../../public/content/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css" />
    <link rel="stylesheet" href="../../public/content/dist/css/AdminLTE.min.css" />
    <link rel="stylesheet" href="../../public/content/dist/css/skins/_all-skins.min.css" />

    <script src="../../public/add/angular/lib/angular.min.js"></script>
    <script src="../../public/add/angular/lib/angular-resource.min.js"></script>
    <script src="../../public/add/angular/controllers/app.js" charset="utf-8"></script>
    <script src="../../public/add/angular/controllers/controller_menu.js" charset="utf-8"></script>


    <script type="text/javascript">

        function openInfo() {
            $('#info').modal()
        }
        function nobackbutton() {
            window.location.hash = "no-back-button";
            window.location.hash = "Again-No-back-button" //chrome
            window.onhashchange = function () { window.location.hash = "no-back-button"; }
        }
    </script>
    <style type="text/css">
        .DivLogo {
            padding: 10px 10px;
            background-color: white;
        }
    </style>
</head>
<body style="background-color: rgb(247, 247, 247)" onload="nobackbutton();" ng-app="UDLA">
    <form id="Form1" role="form" runat="server">
        <br />
        <br />
        <div class="container" ng-controller="GeneralController">
            <div class="row">

                <div class="col-md-8 col-md-offset-2" ng-init="getSemilleroById(<%= id_semillero %>)">
                    <div class="box box-widget widget-user">
                        <div class="widget-user-header bg-aqua-active text-center">

                            <h3 class="widget-user-username">Autenticación de usuario</h3>
                        </div>
                        <div class="widget-user-image">
                            <img class="img-circle" src="../../public/content/dist/img/user2-160x160.jpg" alt="User Avatar" />
                        </div>
                        <div class="box-footer">
                            <div class="row">
                            </div>
                        </div>
                        <div class="panel-body">
                            <div class="col-md-6 text-center">
                                <div class="box box-primary">
                                    <div class="box-body">
                                        <br />
                                        <span class="badge bg-yellow" style="font-size: 12pt">¡Bienvenido!</span><br />
                                        <br />

                                        {{Welcome}}
                                <div class="col-md-12">
                                    <br />
                                    <div class="box box-default collapsed-box box-solid">
                                        <div class="box-header with-border">
                                            <h2 class="box-title">{{NameSemillero}}</h2>
                                            <%--<h3 class="box-title">GIECOM - Gestión del Conocimiento-Electrónica-Informática y Comunicaciones.</h3>--%>
                                        </div>
                                    </div>
                                </div>
                                        <br />
                                        Digita las credenciales de <b>Chairá </b>para el acceso al sistema
                                        <br />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6" style="border-width: 0px 0px 0px 1px; border-color: #00a7d0; border-style: dashed">

                                <fieldset>
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <asp:Panel ID="Resultados" runat="server" Visible="false" CssClass="alert alert-danger">
                                                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                                                <asp:Label ID="LResultado" runat="server" Text=""></asp:Label>
                                            </asp:Panel>
                                        </div>
                                    </div>
                                    <div class="box box-primary">
                                        <br />
                                        <div class="box-body">
                                            <div class="form-group input-group">
                                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                                <asp:TextBox ID="TUsuario" runat="server" placeholder="Usuario Chairá" CssClass="form-control" title="Digite su nombre de usuario" required></asp:TextBox>
                                            </div>
                                            <div class="form-group input-group">
                                                <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                                <asp:TextBox ID="T_Password" CssClass="form-control" placeholder="Contraseña Chairá" runat="server" TextMode="Password" required></asp:TextBox>
                                            </div>

                                            <asp:Button ID="Iniciar" runat="server" Text="Ingresar al sistema" CssClass="btn btn-primary btn-block" OnClick="Iniciar_Click" />
                                            <br />
                                            <div class="row">
                                                <div class="col-md-12 col-md-offset-0">
                                                    <div class="pull-right">
                                                        <a href="#" onclick="openInfo()" class="btn btn-block btn-default btn-xs">¿Olvidaste tu contraseña?</a>
                                                    </div>
                                                </div>
                                            </div>
                                            <br />
                                            <%--<hr />
                                            <div class="small-box bg-gray-light">
                                                <a href="../../Semilleros.aspx?id=<%=id_semillero %>" class="btn btn-default btn-xs btn-block"><i class="glyphicon glyphicon-home"></i>
                                                    Regresar a la página del Semillero </a>
                                            </div>--%>
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </div>
                        <div class="box-footer">
                            <div class="box bg-gray-light text-center">
                                <div class="inner">
                                    <div class="col-lg-12">
                                        <h5>Ingeniería de Sistemas</h5>
                                        <h6><b>Universidad de la Amazonia 2016 - Todos los derechos reservados</b></h6>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

            <div class="row">

                <div id="info" class="modal fade" role="dialog">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                <h4 class="modal-title"><b>Credenciales de acceso a la Plataforma</b></h4>
                            </div>
                            <div class="modal-body">
                                <p>
                                    Ingresa tus datos institucionales (<b>Chairá</b>) para acceder a la plataforma.
                                    Si has olvidado tu contraseña, debes restaurarla desde la página principal del Sistema Misional <b>Chairá </b>de la
                                    Universidad de la Amazonia.
                                </p>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-primary" data-dismiss="modal">Aceptar</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <script src="../../public/content/boot/bower_components/jquery/dist/jquery.min.js"></script>
        <script src="../../public/content/boot/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
        <script src="../../public/content/boot/bower_components/metisMenu/dist/metisMenu.min.js"></script>
        <script src="../../public/content/boot/dist/js/sb-admin-2.js"></script>
    </form>
</body>
</html>
