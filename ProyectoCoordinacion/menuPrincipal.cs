using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;
using LogicaNegocios;

namespace Vista
{
    public partial class menuPrincipal : Form
    {
        clConexion conexion;
        private frmAcceso ventanaAcceso;

        clProfesor logicaProfesores;
        clEspecialidadTituloProfesor logicaEspecialidad;

        frmTituloProfesor frmTitulosProfesor;
        frmConsultaProferores ventanaConsultaProfesores;
        frmEspecialidaProfesorTitulo especialidadTitulo;
        frmAdministracionProfesor frmMantenimineto;
        frmBusquedaProyectos frmBusquedaProyecto;
        frmBusquedaTelefonoCorreo frmBusquedaTelefonoCorreo;
        frmBusquedaGruposCursos frmBusquedaGruposCursos;
        frmConsultaProferores frmConsultaProfesors;

        frmEspecialidadProfesorExperiencia especialidadExperiencia;
        frmEspecialidaProfesorTitulo especialidadTitulos;

        frmObservacionesPeriodoLaboral observacionPeriodoLaboral;
        frmExperienciaAcademicaProfesor experienciaAcademicaProfesor;

        frmPuestoProfesor puestosProfesor;
        public menuPrincipal(frmAcceso ventanaAcceso)
        {
            InitializeComponent();
            this.ventanaAcceso = ventanaAcceso;

            conexion = new clConexion();
            this.logicaProfesores = new clProfesor();
            this.logicaEspecialidad = new clEspecialidadTituloProfesor();

            this.especialidadTitulos = new frmEspecialidaProfesorTitulo(conexion, logicaProfesores, logicaEspecialidad);
            this.frmTitulosProfesor = new frmTituloProfesor(conexion);
            this.ventanaConsultaProfesores = new frmConsultaProferores(conexion);
            this.frmMantenimineto = new frmAdministracionProfesor(frmTitulosProfesor, ventanaConsultaProfesores, especialidadTitulo, conexion, logicaProfesores, logicaEspecialidad);

            // this.especialidadTitulo = new frmEspecialidaProfesorTitulo(conexion, logicaProfesores, logicaEspecialidad);
            this.ventanaConsultaProfesores.ventanaProfesor(frmMantenimineto);
            this.frmBusquedaProyecto = new frmBusquedaProyectos(conexion);
            this.frmBusquedaTelefonoCorreo = new frmBusquedaTelefonoCorreo(conexion);
            this.frmBusquedaGruposCursos = new frmBusquedaGruposCursos();
            this.especialidadExperiencia = new frmEspecialidadProfesorExperiencia(conexion);
            this.observacionPeriodoLaboral = new frmObservacionesPeriodoLaboral(conexion);
            this.experienciaAcademicaProfesor = new frmExperienciaAcademicaProfesor(conexion);
            this.puestosProfesor = new frmPuestoProfesor(conexion);
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.SetVisibleCore(false);
            Application.Exit();
            //ventanaAcceso.limpiar();
            //ventanaAcceso.Show();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

       

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportesCursosLibres reporteCursosLibres = new frmReportesCursosLibres(this);
            reporteCursosLibres.Show();
        }

        private void gestiónDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectoSoftwareLibre ventanaSoftwareLibre = new frmProyectoSoftwareLibre(this);
            ventanaSoftwareLibre.Show();
        }

        private void gestiónDeMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionMiembros ventanaMiembros = new frmGestionMiembros();
            ventanaMiembros.Show();
        }

        private void gestiónCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos frmCurso = new frmCursos(this);
            this.Hide();            
            frmCurso.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCurso frmConsultarCurso = new frmConsultarCurso(this);
            this.Hide();
            frmConsultarCurso.Show();
        }

        private void miembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteMiembros frmConsultarCurso = new frmReporteMiembros(this);
            this.Hide();
            frmConsultarCurso.Show();
        }

        private void gestionCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionCursosLibres frmCursosLibres = new frmGestionCursosLibres(this);
            this.Hide();
            frmCursosLibres.Show();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProyectos frmRepoteProy = new frmReporteProyectos(this);
            this.Hide();
            frmRepoteProy.Show();

        }

        private void gestiónGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupoCurso grupoCurso = new frmGrupoCurso();
            grupoCurso.Show();
        }

        private void reporteProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProfesores reporteProfesores = new frmReporteProfesores();
            reporteProfesores.Show();
        }

        private void reporteLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteLaboratorios reporteLaboratorios = new frmReporteLaboratorios(this);
            reporteLaboratorios.Show();
        }

        private void gestiónDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionEstudiante gestionEstudiante = new frmGestionEstudiante(this);
            this.Hide();
            gestionEstudiante.Show();
        }

        private void mantenimientoProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMantenimineto.ShowDialog();
        }

        private void especialidadPorExperienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.especialidadExperiencia.ShowDialog();
        }

        private void especialidadPorTitulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.especialidadTitulos.ShowDialog();
        }

        private void experienciaAcadémicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.experienciaAcademicaProfesor.Show();
        }

        private void experienciaLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.puestosProfesor.Show();
        }

        private void titulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTitulosProfesor.ShowDialog();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ventanaConsultaProfesores.ShowDialog();
        }

        private void proyectosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.frmBusquedaProyecto.ShowDialog();
        }

        private void telefonosCorreosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmBusquedaTelefonoCorreo.ShowDialog();
        }

        private void gruposCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmBusquedaGruposCursos.ShowDialog();
        }

        private void observacionesPeriodoLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.observacionPeriodoLaboral.Show();
        }
    }
}
