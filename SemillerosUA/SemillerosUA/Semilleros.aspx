<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Semilleros.aspx.cs" Inherits="SemillerosUA.Semilleros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <title><%= row["SMLR_NOMBRE"].ToString() %></title>
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
            color: #1abb9c;
            font-size: 30pt;
            text-shadow: -2px -2px 0 #000000, 2px -2px 0 #000000, -2px 2px 0 #000000, 2px 2px 0 #000000;
            font-weight: bold;
        }

        .descripcion {
            color: black;
        }
    </style>

</head>
<body ng-app="UDLA" style="background-color: white">
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
                                <li class="dropdown"><a href="Views/Home/Login.aspx?id=<%= row["SMLR_IDSEMILLERO"].ToString() %>" class="btn btn-warning" target="_blank">
                                    <i class="icon-login"></i>
                                    Ingresar como líder del semillero</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class="offset"></div>
            <div class="container inner">

                <br />
                <div class="row services">
                    <div class="flats row text-center">
                        <div class="span12">
                            <div class="span4 offset4">
                                <img src="<%= row["SMLR_RUTALOGO"].ToString() %>" style="box-shadow: 5px 5px 5px #888888;" alt="" />
                            </div>
                            <div class="span12">
                                <br />
                                <h1 class="stroke"><%= row["SMLR_NOMBRE"].ToString() %></h1>
                                <hr />
                                <p class="lead descripcion"><%= row["SMLR_DESCRIPCION"].ToString() %></p>
                                <span class="label label-info" style="font-size: 14pt; padding: 10px">Grupo de investigación: <%= row["GRIV_NOMBRE"].ToString() %>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <hr />
                <div class="divide10"></div>
                <div class="row services">
                    <div class="span12">
                        <div class="icon-wrapper purple">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-calendar.png" alt="" />
                            </div>
                        </div>
                        <h1>Misión</h1>
                        <p><%= row["SMLR_MISION"].ToString() %></p>
                    </div>

                    <div class="span12">
                        <hr />
                        <div class="icon-wrapper red">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-controller.png" alt="" />
                            </div>
                        </div>
                        <h1>Visión</h1>
                        <p><%= row["SMLR_VISION"].ToString() %></p>
                    </div>
                </div>
                <hr />
                <h3>OBJETIVOS DEL SEMILLERO</h3><br />
                <div class="row media-icons">
                    <div class="media span6 rp10">
                        <i class="icon-lamp large pull-left"></i>
                        <!--/.pull-left-->
                        <div class="media-body">
                            <h4>Gestión de eventos</h4>
                            <p>Donec elit non mi porta gravida at eget metus. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum ligula porta felis cras ridiculus.</p>
                        </div>
                        <!--/.media-body-->
                    </div>
                    <!--/.media-->
                    <div class="media span6 lp10">
                        <i class="icon-rocket large pull-left"></i>
                        <!--/.pull-left-->
                        <div class="media-body">
                            <h4>Gestión de cursos</h4>
                            <p>Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Donec id elit non mi porta.</p>
                        </div>
                        <!--/.media-body-->
                    </div>
                    <!--/.media-->

                    <div class="media span6 rp10">
                        <i class="icon-beaker large pull-left"></i>
                        <!--/.pull-left-->
                        <div class="media-body">
                            <h4>Gestión de competencias</h4>
                            <p>Mollis est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem elit. Aenean lacinia bibendum nulla consectetur. Integer posuere erat.</p>
                        </div>
                    </div>
                    <div class="media span6 lp10">
                        <i class="icon-award large pull-left"></i>
                        <div class="media-body">
                            <h4>Award Winning</h4>
                            <p>Morbi leo risus, porta ac consectetur, vestibulum at eros. Praesent commodo cursus magna, vel scelerisque nisl consectetur et aenean lacinia.</p>
                        </div>
                    </div>
                </div>


                <br />

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

                <hr />
                <h4 class="section-title">NUESTRAS ACTIVIDADES</h4>
                <div class="showbiz-container posts">
                    <div class="showbiz-navigation">
                        <a id="showbiz_left" class="sb-navigation-left btn"></a><a id="showbiz_right" class="sb-navigation-right btn rm0"></a>
                        <div class="sbclear"></div>
                    </div>

                    <div class="showbiz portfolio" data-left="#showbiz_left" data-right="#showbiz_right">
                        <div class="overflowholder">
                            <ul>
                                <li class="post">
                                    <div class="mediaholder">
                                        <div class="mediaholder_innerwrap overlay cap-icon enlarge">
                                            <a href="public/index/style/images/art/p1.jpg" class="view" data-rel="lightbox" title="Wood Logo">
                                                <img src="public/index/style/images/art/p1.jpg" alt="" />
                                                <div></div>
                                            </a>
                                        </div>
                                    </div>
                                    <div class="detailholder">
                                        <h4 class="post-title"><a href="portfolio-post.html">Wood Logo</a></h4>
                                        <div class="meta"><a href="#">Logo</a> <a href="#">Texture</a></div>
                                        <p>Morbi leo risus, porta ac consectetur ac. Porta sagittis lacus vel. Fusce dapibus, tellus ac lacinia quam venenatis.</p>
                                    </div>
                                </li>
                                <!-- /.post -->
                                <li class="post">
                                    <div class="mediaholder">
                                        <div class="mediaholder_innerwrap overlay cap-icon enlarge">
                                            <a href="public/index/style/images/art/p2.jpg" class="view" data-rel="lightbox" title="Stationary Branding">
                                                <img src="public/index/style/images/art/p2.jpg" alt="" />
                                                <div></div>
                                            </a>
                                        </div>
                                    </div>
                                    <div class="detailholder">
                                        <h4 class="post-title"><a href="portfolio-post2.html">Stationary Branding</a></h4>
                                        <div class="meta"><a href="#">Branding</a> <a href="#">Identity</a></div>
                                        <p>Nulla vitae elit libero, a pharetra augue. Donec sed rutrum faucibus dolor auctor laoreet metus auctor fringilla.</p>
                                    </div>
                                </li>
                                <!-- /.post -->
                                <li class="post">
                                    <div class="mediaholder">
                                        <div class="mediaholder_innerwrap overlay cap-icon enlarge">
                                            <a href="public/index/style/images/art/p3.jpg" class="view" data-rel="lightbox" title="Flyer Presentation">
                                                <img src="public/index/style/images/art/p3.jpg" alt="" />
                                                <div></div>
                                            </a>
                                        </div>
                                    </div>
                                    <div class="detailholder">
                                        <h4 class="post-title"><a href="portfolio-post3.html">Flyer Presentation</a></h4>
                                        <div class="meta"><a href="#">Flyer</a> <a href="#">Poster</a></div>
                                        <p>Curabitur blandit tempus porttitor. Donec id elit non. Vivamus sagittis lacus vel augue lacinia odio sem nec elit.</p>
                                    </div>
                                </li>
                                <!-- /.post -->
                                <li class="post">
                                    <div class="mediaholder">
                                        <div class="mediaholder_innerwrap overlay cap-icon enlarge">
                                            <a href="public/index/style/images/art/p4.jpg" class="view" data-rel="lightbox" title="Alpha iPhone App">
                                                <img src="public/index/style/images/art/p4.jpg" alt="" />
                                                <div></div>
                                            </a>
                                        </div>
                                    </div>
                                    <div class="detailholder">
                                        <h4 class="post-title"><a href="portfolio-post4.html">Alpha iPhone App</a></h4>
                                        <div class="meta"><a href="#">UI</a> <a href="#">Mobile</a></div>
                                        <p>Nulla vitae elit libero, nisi est pharetra augue. Maecenas diam eget risus varius blandit purus sit amet fermentum.</p>
                                    </div>
                                </li>
                                <!-- /.post -->
                                <li class="post">
                                    <div class="mediaholder">
                                        <div class="mediaholder_innerwrap overlay cap-icon enlarge">
                                            <a href="public/index/style/images/art/p5.jpg" class="view" data-rel="lightbox" title="MU Business Card">
                                                <img src="public/index/style/images/art/p5.jpg" alt="" />
                                                <div></div>
                                            </a>
                                        </div>
                                    </div>
                                    <div class="detailholder">
                                        <h4 class="post-title"><a href="portfolio-post5.html">MU Business Card</a></h4>
                                        <div class="meta"><a href="#">Business Card</a> <a href="#">Identity</a></div>
                                        <p>Praesent commodo cursus, scelerisque nisl consectetur. Morbi risus, porta consectetur malesuada magna mollis.</p>
                                    </div>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>


        <div class="dark-wrapper">
            <div class="container inner">
                <div id="testimonials" class="tab-container">
                    <div class="panel-container">
                        <div id="tst1">Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Nullam id dolor id nibh ultricies vehicula ut id elit. Praesent commodo cursus magna. <span class="author">Nikolas Brooten</span> </div>
                        <div id="tst2">Cras justo odio, dapibus ac facilisis in, egestas eget quam. Maecenas faucibus mollis interdum. Etiam porta sem malesuada magna mollis euismod. <span class="author">Coriss Ambady</span> </div>
                        <div id="tst3">Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Donec sed odio dui. Aenean lacinia bibendum nulla sed consectetur. <span class="author">Barclay Widerski</span> </div>
                        <div id="tst4">Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor gravida at eget metus. <span class="author">Elsie Spear</span> </div>
                    </div>
                    <ul class="etabs">
                        <li class="tab"><a href="#tst1">1</a></li>
                        <li class="tab"><a href="#tst2">2</a></li>
                        <li class="tab"><a href="#tst3">3</a></li>
                        <li class="tab"><a href="#tst4">4</a></li>
                    </ul>
                </div>
            </div>
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
