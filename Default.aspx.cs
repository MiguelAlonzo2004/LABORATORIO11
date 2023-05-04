using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LABORATORIO10
{
    public partial class _Default : Page
    {
        private void LeerU()
        {
           
        }
        private void Grabar(List<Universidad> universidades)
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archive = Server.MapPath("Datos.json");
        }

        private List<Universidad> Leer()
        {
            List<Universidad> lista = new List<Universidad>();
            string archivo = Server.MapPath("Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Universidad>> (json);

            return lista;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Universidad> universidades = new List<Universidad>();
            universidades = Leer();
            if (universidades == null)
            {
                universidades = new List<Universidad>();
            }
            Universidad universidadExiste = universidades.Find(u => u.Nombreuniversidad == DropDownList1.SelectedValue);
            if(universidadExiste == null)
            {
                Universidad universidadNueva = new Universidad();
                universidadNueva.Nombreuniversidad = DropDownList1.SelectedValue;
                Alumno alumnoNuevo = new Alumno();
                alumnoNuevo.Nombre = TextBox1.Text;
                Curso cursoNuevo = new Curso();
                cursoNuevo.Nombre = TextBox2.Text;
                cursoNuevo.Nota = Convert.ToInt16(TextBox3.Text);
                alumnoNuevo.Cursos.Add(cursoNuevo);
                universidadNueva.Alumnos.Add(alumnoNuevo);

            }
            Grabar(universidades);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}