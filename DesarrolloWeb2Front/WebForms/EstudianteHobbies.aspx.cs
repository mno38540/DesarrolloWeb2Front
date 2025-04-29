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
        protected void Button1_Click(object sender, EventArgs e)
        {
            EstudianteHo.EstudianteHobbieWS estudianteHobbieWS = new EstudianteHo.EstudianteHobbieWS();
            var resultadoPorHobbie = estudianteHobbieWS.GetHobbiesByStudent(TextBox1.Text);

            TextBox2.Text = resultadoPorHobbie.Identificacion;
            TextBox3.Text = resultadoPorHobbie.Nombre;
            TextBox4.Text = resultadoPorHobbie.Apellido;
            TextBox5.Text = resultadoPorHobbie.Direccion;
            TextBox6.Text = resultadoPorHobbie.Telefono;
            GridView1.DataSource = resultadoPorHobbie.Hobbies;
            GridView1.DataBind();
            

            /*EstudianteHo.EstudianteHobbieWS estudianteHobbie = new EstudianteHo.EstudianteHobbieWS();
            var resul = estudianteHobbie.GetHobbiesByStudent(TextBox1.Text);
            TextBox2.Text = resul.Identificacion;
            TextBox3.Text = resul.Nombre;
            TextBox4.Text = resul.Apellido;
            TextBox5.Text= resul.Direccion;
            TextBox6.Text = resul.Telefono;
            GridView1.DataSource= resul.Hobbies;
            GridView1.DataBind(); */
        }
    }
}