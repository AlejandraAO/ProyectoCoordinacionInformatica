using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;


namespace AccesoDatos
{
    public class clConexion
    {
        //Area de la declaracion de todas las variables
        #region Atributos
        private string _codigo;
        private string _clave;
        private string _perfil;
        private string _baseDatos;
        private SqlDataAdapter adapter;
        private SqlConnection conexion; //Guardar la cadena de conexion del usuario con la BD
        private SqlCommand comando; //permite ejecutar los IMEC
        #endregion

        //Establecemos el metodo nicial
        #region Constructor

        public clConexion()
        {
            this._codigo = "123";
            this._clave = "123";
            this._perfil = "";
            this._baseDatos = "BDPortafolioUcr";
        }

        #endregion

        //Propiedade de lectura y escritura
        #region GetySet
        
        public string codigo
        {
            set { this._codigo = value; }
            get { return this._codigo; }
        }
        public string clave
        {
            set { this._clave = value; }
            get { return this._clave; }
        }
        public string perfil
        {
            set { this._perfil = value; }
            get { return this._perfil; }
        }
        public string baseDatos
        {
            set { this._baseDatos = value; }
            get { return this._baseDatos; }
        }

        #endregion

        //Metodo para la conexion con la base de datos
        #region Metodos

        //Este método permite descargar un archivo de la base de datos

        public void leer(clConexion cone, string ruta, string sentencia)
        {
            SqlCommand cmd;
            SqlDataAdapter dataAdapt;
            DataTable dtb;
            mConectar(cone);
            try
            {

                cmd = new SqlCommand(sentencia, conexion);//"select documento from tbDocumento where id='odt'", conexion);
                dataAdapt = new SqlDataAdapter(cmd);
                dtb = new DataTable();
                dataAdapt.Fill(dtb);
                DataRow f = dtb.Rows[0];
                byte[] bits = ((byte[])(f.ItemArray[0]));
                string sFile = ruta;//"F:/Documentos/archivo.odt";
                FileStream fs = new FileStream(sFile, FileMode.Create);

                //Y escribimos en disco el array de bytes que conforman el archivo
                fs.Write(bits, 0, Convert.ToInt32(bits.Length));
                fs.Close();
                System.Diagnostics.Process obj = new System.Diagnostics.Process();
                obj.StartInfo.FileName = sFile;
                obj.Start();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Este metodo permitira ejecutar los select
        public SqlDataReader mSeleccionar(string strSentencia, clConexion cone)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, this.conexion);
                    comando.CommandType = System.Data.CommandType.Text;
                    //el ExecuteReader ejecuta solo select
                    return comando.ExecuteReader();
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }// fin del metodo mSeleccionar

        //Este metodo permitira ejecutar los Insert, Update y Delete
        public Boolean mEjecutar(string strSentencia, clConexion cone)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, this.conexion);
                    comando.ExecuteNonQuery();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        //Este metodo nos permite abrir y conectarnos con la base de datos
        public Boolean mConectar(clConexion cone)
        {
            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = "user id='" + cone.codigo + "'; password='" + cone.clave + "'; Data Source='" + mNomServidor() + "'; Initial Catalog='" + cone.baseDatos+ "'";
                conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Este metodo obtiene el nombre de la maquina de windows
        public string mNomServidor()
        {
            return Dns.GetHostName();
        }

        public String getDatosConexion(clConexion conexionSQL)
        {
            return "user id='" + conexionSQL.codigo+ "'; password='" + conexionSQL.clave + "'; Data Source='" + mNomServidor() + "'; Initial Catalog='" + this.baseDatos + "'";
        }
        public SqlDataAdapter mAdaptar(string strSentencia, clConexion cone)
        {
            try
            {
                if (mConectar(cone))
                {
                    adapter = new SqlDataAdapter(strSentencia, conexion);
                    return adapter;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }// fin del metodo mSeleccionar
        #endregion
    }
}

