using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SemillerosUA
{
    public partial class Semilleros : System.Web.UI.Page
    {
        string id_semillero = "";
        semillero smlr = new semillero();
        public DataTable dt;
        public DataRow row;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                id_semillero = Request.QueryString["id"].ToString();
                this.cargar_Semillero(Convert.ToInt32(id_semillero));
            }
            catch (Exception ex)
            {

            }
        }

        public void cargar_Semillero(int id)
        {
            smlr.smlr_idsemillero = id;
            dt = null;

            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[0];
                NombreSemillero.Text = row["smlr_Nombre"].ToString();
                Descripcion.Text = row["smlr_Descripcion"].ToString();
            }
        }
    }
}