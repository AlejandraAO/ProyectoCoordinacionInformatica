using AccesoDatos;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmBusquedaTelefonoCorreo : Form
    {
        private clConexion conexion;
        private clCorreo correos;
        private clTelefonos telefono;
        private clProfesor profesor;
        clProfesor logicaProfesor; 
        private SqlDataReader dtrProfesor;

        public frmBusquedaTelefonoCorreo(clConexion conexion)
        {
            this.conexion = conexion;
            correos = new clCorreo();
            telefono = new clTelefonos();
            profesor = new clProfesor();
            logicaProfesor = new clProfesor();
            
            InitializeComponent();
            
        }

        private void frmBuscarInformacion_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.cargarCombo();
        }

        private void btnBuscarPorIdentificacion_Click_1(object sender, EventArgs e)
        {
            this.dgListaInformacionProfesor.Rows.Clear();

            SqlDataReader consulta;
            if (this.rbtCorreos.Checked)
            {               
                consulta = correos.getCorreos(conexion, Convert.ToInt32(this.getCBXIdentificacion().ToString()));
                if (consulta.HasRows)//indica si el objeto tiene una o varias filas
                {
                    while (consulta.Read())
                    {
                        this.dgListaInformacionProfesor.Rows.Add(consulta.GetString(0));
                        Console.WriteLine(consulta.GetString(0));
                    }                    
                }

            }
            else if (this.rbtTelefonos.Checked)
            {
                consulta = telefono.getTelefonos(conexion, Convert.ToInt32(this.getCBXIdentificacion().ToString()));
                if (consulta.Read())
                {
                    this.dgListaInformacionProfesor.Rows.Add(consulta.GetString(0));
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione una opción", "Atencion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                
               
            }
        }

        private void btnSalirBuscarInformacion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //estemetodo devuelve el item seleccionado
        public Object getCBXIdentificacion()
        {
            Object SelectedItem = cbIdentificacion.SelectedItem;
            return SelectedItem;
        }
        //este metodo llena el combobox con las ids del profesor
        public void cargarCombo()
        {
            dtrProfesor = logicaProfesor.mLlenarCombo(this.conexion);
            if (dtrProfesor != null)
            {
                while (dtrProfesor.Read())
                {
                    String indentificacion = dtrProfesor.GetString(0).Trim();
                    cbIdentificacion.Items.Add(indentificacion);
                }
            }
        }

        
    }
}
