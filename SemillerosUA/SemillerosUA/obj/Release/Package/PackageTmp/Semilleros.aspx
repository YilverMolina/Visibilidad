<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Semilleros.aspx.cs" Inherits="SemillerosUA.Semilleros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <title>Semilleros UDLA</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link rel="shortcut icon" type="image/x-icon" href="public/index/style/images/favicon.png" />
    <%--<link href="public/index/style/css/agency.css" rel="stylesheet" />--%>
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

    <script type="text/javascript">
        function openInfo() {
            $('#info').modal()
        }
    </script>
</head>
<body ng-app="UDLA">
    <form id="form1" runat="server">
        <div class="body-wrapper">

            <div id="header" class="navbar navbar-fixed-top">
                <div class="navbar-inner">
                    <div class="container">
                        <a class="btn responsive-menu pull-right" data-toggle="collapse" data-target=".nav-collapse"><i class='icon-menu-1'></i></a><a class="brand" href="index.html">
                            <img src="public/index/style/images/logo.png" alt="" />
                            <%--<h2>Universidad de la Amazonia</h2>--%>
                        </a>
                        <div class="nav-collapse pull-right collapse">
                            <ul class="nav">
                                <li class="dropdown"><a href="#news">Noticias</a></li>
                                <li class="dropdown"><a href="#activities">Actividades</a></li>
                                <li><a href="Views/Home/Login.aspx?id=<%= row["smlr_idSemillero"].ToString() %>" target="_blank">Ingresar</a></li>
                                <li><a href="Index.aspx">Inicio</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class="offset"></div>
            <div class="container inner">
                <div class="divide20"></div>
                <div class="fix-portfolio">
                    <div class="span1"></div>
                    <div class="span3">
                        <ul class="items thumbs">
                            <li class="item overlay thumb graphic"><a href="portfolio-post.html">
                                <img src="<%= row["smlr_RutaLogo"].ToString() %>" alt="" />
                            </a></li>
                        </ul>
                    </div>
                    <div class="span6 text-center">
                        <br />
                        <h1>
                            <asp:Label ID="NombreSemillero" runat="server" Font-Size="30pt" Text=""></asp:Label>
                        </h1>
                        <p style="font-size: 12pt">
                            <asp:Label ID="Descripcion" runat="server" Text=""></asp:Label>
                        </p>
                        <a href="#" onclick="openInfo()" class="btn btn-blue"><i class="icon-home"></i><%= row["griv_Nombre"].ToString() %></a>
                    </div>
                </div>
                <hr />

                <div class="row services">
                    <div class="span1"></div>
                    <div class="span5">
                        <div class="box">
                            <div class="box-body">
                                <div class="icon-wrapper purple">
                                    <div class="icon">
                                        <img src="public/index/style/images/icon/icon-lamp.png" alt="" />
                                    </div>
                                </div>
                                <h4>Misión</h4>
                                <p><%= row["smlr_Mision"].ToString() %></p>
                            </div>
                        </div>
                    </div>
                    <div class="span5">
                        <div class="icon-wrapper red">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-clock.png" alt="" />
                            </div>
                        </div>
                        <h4>Visión</h4>
                        <p><%= row["smlr_Vision"].ToString() %></p>
                    </div>
                </div>
                <hr />
                <%--<div class="row services" ng-controller="GeneralController" ng-init="getRoles()">
                    <div class="span3" ng-repeat="l in listRoles">
                        <div class="icon-wrapper purple">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-lamp.png" alt="" />
                            </div>
                        </div>
                        <h4>{{l.NombreRol}}</h4>
                    </div>
                </div>--%>

                <section id="news">
                    <h4 class="section-title">NOTICIAS</h4>
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
                                    <!-- /.post -->
                                </ul>
                                <div class="clearfix"></div>
                            </div>
                            <!-- /.overflowholder -->

                            <div class="clearfix"></div>
                        </div>
                        <!-- /.showbiz -->
                    </div>
                </section>

                <hr />
                <h4 class="section-title">ACTIVIDADES REALIZADAS</h4>
                <div class="showbiz-container posts">
                    <div class="showbiz-navigation">
                        <a id="showbiz_left2" class="sb-navigation-left btn"></a><a id="showbiz_right2" class="sb-navigation-right btn rm0"></a>
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
                                <!-- /.post -->
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <!-- /.overflowholder -->

                        <div class="clearfix"></div>
                    </div>
                    <!-- /.showbiz -->
                </div>
                <!-- /.showbiz-container -->

            </div>
            <!--/.container -->

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
            <div id="info" class="modal fade" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h2 class="modal-title"><b>Grupo de investigación</b></h2>
                        </div>
                        <div class="modal-body">
                            <p>
                                <b>GIECOM - </b>Gestión del Conocimiento en Electrónica y Comunicaciones.
                                
                            </p>
                            <b>Director: </b>HERIBERTO VARGAS LOSADA
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-blue" data-dismiss="modal">Aceptar</button>
                        </div>
                    </div>
                </div>
            </div>
            <footer class="black-wrapper">
                <div class="container inner">
                    <div class="row">
                        <section class="span4 widget">
                            <h3 class="section-title widget-title">Popular Posts</h3>
                            <ul class="post-list">
                                <li>
                                    <h6><a href="blog-post.html">Vivamus sagittis lacus vel augue metus</a></h6>
                                    <em>3th Oct 2012</em> </li>
                                <li>
                                    <h6><a href="blog-post.html">Scelerisque nisl consectetur et</a></h6>
                                    <em>28th Sep 2012</em> </li>
                                <li>
                                    <h6><a href="blog-post.html">Pellentesque ornare sem lacinia quam</a></h6>
                                    <em>15th Aug 2012</em> </li>
                            </ul>
                            <!-- /.post-list -->
                        </section>
                        <!-- /.widget -->
                        <section class="span4 widget">
                            <h3 class="section-title widget-title">Tags</h3>
                            <div class="tagcloud"><a href="#" style="font-size: 9pt;">blogroll</a> <a href="#" style="font-size: 19pt;">daily</a> <a href="#" style="font-size: 9pt;">dialog</a> <a href="#" style="font-size: 9pt;">gallery</a> <a href="#" style="font-size: 10pt;">journal</a> <a href="#" style="font-size: 9pt;">link</a> <a href="#" style="font-size: 12pt;">motion</a> <a href="#" style="font-size: 9pt;">music</a> <a href="#" style="font-size: 20pt;">photo</a> <a href="#" style="font-size: 13pt;">professional</a> <a href="#" style="font-size: 16pt;">quotation</a> <a href="#" style="font-size: 9pt;">show</a> <a href="#" style="font-size: 15pt;">sound</a> <a href="#" style="font-size: 9pt;">tv</a> <a href="#" style="font-size: 9pt;">video</a> <a href="#" style="font-size: 9pt;">gift</a> <a href="#" style="font-size: 19pt;">label</a> <a href="#" style="font-size: 9pt;">christmas</a> <a href="#" style="font-size: 9pt;">holiday</a> <a href="#" style="font-size: 10pt;">fun</a> <a href="#" style="font-size: 9pt;">recipes</a> <a href="#" style="font-size: 12pt;">concert</a> <a href="#" style="font-size: 9pt;">drinks</a> <a href="#" style="font-size: 20pt;">apps</a> <a href="#" style="font-size: 13pt;">iphone</a> <a href="#" style="font-size: 16pt;">ipad</a> <a href="#" style="font-size: 9pt;">develop</a> <a href="#" style="font-size: 15pt;">marketing</a> <a href="#" style="font-size: 9pt;">strategy</a> <a href="#" style="font-size: 13pt;">food</a> <a href="#" style="font-size: 12pt;">typography</a> <a href="#" style="font-size: 9pt;">mobile</a> <a href="#" style="font-size: 15pt;">envato</a> <a href="#" style="font-size: 9pt;">icon</a> <a href="#" style="font-size: 9pt;">coda</a> <a href="#" style="font-size: 20pt;">jquery</a> <a href="#" style="font-size: 9pt;">cms</a> </div>
                        </section>
                        <!-- /.widget -->
                        <section class="span4 widget">
                            <h3 class="section-title widget-title">Get In Touch</h3>
                            <p>Fusce dapibus, tellus commodo, tortor mauris condimentum utellus fermentum, porta sem malesuada magna. Sed posuere consectetur est at lobortis. Morbi leo risus, porta ac consectetur.</p>
                            <div class="divide10"></div>
                            <i class="icon-location contact"></i>Moonshine St. 14/05 Light City, Jupiter
                            <br />
                            <i class="icon-phone contact"></i>+00 (123) 456 78 90
                            <br />
                            <i class="icon-mail contact"></i><a href="first.last%40email.html">first.last@email.com</a>
                        </section>
                        <!-- /.widget -->
                    </div>
                    <!-- /.row -->

                    <hr />
                    <p class="pull-left">© 2013 Marble. All rights reserved. Theme by <a href="http://elemisfreebies.com/">elemis</a>.</p>
                    <ul class="social pull-right">
                        <li><a href="#"><i class="icon-s-rss"></i></a></li>
                        <li><a href="#"><i class="icon-s-twitter"></i></a></li>
                        <li><a href="#"><i class="icon-s-facebook"></i></a></li>
                        <li><a href="#"><i class="icon-s-dribbble"></i></a></li>
                        <li><a href="#"><i class="icon-s-pinterest"></i></a></li>
                    </ul>
                </div>
                <!-- .container -->
            </footer>
            <!-- /footer -->
        </div>
        <!--/.body-wrapper-->
        <script src="public/index/style/js/jquery.js"></script>
        <script src="public/index/style/js/jquery.min.js"></script>
        <script src="public/index/style/js/bootstrap.min.js"></script>
        <script src="public/index/style/js/bootstrap2.min.js"></script>
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
