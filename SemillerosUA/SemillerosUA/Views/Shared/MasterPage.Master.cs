using SemillerosUA.Models.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SemillerosUA.Views.Shared
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        persona obj = new persona();
        permisos per = new permisos();
        usuario user = new usuario();
        public ArrayList NameP = new ArrayList();
        public ArrayList ImgP = new ArrayList();
        public ArrayList IdP = new ArrayList();
        public ArrayList NameS = new ArrayList();
        public ArrayList RutaS = new ArrayList();
        public ArrayList IdS = new ArrayList();
        subpermisos sub = new subpermisos();
        rol rol = new rol();
        int permiso = 0;
        string permisos = "";

        public void clearListP()
        {
            NameP.Clear();
            ImgP.Clear();
            IdP.Clear();
        }
        public void clearListS()
        {
            NameS.Clear();
            RutaS.Clear();
            IdS.Clear();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!IsPostBack)
            //    {
            //        this.clearListP();
            //        this.clearListS();

            //        user.user_idusuario = Convert.ToInt32(Request.Cookies["Cuenta"].Value);

            //        DataTable datos_cuenta = obj.consultarPersona(obj, user, 11);
            //        DataRow data = datos_cuenta.Rows[0];
            //        //rol.idRol = Convert.ToInt32(Request.Cookies["Rol"].Value);
            //        rol.rol_idrol = Convert.ToInt32(data["rol_idRol"].ToString());
            //        TUser.Text = data["Nombres"].ToString() + " " + data["Apellidos"].ToString();
            //        LRol.Text = data["rol_NombreRol"].ToString();

            //        NewEmail.Visible = rol.rol_idrol == 1 ? true : false;

            //        DataTable dt = per.ConsultarPermisos(rol), dt2;
            //        if (dt.Rows.Count > 0)
            //        {
            //            DataRow fila;
            //            for (int i = 0; i < dt.Rows.Count; i++)
            //            {
            //                fila = dt.Rows[i];
            //                NameP.Add(fila["prms_NombrePermiso"].ToString());
            //                IdP.Add(fila["prms_idPermiso"].ToString());
            //                ImgP.Add(fila["prms_Icono"].ToString());
            //                permiso = Convert.ToInt32(fila["prms_idPermiso"].ToString());
            //                rol.rol_idrol = Convert.ToInt32(Request.Cookies["Rol"].Value);
            //                per.prms_idpermiso = permiso;
            //                dt2 = sub.ConsultarSubpermisos(rol, per);
            //                //menuPrimary.Items.Add(P);
            //                if (dt2.Rows.Count > 0)
            //                {
            //                    DataRow fila2;

            //                    for (int j = 0; j < dt2.Rows.Count; j++)
            //                    {
            //                        fila2 = dt2.Rows[j];
            //                        permisos += fila2["spms_idSubpermiso"].ToString() + ",";
            //                        NameS.Add(fila2["spms_NombreSubpermiso"].ToString());
            //                        RutaS.Add(fila2["spms_URL"].ToString() + "?id=" + fila2["spms_idSubpermiso"].ToString());
            //                        IdS.Add(fila2["prms_FK_idPermiso"].ToString());
            //                        //menuPrimary.Items[i].ChildItems.Add(S);
            //                    }
            //                }
            //            }
            //        }

            //        if (rol.rol_idrol == 1)
            //        {
            //            this.ocultarMenu(true, false);
            //        }
            //        else
            //        {
            //            this.ocultarMenu(false, true);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
        }

        public void ocultarMenu(bool b1, bool b2)
        {
            MenuAdministrador.Visible = b1;
            //MenuEstudiante.Visible = b2;
        }

        protected void MostrarMensaje(string Mensaje, Page Pagina)
        {
            string scriptStr = "alert(\'" + Mensaje + "\');";
            ScriptManager.RegisterStartupScript(Pagina, Pagina.GetType(), "msgBox", scriptStr, true);
        }

        protected void MyMenu_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void MenuInformacion_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Salir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../../Forms/Home/Login.aspx");
        }
    }
}