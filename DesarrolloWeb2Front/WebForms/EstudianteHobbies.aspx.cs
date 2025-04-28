using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesarrolloWeb2Front.WebForms
{
    public partial class EstudianteHobbies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EstusianteHobbies.EstudianteHobbieWS estudianteHobbieWS = new EstusianteHobbies.EstudianteHobbieWS();
            var resultadoPorHobbie = estudianteHobbieWS.GetHobbiesByStudent(TextBox1.Text);

            TextBox2.Text = resultadoPorHobbie.Identificacion;
            TextBox3.Text = resultadoPorHobbie.Nombre;
            TextBox4.Text = resultadoPorHobbie.Apellido;
            TextBox5.Text = resultadoPorHobbie.Direccion;
            TextBox6.Text = resultadoPorHobbie.Telefono;
            GridView1.DataSource = resultadoPorHobbie.Hobbies;
            GridView1.DataBind();
        }
    }
}