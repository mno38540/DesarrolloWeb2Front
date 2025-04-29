using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesarrolloWeb2Front.WebForms
{
    public partial class EstusiantesById : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EstusianteWS.EstudianteWS estudianteWS = new EstusianteWS.EstudianteWS();
            var resulEstudiante = estudianteWS.StudentById(TextBox6.Text);

            TextBox1.Text = resulEstudiante.Identificacion;
            TextBox2.Text = resulEstudiante.Nombre;
            TextBox3.Text = resulEstudiante.Apellido;
            TextBox4.Text = resulEstudiante.Direccion;
            TextBox5.Text = resulEstudiante.Telefono;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EstusianteWS.EstudianteWS estudianteWS = new EstusianteWS.EstudianteWS();
            var actualizacion = estudianteWS.StudentUpdate(TextBox6.Text, TextBox2.Text, TextBox3.Text,TextBox4.Text,TextBox5.Text);
        }
    }
}