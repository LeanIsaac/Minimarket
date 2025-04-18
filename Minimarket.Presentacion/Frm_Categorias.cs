using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Minimarket.Presentacion
{
    public partial class Frm_Categorias : Form
    {
        public Frm_Categorias()
        {
            InitializeComponent();
        }
        #region Mis Variables
        int estadoGuarda = 0; //sin ninguna accion;
        int codigo_ca = 0; //guarde la info del codigo del registro seleccionado
        #endregion

        #region Mis Métodos

        public void Formato_ca()
        {
            dgv_Pricipal.Columns[0].Width = 100;
            dgv_Pricipal.Columns[0].HeaderText = "CÓDIGO_CA";
            dgv_Pricipal.Columns[1].Width = 300;
            dgv_Pricipal.Columns[1].HeaderText = "CATEGORIA";
        }

        private void Listado_ca(string cTexto)
        {
            try
            {
                dgv_Pricipal.DataSource = Negocio.Categorias.Listado_ca(cTexto);
                this.Formato_ca();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            this.btn_Nuevo.Enabled = lEstado;
            this.btn_Actualizar.Enabled = lEstado;
            this.btn_Eliminar.Enabled = lEstado;
            this.btn_Reporte.Enabled = lEstado;
            this.btn_Salir.Enabled = lEstado;
        }

        private void Estado_BotonesProceso(bool lEstado)
        {
            this.btn_Cancelar.Visible = lEstado;
            this.btn_Guardar.Visible = lEstado;
            this.btn_Retornar.Visible = !lEstado;
        }

        private void Selecciona_Item()
        {
            //selecciona el contenido que tenga la columna codigo_ca
            if(string.IsNullOrEmpty(Convert.ToString(dgv_Pricipal.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No se tiene informacion para Visualizar","Aviso del Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_ca = Convert.ToInt32(dgv_Pricipal.CurrentRow.Cells["codigo_ca"].Value);
                txt_descripcion_ca.Text = Convert.ToString( dgv_Pricipal.CurrentRow.Cells["descripcion_ca"].Value);
            }
        }

        #endregion

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(txt_descripcion_ca.Text == String.Empty)
            {
                MessageBox.Show("Ingrese datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // se registra la informacion
            {
                Entidades.Categorias oCa = new Entidades.Categorias();
                string rto = "";
                oCa.Codigo_ca = this.codigo_ca;
                oCa.Descripcion_ca = txt_descripcion_ca.Text.Trim();
                rto = Negocio.Categorias.Guardar_ca(estadoGuarda, oCa);

                if(rto == "OK")
                {
                    this.Listado_ca("%");//Actualiza la lista
                    MessageBox.Show("Los datos has sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    estadoGuarda = 0; //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesProceso(false);
                    txt_descripcion_ca.Text = "";
                    txt_descripcion_ca.ReadOnly = true;
                    tbp_Principal.SelectedIndex = 0;
                    this.codigo_ca = 0;
                    
                }
                else
                {
                    MessageBox.Show(rto, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            estadoGuarda = 1; //Nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            txt_descripcion_ca.Text = "";
            txt_descripcion_ca.ReadOnly = false;
            tbp_Principal.SelectedIndex = 1;
            txt_descripcion_ca.Focus();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 2; //Actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProceso(true);
            this.Selecciona_Item();
            tbp_Principal.SelectedIndex = 1;
            txt_descripcion_ca.ReadOnly = false;
            txt_descripcion_ca.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            estadoGuarda = 0; //sin ninguna accion
            txt_descripcion_ca.Text = "";
            txt_descripcion_ca.ReadOnly = true;
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProceso(false);
            tbp_Principal.SelectedIndex = 0;
        }

        private void dgv_Pricipal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_Item();
            this.Estado_BotonesProceso(false);
            tbp_Principal.SelectedIndex = 1; //se activa la pestaña del marco d pagina en mantenimiento
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesProceso(false);
            tbp_Principal.SelectedIndex = 0;
        }
    }
}
