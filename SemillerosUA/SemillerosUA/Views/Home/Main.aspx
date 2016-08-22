<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/MasterPage.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="SemillerosUA.Views.Home.Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>Menú principal</title>
    <script language="javascript" type="text/javascript">
        function abrir() {
            $('#myModal').modal()
        }
        function welcome() {
            $('#welcome').modal()
        }
    </script>
    <style type="text/css">
        .PanelMenu {
            width: 80%;
            height: auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content">
        <br />
        <br />
        <%--<br /><br />--%>
        <center>
		<div class="PanelMenu">
          <div class="row">
			 
			  <div class="col-md-4">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/libros.jpg" alt="User profile picture">
                  <h4>Libros</h4>
                  <p class="text-muted text-center">Documentación de Programación</p>

                  <a href="#" onclick="abrir()" class="btn btn-default btn-block"><b>Ver enlaces</b></a>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/UDLA.gif" alt="User profile picture">
                  <h4>Universidad de la Amazonia</h4>
                  <p class="text-muted text-center">2016</p>

                  <a href="http://www.udla.edu.co/v10/" target="_blank" class="btn btn-default btn-block"><b>Ir al sitio</b></a>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/photo.jpg" alt="User profile picture">
                  <h4>RPC</h4>
                  <p class="text-muted text-center">Liga de Entrenamiento</p>

                  <a href="https://acm.javeriana.edu.co/maratones/" target="_blank" class="btn btn-default btn-block"><b>Ir al sitio</b></a>
                </div>
              </div>
            </div>
			  <div class="col-md-4">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/CCPL.jpg" alt="User profile picture">
                  <h4>CCPL	</h4>
                  <p class="text-muted text-center">Liga de Entrenamiento</p>

                  <a href="http://www.programmingleague.org/" target="_blank" class="btn btn-default btn-block"><b>Ir al sitio</b></a>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/UVA.png" alt="User profile picture">
                  <h3 class="profile-username text-center">UVA</h3>
                  <p class="text-muted text-center">Plataforma de Entrenamiento</p>

                  <a href="http://uva.onlinejudge.org/" target="_blank" class="btn btn-default btn-block"><b>Ir al sitio</b></a>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/codeforces.png" alt="User profile picture">
                  <h5 class="profile-username text-center">Code Forces</h5>
                  <p class="text-muted text-center">Plataforma de Entrenamiento</p>

                  <a href="http://codeforces.com/" target="_blank" class="btn btn-default btn-block"><b>Ir al sitio</b></a>
                </div>
              </div>
            </div>
			  </div>
			
			</div>
			</center>
        <div class="row">
            <div id="myModal" class="modal fade" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title"><b>Listado de enlaces</b></h4>
                        </div>
                        <div class="modal-body">
                            <center>
								<div class="row">
			  <div class="col-md-6">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/ACM.png" alt="User profile picture">
                  <h4>ACM-ICPC Bolivia</h4>

                  <a href="http://www.icpc-bolivia.edu.bo/libros.html" target="_blank" class="btn btn-default btn-block"><b>Ir al sitio</b></a>
                </div>
              </div>
            </div>
									<div class="col-md-6">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/PDF.jpg" alt="User profile picture">
                  <h4>Solucionario ACM-ICPC Bolivia</h4>

                  <a href="http://www.icpc-bolivia.edu.bo/books/libro-solucionario_acmicpc_bolivia_v1.pdf" target="_blank" class="btn btn-default btn-block"><b>Ir al sitio</b></a>
                </div>
              </div>
            </div>
									<div class="col-md-6">
              <div class="box box-primary">
                <div class="box-body box-profile">
                  <img class="profile-user-img img-responsive img-circle" src="../../public/images/fondo/PDF.jpg" alt="User profile picture">
                  <h4>Competitive Programming</h4>

                  <a href="http://www.comp.nus.edu.sg/~stevenha/myteaching/competitive_programming/cp1.pdf" target="_blank" class="btn btn-default btn-block"><b>Ir al sitio</b></a>
                </div>
              </div>
            </div>
									
									</div>
									</center>

                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-primary" data-dismiss="modal">Aceptar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
