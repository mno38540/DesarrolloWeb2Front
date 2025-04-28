using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesarrolloWeb2Front.WebForms
{
    public partial class HobbiesFront : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HobbiesWS.HobbieWS hobbieWS = new HobbiesWS.HobbieWS();
            GridView1.DataSource = hobbieWS.HobbiesGetAll();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}