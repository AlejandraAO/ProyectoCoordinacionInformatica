﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogicaNegocios;
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmConsultarCurso : Form
    {
        #region Atributos
        menuPrincipal menu;
        SqlDataReader strCurso;
        clConexion conexion;
        clEntidadCurso pEntidadCurso;
        clCurso clCurso;
        ListViewItem lvItem;
        #endregion

        public frmConsultarCurso(menuPrincipal menu)
        {

            this.menu = menu;
            this.conexion =new clConexion();
            pEntidadCurso = new clEntidadCurso();
            clCurso = new clCurso();

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            menu.Show();
        }

        public void mConsultaGenetal()
        {
            int posicion = 0;
            strCurso = clCurso.mConsultaGeneral(conexion);

           
             lvItem = new ListViewItem();
            
            while (strCurso.Read())
            {

                
                if (mVerificarCursoEnLista(strCurso.GetString(1),"Sigla") == false)
                {
                     busquedaPorSigla(posicion);
                     posicion++;

                }
                else
                {
                    if (mVerificarCursoEnLista(strCurso.GetString(2), "Nombre") == false)
                    {
                        busquedaPorSigla(posicion);
                        posicion++;
                        
                    }
                    else
                    {
                        if (mVerificarCursoEnLista(strCurso.GetString(4), "Ciclo") == true)
                        {
                            mLimpiarLista();
                            busquedaPorSigla(posicion);
                            posicion++;

                        }
                    }
                }



            }//fin del read
        }

        public void busquedaPorSigla(int posicion)
        {
            //LLenar el data aquí
            int reglon = dgvDetalleCursos.Rows.Add();
            dgvDetalleCursos.Rows[reglon].Cells["Sigla"].Value = strCurso.GetString(1);

            //Comenté x el datagrid

           /** lvItem = lvDetalleCursos.Items.Add(strCurso.GetString(1));
            lvItem.SubItems.Add(strCurso.GetString(2));
            lvItem.SubItems.Add(strCurso.GetString(3));
            lvItem.SubItems.Add(strCurso.GetString(4));
            lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(5)));
            lvItem.SubItems.Add(strCurso.GetString(7));
            lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(8)));
            lvItem.SubItems.Add(strCurso.GetString(9));
            lvItem.SubItems.Add(strCurso.GetString(10));

            lvDetalleCursos.Items[posicion].UseItemStyleForSubItems = false;
            lvDetalleCursos.Items[posicion].SubItems[8].ForeColor = Color.Blue;
            lvDetalleCursos.Items[posicion].SubItems[8].Font = new Font(lvDetalleCursos.Font, FontStyle.Bold | FontStyle.Underline);**/
        }

      



        private void frmConsultarCurso_Load(object sender, EventArgs e)
        {            
            mConsultaGenetal();
        }

        public Boolean mVerificarCursoEnLista(string tipoConsulta, string tipo)
        {
            int posicion = 0;
            if (tipo == "Sigla")
            {
                posicion = 0;
            }
            else
            {
                if (tipo == "Nombre")
                {
                    posicion = 1;
                }
                else
                {
                    if (tipo == "Ciclo")
                    {
                        posicion = 3;
                    }

                }
            }
            //Comenté x el datagrid
            /*foreach (ListViewItem I in lvDetalleCursos.Items)
            {
                Console.WriteLine(sigla +"es igual a "+ I.SubItems[posicion].Text);         
                if(tipoConsulta == I.SubItems[0].Text|| tipoConsulta == I.SubItems[1].Text|| tipoConsulta == I.SubItems[3].Text)
                {
                    return true;
                }

            }*/
            return false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            mLimpiarLista();
            int posicion = 0;
                pEntidadCurso.mNombreCurso = txtDatoConsulta.Text.Trim();
                pEntidadCurso.mSiglaCurso = txtDatoConsulta.Text.Trim();
                pEntidadCurso.mCicloCurso = txtDatoConsulta.Text.Trim();
                strCurso = clCurso.mConsultaEspecifica(conexion, pEntidadCurso, cbConsultarPor.Text);
                if (strCurso.Read())
                {
                    if (mVerificarCursoEnLista(strCurso.GetString(1), cbConsultarPor.Text)==false)
                    {
                        ListViewItem lvItem = new ListViewItem();
                        strCurso = clCurso.mConsultaEspecifica(conexion, pEntidadCurso, cbConsultarPor.Text);
                        while (strCurso.Read())
                        {
                        //Comenté x el datagrid

                        /* lvItem = lvDetalleCursos.Items.Add(strCurso.GetString(1));
                         lvItem.SubItems.Add(strCurso.GetString(2));
                         lvItem.SubItems.Add(strCurso.GetString(3));
                         lvItem.SubItems.Add(strCurso.GetString(4));
                         lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(5)));
                         lvItem.SubItems.Add(strCurso.GetString(7));
                         lvItem.SubItems.Add(Convert.ToString(strCurso.GetInt32(8)));
                         lvItem.SubItems.Add(strCurso.GetString(9));
                         lvItem.SubItems.Add(strCurso.GetString(10));

                     lvDetalleCursos.Items[posicion].UseItemStyleForSubItems = false;
                     lvDetalleCursos.Items[posicion].SubItems[8].ForeColor = Color.Blue;
                     lvDetalleCursos.Items[posicion].SubItems[8].Font = new Font(lvDetalleCursos.Font, FontStyle.Bold | FontStyle.Underline);
                     posicion++;*/
                    }//fin del read
                }                
                 }                 
        }

        private void cbConsultarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDatoConsulta.Enabled = true;
            btnConsultar.Enabled = true;
        }

        public void mLimpiarLista()
        {
            //Comenté x el datagrid
            //lvDetalleCursos.Items.Clear();
        }

        private void txtDatoConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDatoConsulta.Text == "")
            {             
                mConsultaGenetal();
            }
        }

        private void lvDetalleCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* ListView.SelectedIndexCollection indexes = lvDetalleCursos.SelectedIndices;
            
            foreach (int index in indexes)
            {
                Console.WriteLine(
                    this.lvDetalleCursos.Items[index].SubItems[8].Text);
                
            }*/

        }
    }
}
