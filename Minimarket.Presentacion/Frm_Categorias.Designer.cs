namespace Minimarket.Presentacion
{
    partial class Frm_Categorias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbp_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Pricipal = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.tbp_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pricipal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbp_Principal
            // 
            this.tbp_Principal.Controls.Add(this.tabPage1);
            this.tbp_Principal.Controls.Add(this.tabPage2);
            this.tbp_Principal.Location = new System.Drawing.Point(0, 0);
            this.tbp_Principal.Name = "tbp_Principal";
            this.tbp_Principal.SelectedIndex = 0;
            this.tbp_Principal.Size = new System.Drawing.Size(728, 269);
            this.tbp_Principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_Pricipal);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Controls.Add(this.txt_Buscar);
            this.tabPage1.Controls.Add(this.lbl_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_Pricipal
            // 
            this.dgv_Pricipal.AllowUserToAddRows = false;
            this.dgv_Pricipal.AllowUserToDeleteRows = false;
            this.dgv_Pricipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pricipal.Location = new System.Drawing.Point(27, 55);
            this.dgv_Pricipal.Name = "dgv_Pricipal";
            this.dgv_Pricipal.ReadOnly = true;
            this.dgv_Pricipal.Size = new System.Drawing.Size(445, 136);
            this.dgv_Pricipal.TabIndex = 7;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(329, 27);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(70, 29);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(253, 20);
            this.txt_Buscar.TabIndex = 5;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(24, 32);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(43, 13);
            this.lbl_Buscar.TabIndex = 4;
            this.lbl_Buscar.Text = "Buscar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Guardar);
            this.tabPage2.Controls.Add(this.btn_Cancelar);
            this.tabPage2.Controls.Add(this.txt_Categoria);
            this.tabPage2.Controls.Add(this.lbl_Categoria);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(108, 55);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(231, 20);
            this.txt_Categoria.TabIndex = 1;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(47, 55);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(55, 13);
            this.lbl_Categoria.TabIndex = 0;
            this.lbl_Categoria.Text = "Categoria:";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(13, 293);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(78, 56);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(97, 293);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(78, 56);
            this.btn_Actualizar.TabIndex = 2;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(181, 293);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(78, 56);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Location = new System.Drawing.Point(265, 293);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(78, 56);
            this.btn_Reporte.TabIndex = 4;
            this.btn_Reporte.Text = "Reporte";
            this.btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(349, 293);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(78, 56);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(140, 94);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(221, 94);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Frm_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.tbp_Principal);
            this.Name = "Frm_Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Frm_Categorias_Load);
            this.tbp_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pricipal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbp_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dgv_Pricipal;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

