using SemillerosUA.Models.BD;
using SemillerosUA.Models.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SemillerosUA.Views.Home
{
    public partial class Login : System.Web.UI.Page
    {
        public string id_semillero = "";
        persona individual = new persona();
        usuario user = new usuario();
        DataRow datos;

        Conexion con = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                id_semillero = Request.QueryString["id"].ToString();
                if (!IsPostBack)
                {
                    //FormsAuthentication.SignOut();
                    //FormsAuthentication.RedirectToLoginPage();
                    Session["Estado"] = "F";
                    Session.Clear();
                    Session.Abandon();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public Parametro[] getParemeters()
        {
            Parametro[] array = new Parametro[6];
            array[0] = new Parametro("CODIGO", "901");
            array[1] = new Parametro("NOMBRE", "YILVER");
            array[2] = new Parametro("APELLIDO", "MOLINA");
            array[3] = new Parametro("DIRECCION", "PABLO VI");
            array[4] = new Parametro("CORREO", "yi.molina@udla.edu.co");
            array[5] = new Parametro("FECHA_NAC", "28-10-1996");

            return array;
        }

        public Parametro[] getParemeters2()
        {
            Parametro[] array = new Parametro[5];
            array[0] = new Parametro("IDMATRICULA", "801");
            array[1] = new Parametro("PERIODO", "2012");
            array[2] = new Parametro("PROM_SEMESTRE", "4,6");
            array[3] = new Parametro("PROM_ACUMULADO", "4,6");
            array[4] = new Parametro("FK_CODIGOESTUDIANTE", "1");

            return array;
        }

        public void Ingresar()
        {

            Transaction[] lt = new Transaction[2];
            lt[0] = new Transaction("PR_INSERT_ESTUDIANTE", getParemeters());
            lt[1] = new Transaction("PR_INSERT_MATRICULA", getParemeters2());

            bool result = con.realizarTransaccion(lt);

            //bool state = Conn.realizarOperacion("PR_INSERT_ESTUDIANTE", list);
            //bool states = Conn.realizarOperacion("PR_INSERT_MATRICULA", getParemeters2());
            bool ingreso, estado;
            //try
            //{
            //    Security sec = new Security();
            //    Resultados.Visible = true;
            //    ingreso = Seguridad.ValidarIngreso(TUsuario.Text, T_Password.Text);
            //    if (ingreso)
            //    {

            //        user.user_nusuario = TUsuario.Text;
            //        user.user_contrasenia = sec.Encripta(T_Password.Text);
            //        estado = individual.validarUsuario(user);

            //        if (estado)
            //        {
            //            datos = this.consultarPersona(individual, user);
            //            string c = datos["user_contrasenia"].ToString();

            //            if (c.Equals(user.user_contrasenia))
            //            {
            //                var rol = new HttpCookie("Rol") { Value = datos["rol_FK_idRol"].ToString() };
            //                var usuario = new HttpCookie("NombreUsuario") { Value = datos["Nombres"].ToString() + " " + datos["Apellidos"].ToString() };
            //                var cuenta = new HttpCookie("Cuenta") { Value = datos["user_idUsuario"].ToString() };
            //                Response.Cookies.Add(rol);
            //                Response.Cookies.Add(usuario);
            //                Response.Cookies.Add(cuenta);

            //                Session["Estado"] = "T";
            //                Response.Redirect("Main.aspx");
            //            }
            //            else
            //            {
            //                Resultados.CssClass = "alert alert-danger";
            //                LResultado.Text = "Contraseña incorrecta";
            //                T_Password.Focus();
            //            }
            //        }
            //        else
            //        {
            //            Resultados.CssClass = "alert alert-danger";
            //            LResultado.Text = "Usuario no encontrado";
            //            TUsuario.Focus();
            //        }
            //    }
            //    else
            //    {
            //        Resultados.CssClass = "alert alert-danger";
            //        LResultado.Text = "Usuario o contraseña incorrectos";
            //        T_Password.Focus();
            //    }

            //}
            //catch (Exception e)
            //{
            //    //LResultado.Text = e.Message;
            //}
        }


        public DataRow consultarPersona(persona obj, usuario user)
        {
            //DataTable dt = obj.consultarPersona(obj, user, 2);
            //if (dt.Rows.Count > 0)
            //{
            //    return dt.Rows[0];
            //}
            //else
            //{
            //    return null;
            //}
            return null;
        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            this.Ingresar();
            //Conn c = new Conn();
            //c.connect();
        }
    }
}