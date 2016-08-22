using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SemillerosUA.Views.Documentos
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cargar_Click(object sender, EventArgs e)
        {

        }
        public string DataTableToJsonWithJsonNet(DataTable table)
        {
            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(table);
            return jsonString;
        }
    }
}