using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesarrolloWeb2Front.WebForms
{
    public partial class HobbiesByCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HobbiesWS.HobbieWS hobbieWS = new HobbiesWS.HobbieWS();
            var resulHobbie = hobbieWS.HobbiesGetByIdl(TextBox1.Text);

            TextBox2.Text = resulHobbie.Codigo;
            TextBox3.Text = resulHobbie.Nombre;
            TextBox4.Text = resulHobbie.Descripcion;

        }
    }
}