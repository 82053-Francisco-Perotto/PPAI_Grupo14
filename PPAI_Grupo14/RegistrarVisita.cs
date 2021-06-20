using PPAI_Grupo14.Entidades;
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
    public partial class btn_confirmar_seleccion : Form
    {
        public btn_confirmar_seleccion()
        {
            InitializeComponent();
        }

        private void RegistrarVisita_Load(object sender, EventArgs e)
        {
            buscarEscuelas(escuelas);
            mostrarEscuelas(escuelas);
            buscarSedes(sedes);
            mostrarSedes(sedes);
            buscarTipoVisita(tipoVisita);
            mostrarTiposVisitas(tipoVisita);
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

        private void mostrarEscuelas(List<Escuela> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                grillaEscuelas.Rows.Add(lista[i].Nombre);
            }

        }

        private void grillaEscuelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEscuelaSeleccionada.Text = grillaEscuelas.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        //PASO 6 Y 7
        public List<Sede> sedes = new List<Sede>();
        private void buscarSedes(List<Sede> lista_sedes)
        {

            try
            {
                DataTable sede = AccesoADatos.ObtenerSedes();

                for (int i = 0; i < sede.Rows.Count; i++)
                {
                    Sede nuevaSede = new Sede();
                    nuevaSede.CantMaxVisitantes = int.Parse(sede.Rows[i]["cantMaximaVisitantes"].ToString());
                    nuevaSede.CantMaxPorGuia = int.Parse(sede.Rows[i]["cantMaxPorGuia"].ToString());
                    nuevaSede.Nombre = sede.Rows[i]["nombre"].ToString();


                    lista_sedes.Add(nuevaSede);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mostrarSedes(List<Sede> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                grillaSede.Rows.Add(lista[i].Nombre);
            }

        }

        private void grillaSede_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSedeSeleccionada.Text = grillaSede.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            
        }

        public List<TipoVisita> tipoVisita = new List<TipoVisita>();
        private void buscarTipoVisita(List<TipoVisita> lista_tipoVisita)
        {

            try
            {
                DataTable tipoVisita = AccesoADatos.ObtenerTiposVisitas();

                for (int i = 0; i < tipoVisita.Rows.Count; i++)
                {
                    TipoVisita nuevoTipoVisita = new TipoVisita();
                    nuevoTipoVisita.Nombre = tipoVisita.Rows[i]["descripcion"].ToString();
                    


                    lista_tipoVisita.Add(nuevoTipoVisita);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mostrarTiposVisitas(List<TipoVisita> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                grillaSede.Rows.Add(lista[i].Nombre);
            }

        }

        private void grillaTipoVisitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTipoVisitaSeleccionada.Text = grillaSede.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        //Paso 10

        public List<Exposicion> exposiciones = new List<Exposicion>();

        private void btn_get_expo_Click(object sender, EventArgs e)
        {
            Buscar_exposicion(exposiciones, txtTipoVisitaSeleccionada.Text);
            Mostrar_exposicion(exposiciones);
        }

        private void Buscar_exposicion(List<Exposicion> lista_expo, string tipo_visita)
        {
            try
            {
                DataTable exposicion = AccesoADatos.Obtener_exposiciones(tipo_visita);

                for (int i = 0; i < exposicion.Rows.Count; i++)
                {
                    Exposicion nuevaExpo = new Exposicion();
                    nuevaExpo.Nombre = exposicion.Rows[i]["nombre"].ToString();
                    // names.Split(',').ToList();
                    //nuevaExpo.PublicosDestino = exposicion.Rows[i]["descripcion"];
                    nuevaExpo.HoraApertura = DateTime.Parse(exposicion.Rows[i]["horaApertura"].ToString());
                    nuevaExpo.HoraCierre = DateTime.Parse(exposicion.Rows[i]["horaCierre"].ToString());
                    lista_expo.Add(nuevaExpo);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Mostrar_exposicion(List<Exposicion> lista_expo)
        {
            for (int i = 0; i < lista_expo.Count; i++)
            {
                grilla_expo.Rows.Add(lista_expo[i].Nombre);
                grilla_expo.Rows.Add(lista_expo[i].PublicosDestino);
                grilla_expo.Rows.Add(lista_expo[i].HoraApertura);
                grilla_expo.Rows.Add(lista_expo[i].HoraCierre);
            }
        }

        // PASO 11 FALTA HACER

        private void btn_confirmar_expos_Click(object sender, EventArgs e)
        {
            if (grilla_expo.SelectedRows.Count > 0)
            {
                List<Exposicion> lista_expo_seleccionadas = new List<Exposicion>();
                // grilla_expo.SelectedRow[NombreExposicion]

            }
            else
            {
                MessageBox.Show("Por favor seleccione uno o mas elementos");
            }
        }

        // PASO 14 



        // PASO 15
        private void btn_calcular_duracion_Click(object sender, EventArgs e)
        {
        }

        
    }
}
