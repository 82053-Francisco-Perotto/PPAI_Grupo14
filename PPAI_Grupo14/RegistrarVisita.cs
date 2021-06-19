using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_Grupo14
{
    public partial class RegistrarReservaVisitasGuiadas : Form
    {
        public RegistrarReservaVisitasGuiadas()
        {
            InitializeComponent();
        }

        private void RegistrarVisita_Load(object sender, EventArgs e)
        {
            buscarEscuelas(escuelas);
            MostrarEscuelas(escuelas);
        }

        public List<Escuela> escuelas = new List<Escuela>();
        private void buscarEscuelas(List<Escuela> lista_escuelas)
        {

            try
            {
                DataTable escuela = AccesoADatos.ObtenerEscuelas();

                for (int i = 0; i < escuela.Rows.Count; i++)
                {
                    Escuela nuevaEscuela = new Escuela();
                    nuevaEscuela.Mail = escuela.Rows[i]["mail"].ToString();
                    nuevaEscuela.Nombre = escuela.Rows[i]["nombre"].ToString();
                    nuevaEscuela.TelefFijo = escuela.Rows[i]["telefFijo"].ToString();
                    nuevaEscuela.TelefCelular = escuela.Rows[i]["telefCelular"].ToString();
                    nuevaEscuela.Calle = escuela.Rows[i]["calle"].ToString();
                    nuevaEscuela.NroCalle = int.Parse(escuela.Rows[i]["nroCalle"].ToString());
                    lista_escuelas.Add(nuevaEscuela);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarEscuelas(List<Escuela> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                grillaEscuelas.Rows.Add(lista[i].Nombre);
            }

        }
    }
}
