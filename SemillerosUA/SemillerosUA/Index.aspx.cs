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
    public partial class Index : System.Web.UI.Page
    {
        public DataTable semilleros = null;
        public DataRow row;
        semillero smlr = new semillero();

        protected void Page_Load(object sender, EventArgs e)
        {
            semilleros = smlr.get_semillero();
        }
    }
}