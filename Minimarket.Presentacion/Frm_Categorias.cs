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

        #endregion

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }
    }
}
