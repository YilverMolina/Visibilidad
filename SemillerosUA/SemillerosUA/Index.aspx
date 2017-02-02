<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SemillerosUA.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Inicio | Semilleros UDLA</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link rel="shortcut icon" type="image/x-icon" href="public/images/fondo/UA.gif" />
    <link href="public/index/style/css/bootstrap.css" rel="stylesheet" />
    <link href="public/index/style/css/settings.css" rel="stylesheet" />
    <link href="public/index/style/js/google-code-prettify/prettify.css" rel="stylesheet" />
    <link href="public/index/style.css" rel="stylesheet" />
    <link href="public/index/style/css/color/green.css" rel="stylesheet" />
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,400italic,500,500italic,700italic,700,900,900italic,300italic,300,100italic,100' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Roboto+Condensed:300italic,400italic,700italic,400,700,300' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Roboto+Slab:400,700,300,100' rel='stylesheet' type='text/css' />
    <link href="public/index/style/type/fontello.css" rel="stylesheet" />

    <script src="public/add/angular/lib/angular.min.js"></script>
    <script src="public/add/angular/lib/angular-resource.min.js"></script>
    <script src="public/add/angular/controllers/app.js" charset="utf-8"></script>
    <script src="public/add/angular/controllers/controller_menu.js" charset="utf-8"></script>

    <style type="text/css">
        .stroke {
            color: white;
            text-shadow: -2px -2px 0 #3D5229, 2px -2px 0 #3D5229, -2px 2px 0 #3D5229, 2px 2px 0 #3D5229;
            font-weight: bold;
        }
    </style>

</head>
<body ng-app="UDLA">
    <form id="form1" runat="server">
        <div class="body-wrapper" ng-controller="GeneralController">
            <div id="header" class="navbar navbar-fixed-top">
                <div class="navbar-inner">
                    <div class="container">
                        <a class="btn responsive-menu pull-right" data-toggle="collapse" data-target=".nav-collapse"><i class='icon-menu-1'></i></a><a class="brand" href="Index.aspx">
                            <%--<img src="public/index/style/images/logo.png" alt="" />--%>

                            <h1 style="font-size: 20pt">
                                <img src="public/images/fondo/UA.png" class="responsive" alt="" />
                                <b>UNIVERSIDAD DE LA AMAZONIA</b>
                            </h1>
                        </a>
                        <div class="nav-collapse pull-right collapse">
                            <ul class="nav">
                                <li class="dropdown"><a class="btn btn-warning" href="Index.aspx">
                                    <i class="icon-home"></i>
                                    Inicio</a>
                                </li>
                                <li class="dropdown"><a href="Views/Home/Login.aspx" class="btn btn-warning" target="_blank">
                                    <i class="icon-login"></i>
                                    Ingresar al sistema</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class="offset"></div>
            <div class="fullwidthbanner-container revolution">
                <div class="fullwidthbanner">
                    <ul style="background-color: red">
                        <li data-transition="fade">
                            <img src="public/images/slider/image7.jpg" alt="" />
                            <div class="caption sfl bold stroke" data-x="center" data-y="200" data-speed="500" data-start="100" data-easing="easeOutExpo">Gestión de eventos de los Semilleros de Investigación</div>
                            <div class="caption sfr lite" data-x="center" data-y="274" data-speed="500" data-start="900" data-easing="easeOutExpo" style="background-color: rgba(0,0,0,0.8); border-radius: 10px; padding: 10px">Control de asistencias y actividades internas</div>
                        </li>
                        <li data-transition="fade">
                            <img src="public/images/slider/image2.jpg" alt="" />
                            <div class="caption sfl bold stroke" data-x="center" data-y="200" data-speed="500" data-start="100" data-easing="easeOutExpo">Gestión de competencias de los Semilleros de Investigación</div>
                            <div class="caption sfr lite" data-x="center" data-y="274" data-speed="500" data-start="900" data-easing="easeOutExpo" style="background-color: rgba(0,0,0,0.8); border-radius: 10px; padding: 10px">Control de asistencias y actividades internas</div>
                        </li>
                        <li data-transition="fade">
                            <img src="public/images/slider/image3.jpg" alt="" />
                            <div class="caption sfl bold stroke" data-x="center" data-y="200" data-speed="500" data-start="100" data-easing="easeOutExpo">Gestión de cursos de los Semilleros de Investigación</div>
                            <div class="caption sfr lite" data-x="center" data-y="274" data-speed="500" data-start="900" data-easing="easeOutExpo" style="background-color: rgba(0,0,0,0.8); border-radius: 10px; padding: 10px">Control de asistencias y actividades internas</div>
                        </li>
                        <li data-transition="fade">
                            <img src="public/images/slider/image4.jpg" alt="" />
                            <div class="caption sfl bold stroke" data-x="center" data-y="200" data-speed="500" data-start="100" data-easing="easeOutExpo">Proyectos de Investigación</div>
                            <div class="caption sfr lite" data-x="center" data-y="274" data-speed="500" data-start="900" data-easing="easeOutExpo" style="background-color: rgba(0,0,0,0.8); border-radius: 10px; padding: 10px">Control de asistencias y actividades internas</div>
                        </li>
                        <li data-transition="fade">
                            <img src="public/images/slider/image5.jpg" alt="" />
                            <div class="caption sfl bold stroke" data-x="center" data-y="200" data-speed="500" data-start="100" data-easing="easeOutExpo">Participa</div>
                            <div class="caption sfr lite" data-x="center" data-y="274" data-speed="500" data-start="900" data-easing="easeOutExpo" style="background-color: rgba(0,0,0,0.8); border-radius: 10px; padding: 10px">Control de asistencias y actividades internas</div>
                        </li>
                        <li data-transition="fade">
                            <img src="public/images/slider/image6.jpg" alt="" />
                            <div class="caption sfl bold stroke" data-x="center" data-y="200" data-speed="500" data-start="100" data-easing="easeOutExpo">Gestión de eventos de los Semilleros de Investigación</div>
                            <div class="caption sfr lite" data-x="center" data-y="274" data-speed="500" data-start="900" data-easing="easeOutExpo" style="background-color: rgba(0,0,0,0.8); border-radius: 10px; padding: 10px">Control de asistencias y actividades internas</div>
                        </li>

                    </ul>
                    <div class="tp-bannertimer tp-bottom"></div>
                </div>
            </div>

            <div class="container inner">

                <br />
                <div class="row services">
                    <div class="flats row text-center">
                        <div class="span12">
                            <h1>Bienvenido a la Herramienta Tecnológica</h1>
                            <p class="lead">para la Visualización Web y Gestión de Eventos de los Semilleros de Investigación de la Universidad de la Amazonia</p>
                            <%--<img src="public/images/fondo/UA.png" class="responsive" alt="" />--%>

                            <%--<div class="span5 offset1 text-center">
                                <div class="box box-primary">
                                    <div class="box-body box-profile">
                                        <h3>GIECOM</h3>
                                        <h5>Gestión del Conocimiento, Electrónica, Informática y Comunicaciones</h5>
                                        <p class="text-muted text-center">2017</p>
                                    </div>
                                </div>
                            </div>
                            <div class="span5 offset0 text-center">
                                <div class="box box-primary">
                                    <div class="box-body box-profile">
                                        <img src="public/images/fondo/giecom.png" class="responsive" alt="" />
                                    </div>
                                </div>
                            </div>--%>
                        </div>
                    </div>
                </div>
                <hr />
                <div class="divide10"></div>
                <div class="row services">
                    <div class="span3">
                        <div class="icon-wrapper purple">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-calendar.png" alt="" />
                            </div>
                            <!-- /.icon -->
                        </div>
                        <!-- /.icon-wrapper -->
                        <h1>Eventos</h1>
                        <p>Gestione las actividades internas en los Eventos realizados por los Semilleros de Investigación</p>
                    </div>
                    <!-- /.span3 -->
                    <div class="span3">
                        <div class="icon-wrapper red">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-controller.png" alt="" />
                            </div>
                            <!-- /.icon -->
                        </div>
                        <!-- /.icon-wrapper -->
                        <h1>Competencias</h1>
                        <p>Controle los participantes y la logística en las Competencias realizadas por los Semilleros</p>
                    </div>
                    <!-- /.span3 -->
                    <div class="span3">
                        <div class="icon-wrapper green">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-file.png" alt="" />
                            </div>
                            <!-- /.icon -->
                        </div>
                        <!-- /.icon-wrapper -->
                        <h1>Cursos</h1>
                        <p>Gestione las inscripciones y contenidos para los Cursos orientados desde los Semilleros</p>
                    </div>
                    <!-- /.span3 -->
                    <div class="span3">
                        <div class="icon-wrapper yellow">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-tv.png" alt="" />
                            </div>
                            <!-- /.icon -->
                        </div>
                        <!-- /.icon-wrapper -->
                        <h1>Noticias</h1>
                        <p>Conozca y participe en los trabajos de INVESTIGACIÓN desarrollados por los Semilleros</p>
                    </div>
                    <!-- /.span3 -->
                </div>

                <hr />
                <div class="row services">
                    <div class="flats row text-center">
                        <div class="span12">
                            <h1>Semilleros de Investigación</h1>
                            <p class="lead">Conozca cada uno de los Semilleros de la Universidad de la Amazonia</p>
                            <br />
                        </div>
                        <div class="span12">
                            <%--<div class="span5 offset1">
                                <h3>Facultad</h3>
                                <asp:DropDownList ID="t_facultad" OnSelectedIndexChanged="t_facultad_SelectedIndexChanged" Style="background-color: white; color: black" AutoPostBack="true" runat="server" CssClass="btn btn-block">
                                    <asp:ListItem Text="INGENIERÍA"></asp:ListItem>
                                    <asp:ListItem Text="CIENCIAS CONTABLES, ECONÓMICAS Y ADMINISTRATIVAS"></asp:ListItem>
                                </asp:DropDownList>
                            </div>--%>
                            <div class="span6 offset3 text-center" ng-init="getProgramas()">
                                <h3>Programa académico</h3>
                                <%--<asp:DropDownList ID="t_programa" ng-model="Mpio" ng-change="getProgramaSemillero(Mpio)" runat="server" Style="background-color: white; color: black" CssClass="btn btn-block">
                                    <asp:ListItem ng-repeat="l in listProgramas" Value="{{l.PROG_IDPROGRAMA}}" Text="{{l.PROG_NOMBRE}}"></asp:ListItem>
                                </asp:DropDownList>--%>
                                <select name="mpioficina" ng-model="Mpio" ng-change="getProgramaSemillero(Mpio)" style="background-color: white; color: black" class="btn btn-block" required="">
                                    <option ng-repeat="l in listProgramas" ng-value="{{l.PROG_IDPROGRAMA}}">{{l.PROG_NOMBRE}}</option>
                                </select>
                            </div>
                        </div>
                    </div>

                </div>
                <br />
                <br />
                <div class="row">
                    <div class="span12 offset0">
                        <div class="accordion" id="accordion" style="background-color: white">
                            <div class="accordion-group">
                                <div class="accordion-heading"><a class="accordion-toggle active" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">SEMILLEROS REGISTRADOS</a></div>
                                <div id="collapseOne" class="accordion-body collapse in">
                                    <div class="accordion-inner">
                                        <div class="responsive text-center" style="padding: 20px 40px">
                                            <p>{{Result}}</p>
                                            <table class="table table-hover" ng-if="Result == ''">
                                                <thead>
                                                    <tr>
                                                        <th>ID</th>
                                                        <th>NOMBRE</th>
                                                        <th>DESCRIPCIÓN</th>
                                                        <th>VER</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr ng-repeat="l in listSemillerosP">
                                                        <td>{{l.SMLR_IDSEMILLERO}}</td>
                                                        <td>{{l.SMLR_NOMBRE}}</td>
                                                        <td>{{l.SMLR_DESCRIPCION}}</td>
                                                        <td>
                                                            <span class="label label-warning">
                                                                <a style="color: white; padding: 30px 10px" href="Semilleros.aspx?id={{l.SMLR_IDSEMILLERO}}" target="_blank">Ver semillero</a>
                                                            </span>
                                                        </td>
                                                    </tr>
                                                    <%--<% for (int i = 0; i < semilleros.Rows.Count; i++)
                                                        {
                                                            row = semilleros.Rows[i];
                                                    %>
                                                    <tr>
                                                        <td>
                                                            <%= (i+1) %>
                                                        </td>
                                                        <td>
                                                            <%= row["smlr_Nombre"].ToString() %>
                                                        </td>
                                                        <td>
                                                            <%= row["smlr_Descripcion"].ToString() %>
                                                        </td>
                                                        <td>
                                                            <span class="label label-warning">
                                                                <a style="color: white; padding: 30px 10px" href="Semilleros.aspx?id=<%= row["smlr_idSemillero"].ToString() %>" target="_blank">Ver semillero</a>
                                                            </span>
                                                        </td>
                                                    </tr>

                                                    <%  } %>--%>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <%--<div class="row">
                    <% for (int i = 0; i < semilleros.Rows.Count; i++)
                        {
                            row = semilleros.Rows[i];
                    %>

                    <div class="span4">
                        <div class="alert alert-success text-center">
                            <h3 class="section-title"><%= row["smlr_Nombre"].ToString() %></h3>
                            <p><%= row["smlr_Descripcion"].ToString() %></p>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="alert alert-success text-center">
                            <h3 class="section-title"><%= row["smlr_Nombre"].ToString() %></h3>
                            <p><%= row["smlr_Descripcion"].ToString() %></p>
                        </div>
                    </div>
                    <%  } %>
                </div>--%>

                <%-- <div class="container inner" ng-init="getSemilleros()">

                <div class="fix-portfolio">

                    <ul class="items thumbs">
                        <% for (int i = 0; i < semilleros.Rows.Count; i++)
                            {
                                row = semilleros.Rows[i];
                        %>
                        <li class="item overlay thumb graphic text-center"><a href="Semilleros.aspx?id=<%= row["smlr_idSemillero"].ToString() %>">
                            <img src="<%= row["smlr_RutaLogo"].ToString() %>" alt="" />
                            <div>
                                <h5><%= row["smlr_Nombre"].ToString() %><span><%= row["smlr_Descripcion"].ToString() %></span></h5>
                            </div>
                        </a></li>
                        <%} %>
                    </ul>
                </div>
            </div>--%>

            </div>
        </div>



        <div class="offset"></div>
        <div class="map">
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3988.22393997928!2d-75.60620658570387!3d1.6198376988187821!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8e244e2307a3b2af%3A0x2eb9e14897cad6c7!2sUniversidad+de+la+Amazonia!5e0!3m2!1ses!2ses!4v1485917545746" width="100%" height="450" frameborder="0" style="border: 0" allowfullscreen></iframe>
        </div>


        <footer class="black-wrapper">
            <div class="container inner">
                <div class="row">
                    <section class="span3 offset2 widget">
                        <br />
                        <img src="public/images/fondo/giecom.png" class="responsive" alt="" />
                    </section>
                    <section class="span6 widget">

                        <br />
                        <h3 class="section-title widget-title">¿QUIENES SOMOS?</h3>
                        <p>
                            <b>GIECOM</b> - Gestión del Conocimiento-Electrónica-Informática y Comunicaciones.
                        </p>
                        <div class="divide10"></div>
                        <i class="icon-location contact"></i>Universidad de la Amazonia, Sede Porvenir, Florencia Caquetá.
                            <br />
                        <i class="icon-phone contact"></i>+57 310 862 1408
                            <br />
                        <i class="icon-mail contact"></i><a href="#">giecom@uniamazonia.edu.co</a>
                    </section>
                    <!-- /.widget -->
                </div>
                <!-- /.row -->

                <hr />
                <p class="pull-left">© 2017 <a href="http://giecom.udla.edu.co/" target="_blank">Giecom</a>. Todos los derechos reservados. <a target="_blank" href="http://www.udla.edu.co/v10/">Universidad de la Amazonia</a>.</p>
                <ul class="social pull-right">
                    <li><a target="_blank" href="https://twitter.com/giecom_udla"><i class="icon-s-twitter"></i></a></li>
                    <li><a target="_blank" href="https://www.facebook.com/GiecomFC/?fref=ts"><i class="icon-s-facebook"></i></a></li>
                    <li><a target="_blank" href="#"><i class="icon-s-youtube"></i></a></li>
                </ul>
            </div>
            <!-- .container -->
        </footer>
        <!-- /footer -->
        </div>
        <!--/.body-wrapper-->
        <script src="public/index/style/js/jquery.js"></script>
        <script src="public/index/style/js/bootstrap.min.js"></script>
        <script src="public/index/style/js/twitter-bootstrap-hover-dropdown.min.js"></script>
        <script src="public/index/style/js/jquery.themepunch.plugins.min.js"></script>
        <script src="public/index/style/js/jquery.themepunch.revolution.min.js"></script>
        <script src="public/index/style/js/jquery.themepunch.showbizpro.min.js"></script>
        <script src="public/index/style/js/jquery.isotope.min.js"></script>
        <script src="public/index/style/js/jquery.hoverdir.min.js"></script>
        <script src="public/index/style/js/jquery.slickforms.js"></script>
        <script src="public/index/style/js/jquery.easytabs.min.js"></script>
        <script src="public/index/style/js/jquery.fitvids.js"></script>
        <script src="public/index/style/js/view.min9df2.js?auto"></script>
        <script src="public/index/style/js/scripts.js"></script>
        <!-- DEMO ONLY -->
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/blue.css" title="marbleblue-color" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/gray.css" title="marblegray-color" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/green.css" title="marblegreen-color" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/navy.css" title="marblenavy-color" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/orange.css" title="marbleorange-color" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/pink.css" title="marblepink-color" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/purple.css" title="marblepurple-color" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/red.css" title="marblered-color" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer1.css" title="marble1-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer2.css" title="marble2-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer3.css" title="marble3-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer4.css" title="marble4-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer5.css" title="marble5-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer6.css" title="marble6-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer7.css" title="marble7-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer8.css" title="marble8-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/footer9.css" title="marble9-footer" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header1.css" title="marble1-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header2.css" title="marble2-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header3.css" title="marble3-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header4.css" title="marble4-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header5.css" title="marble5-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header6.css" title="marble6-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header7.css" title="marble7-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header8.css" title="marble8-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header9.css" title="marble9-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header10.css" title="marble10-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header11.css" title="marble11-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header12.css" title="marble12-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header13.css" title="marble13-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header14.css" title="marble14-header" media="screen" />
        <link rel="alternate stylesheet" type="text/css" href="public/index/switcher/header15.css" title="marble15-header" media="screen" />
        <script type="text/javascript" src="public/index/switcher/switchstylesheet.js"></script>
        <script type="text/javascript">
            $(document).ready(function () {
                $(".changecolor").switchstylesheet({ seperator: "color" });
                $(".changeheader").switchstylesheet({ seperator: "header" });
                $(".changefooter").switchstylesheet({ seperator: "footer" });
            });
</script>
    </form>
</body>
</html>
