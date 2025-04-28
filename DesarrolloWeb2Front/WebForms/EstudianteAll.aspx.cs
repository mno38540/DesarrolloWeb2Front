using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesarrolloWeb2Front.WebForms
{
    public partial class EstudianteAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EstusianteWS.EstudianteWS estudianteWS = new EstusianteWS.EstudianteWS();
            GridView1.DataSource = estudianteWS.GetAllStuden();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}