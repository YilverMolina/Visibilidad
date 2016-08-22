<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SemillerosUA.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <title>Inicio | Semilleros UDLA</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link rel="shortcut icon" type="image/x-icon" href="public/index/style/images/favicon.png" />
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

</head>
<body ng-app="UDLA">
    <form id="form1" runat="server">
        <div class="body-wrapper" ng-controller="GeneralController">
            <div id="header" class="navbar navbar-fixed-top">
                <div class="navbar-inner">
                    <div class="container">
                        <a class="btn responsive-menu pull-right" data-toggle="collapse" data-target=".nav-collapse"><i class='icon-menu-1'></i></a><a class="brand" href="index.html">
                            <img src="public/index/style/images/logo.png" alt="" />
                        </a>
                        <div class="nav-collapse pull-right collapse">
                            <ul class="nav">
                                <li class="dropdown"><a href="Index.aspx">Inicio</a>
                                </li>
                                <li class="dropdown"><a href="#" class="dropdown-toggle js-activated">Noticias</a>
                                </li>
                                <li class="dropdown"><a href="#" class="dropdown-toggle js-activated">Calendario</a>
                                </li>
                                <li class="dropdown"><a href="Views/Home/Login.aspx" target="_blank">Ingresar</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class="offset"></div>
            <div class="fullwidthbanner-container revolution">
                <div class="fullwidthbanner">
                    <ul>
                        <li data-transition="fade">
                            <img src="public/images/slider/1.jpg" alt="" />
                            <div class="caption sfl bold" data-x="center" data-y="200" data-speed="500" data-start="100" data-easing="easeOutExpo">We are a digital & branding agency based in London.</div>
                            <div class="caption sfr lite" data-x="center" data-y="274" data-speed="500" data-start="900" data-easing="easeOutExpo">We love to turn great ideas into beautiful products.</div>
                            <div class="caption sfb" data-x="center" data-y="345" data-speed="900" data-start="1600" data-easing="easeOutExpo"><a href="#" class="btn btn-blue btn-large">Get in Touch</a></div>
                        </li>
                        <li data-transition="fade">
                            <img src="public/images/slider/2.jpg" style="background-color: #323a45;" alt="" />
                            <div class="caption sfl" data-x="450" data-y="115" data-speed="900" data-start="100" data-easing="easeOutSine">
                                <img src="public/index/style/images/art/slider-browser.png" alt="" />
                            </div>
                            <div class="caption sfl" data-x="800" data-y="180" data-speed="900" data-start="900" data-easing="easeOutSine">
                                <img src="public/index/style/images/art/slider-tablet.png" alt="" />
                            </div>
                            <div class="caption sfl" data-x="980" data-y="290" data-speed="900" data-start="1600" data-easing="easeOutSine">
                                <img src="public/index/style/images/art/slider-mobile.png" alt="" />
                            </div>
                            <div class="caption sfl bold" data-x="35" data-y="180" data-speed="900" data-start="1500" data-easing="easeOutExpo"><strong>We design & build</strong></div>
                            <div class="caption sfr bold" data-x="35" data-y="240" data-speed="900" data-start="1800" data-easing="easeOutExpo"><strong><span class="color">responsive</span> themes</strong></div>
                            <div class="caption sfb" data-x="35" data-y="320" data-speed="900" data-start="2100" data-easing="easeOutExpo"><a href="#" class="btn btn-green btn-large">Get in Touch</a></div>
                        </li>
                        <li data-transition="fade">
                            <img src="public/images/slider/3.jpg" alt="" />
                            <div class="caption sft" data-x="50" data-y="115" data-speed="900" data-start="100" data-easing="easeOutSine">
                                <img src="public/index/style/images/art/slider-back.png" alt="" />
                            </div>
                            <div class="caption fade" data-x="35" data-y="465" data-speed="900" data-start="120" data-easing="easeOutSine">
                                <img src="public/index/style/images/art/slider-shadow.png" alt="" />
                            </div>
                            <div class="caption sft" data-x="35" data-y="122" data-speed="900" data-start="800" data-easing="easeOutSine">
                                <img src="public/index/style/images/art/slider-middle.png" alt="" />
                            </div>
                            <div class="caption sft" data-x="60" data-y="130" data-speed="900" data-start="1300" data-easing="easeOutSine">
                                <img src="public/index/style/images/art/slider-first.png" alt="" />
                            </div>
                            <div class="caption sft bold" data-x="590" data-y="200" data-speed="900" data-start="2000" data-easing="easeOutExpo">Showcase your business</div>
                            <div class="caption sfr bold" data-x="590" data-y="265" data-speed="900" data-start="2500" data-easing="easeOutExpo">with editable PSD mockups</div>
                            <div class="caption sfb" data-x="590" data-y="340" data-speed="900" data-start="3000" data-easing="easeOutExpo"><a href="#" class="btn btn-blue btn-large">Purchase Now</a></div>
                        </li>
                        <li data-transition="fade">
                            <img src="public/images/slider/4.jpg" style="background-color: #666361;" alt="" />
                            <div class="caption lfr" data-x="750" data-y="115" data-speed="900" data-start="100" data-easing="easeOutSine">
                                <img src="public/index/style/images/art/slider-coffee-cup.png" alt="" />
                            </div>
                            <div class="caption sfl bold" data-x="35" data-y="200" data-speed="900" data-start="1000" data-easing="easeOutExpo">Just sit and relax</div>
                            <div class="caption sfl lite" data-x="35" data-y="265" data-speed="900" data-start="1500" data-easing="easeOutExpo">while we take care of your business</div>
                            <div class="caption sfl" data-x="35" data-y="340" data-speed="900" data-start="2000" data-easing="easeOutExpo"><a href="#" class="btn btn-green btn-large">See Pricing</a></div>
                        </li>
                    </ul>
                    <div class="tp-bannertimer tp-bottom"></div>
                </div>
            </div>

            <div class="container inner">
                <div class="row services">
                    <div class="span3">
                        <div class="icon-wrapper purple">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-lamp.png" alt="" />
                            </div>
                        </div>
                        <h4>Creative Ideas</h4>
                        <p>Nulla vitae  libero, a pharetra augue. Integer posuere a ante venenatis  nulla. Nullam quis risus eget urna mollis ornare.</p>
                    </div>
                    <div class="span3">
                        <div class="icon-wrapper red">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-clock.png" alt="" />
                            </div>
                        </div>
                        <h4>Rapid Solutions</h4>
                        <p>Vestibulum id ligula porta  euismod semper. Aenean lacinia bibendum nulla sed. Maecenas sed diam eget risus.</p>
                    </div>
                    <div class="span3">
                        <div class="icon-wrapper blue">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-tube2.png" alt="" />
                            </div>
                        </div>
                        <h4>Magic Touch</h4>
                        <p>Fusce dapibus commodo, tortor mauris condimentum nibh, ut fermentum massa justo. Sed posuere consectetur est.</p>
                    </div>
                    <!-- /.span3 -->
                    <div class="span3">
                        <div class="icon-wrapper yellow">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-ticket.png" alt="" />
                            </div>
                        </div>
                        <h4>Award Winning</h4>
                        <p>Aenean eu leo quam. Pellente ornare sem lacinia quam venenatis vestibulum sagittis. Nullam quis risus eget urna.</p>
                    </div>
                </div>
                <hr />
                <%--<div class="row services" ng-init="getRoles()">
                    <div class="span3" ng-repeat="l in listRoles">
                        <div class="icon-wrapper purple">
                            <div class="icon">
                                <img src="public/index/style/images/icon/icon-lamp.png" alt="" />
                            </div>
                        </div>
                        <h4>{{l.NombreRol}}</h4>
                    </div>
                </div>--%>
                <div class="row services">

                    <div class="flats row text-center">
                        <div class="span4"></div>
                        <div class="span1">
                            <div class="icon-wrapper red">
                                <div class="icon">
                                    <img src="public/index/style/images/icon/icon-monitor.png" alt="" />
                                </div>
                            </div>
                        </div>
                        <div class="span1">
                            <div class="icon-wrapper blue">
                                <div class="icon">
                                    <img src="public/index/style/images/icon/icon-tube2.png" alt="" />
                                </div>
                            </div>
                        </div>
                        <div class="span1">
                            <div class="icon-wrapper yellow">
                                <div class="icon">
                                    <img src="public/index/style/images/icon/icon-leaf.png" alt="" />
                                </div>
                            </div>
                        </div>
                        <div class="span1">
                            <div class="icon-wrapper green">
                                <div class="icon">
                                    <img src="public/index/style/images/icon/icon-portfolio3.png" alt="" />
                                </div>
                            </div>
                        </div>
                        <div class="span12">
                            <h1>Semilleros de Investigación Universidad de la Amazonia</h1>
                            <%--<p class="lead">Semilleros registrados en nuestra Plataforma.</p>--%>
                        </div>
                    </div>

                </div>
                <div class="container inner" ng-init="getSemilleros()">

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
                            <%--<li class="item overlay thumb graphic" ng-repeat="l in listSemilleros">
                                <a href="Semilleros.aspx?id={{l.idSemillero}}">
                                    <img src="public/index/style/images/art/p1.jpg" alt="" />
                                    <div>
                                        <h5>{{l.Nombre}}<span>{{l.Descripcion}}</span></h5>
                                    </div>
                                </a>
                            </li>--%>
                        </ul>
                    </div>
                </div>

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

            <div class="container">
                <hr />
                <h3 class="section-title">NUESTRO EQUIPO DE TRABAJO</h3>
                <div class="row">
                    <div class="span4">
                        <figure class="media-wrapper">
                            <img src="public/index/style/images/art/team1.jpg" alt="" />
                        </figure>
                        <div class="details">
                            <h4>Heriberto Vargas Losada<span>Director de GIECOM</span></h4>
                            <p>
                                Ingeniero de Sistemas, graduado de la Universidad Distrital Francisco José de Caldas y 
                                actualmente docente e investigador en la Universidad de la Amazonia.
                            </p>
                            <ul class="social">
                                <li><a href="#"><i class="icon-s-twitter"></i></a></li>
                                <li><a href="#"><i class="icon-s-facebook"></i></a></li>
                                <li><a href="#"><i class="icon-s-pinterest"></i></a></li>
                            </ul>
                        </div>
                        <br />
                    </div>
                    <div class="span4">
                        <figure class="media-wrapper">
                            <img src="public/index/style/images/art/team2.jpg" alt="" />
                        </figure>
                        <div class="details">
                            <h4>Milher Tovar Rubiando<span>Colaborador GIECOM</span></h4>
                            <p>
                                Ingeniero Mecatrónico, graduado de la Universidad Nacional de Colombia y 
                                actualmente docente e investigador en la Universidad de la Amazonia.
                            </p>
                            <ul class="social">
                                <li><a href="#"><i class="icon-s-twitter"></i></a></li>
                                <li><a href="#"><i class="icon-s-facebook"></i></a></li>
                                <li><a href="#"><i class="icon-s-linkedin"></i></a></li>
                            </ul>
                        </div>
                        <br />
                    </div>
                    <div class="span4">
                        <figure class="media-wrapper">
                            <img src="public/index/style/images/art/team3.jpg" alt="" />
                        </figure>
                        <div class="details">
                            <h4>Diana Espinosa Sarmiento<span>Colaboradora GIECOM</span></h4>
                            <p>
                                Ingeniera de Sistemas, graduada de la Universidad Industrial de Santander y 
                                actualmente docente e investigadora en la Universidad de la Amazonia.
                            </p>
                            <ul class="social">
                                <li><a href="#"><i class="icon-s-twitter"></i></a></li>
                                <li><a href="#"><i class="icon-s-facebook"></i></a></li>
                                <li><a href="#"><i class="icon-s-dribbble"></i></a></li>
                            </ul>
                        </div>
                        <br />
                    </div>
                    <div class="span4">
                        <figure class="media-wrapper">
                            <img src="public/index/style/images/art/team3.jpg" alt="" />
                        </figure>
                        <div class="details">
                            <h4>Yilver Molina Hurtatiz<span>Participante GIECOM</span></h4>
                            <p>Estudiante Ingeniería de Sistemas e investigador en la Universidad de la Amazonia.</p>
                            <ul class="social">
                                <li><a href="#"><i class="icon-s-twitter"></i></a></li>
                                <li><a href="#"><i class="icon-s-facebook"></i></a></li>
                                <li><a href="#"><i class="icon-s-dribbble"></i></a></li>
                            </ul>
                        </div>
                        <br />
                    </div>
                    <div class="span4">
                        <figure class="media-wrapper">
                            <img src="public/index/style/images/art/team3.jpg" alt="" />
                        </figure>
                        <div class="details">
                            <h4>Julián Mora Ramos<span>Participante GIECOM</span></h4>
                            <p>Estudiante Ingeniería de Sistemas e investigador en la Universidad de la Amazonia.</p>
                            <ul class="social">
                                <li><a href="#"><i class="icon-s-twitter"></i></a></li>
                                <li><a href="#"><i class="icon-s-facebook"></i></a></li>
                                <li><a href="#"><i class="icon-s-dribbble"></i></a></li>
                            </ul>
                        </div>
                        <br />
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
                            <%--<div class="container inner" ng-init="getSemilleros()">

                                <div class="fix-portfolio">

                                    <ul class="items thumbs">

                                        <li class="item overlay thumb graphic text-center"><a href="#">
                                            <img src="public/images/fondo/giecom.png" alt="" />
                                            <div>
                                                <h5>GIECOM<span>Grupo de Investigación - Ingeniería de Sistemas</span></h5>
                                            </div>
                                        </a></li>

                                    </ul>
                                </div>
                            </div>--%>
                            <!-- /.post-list -->
                        </section>
                        <section class="span6 widget">
                            <h3 class="section-title widget-title">QUIENES SOMOS</h3>
                            <p>
                                <b>GIECOM</b> - Gestión del Conocimiento-Electrónica-Informática y Comunicaciones.
                            </p>
                            <div class="divide10"></div>
                            <i class="icon-location contact"></i>Universidad de la Amazonia, Sede Porvenir, Florencia Caquetá.
                            <br />
                            <i class="icon-phone contact"></i>+57 310 862 1408
                            <br />
                            <i class="icon-mail contact"></i><a href="first.last%40email.html">giecom@uniamazonia.edu.co</a>
                        </section>
                        <!-- /.widget -->
                    </div>
                    <!-- /.row -->

                    <hr />
                    <p class="pull-left">© 2016 Giecom. Todos los derechos reservados. <a target="_blank" href="http://udla.edu.co/">Universidad de la Amazonia</a>.</p>
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
