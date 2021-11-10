
namespace PokemonApi
{
    partial class PokemonVista
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagen = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(23, 22);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(224, 132);
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(99, 157);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(50, 20);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "label1";
            // 
            // PokemonVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.imagen);
            this.Name = "PokemonVista";
            this.Size = new System.Drawing.Size(264, 186);
            this.Load += new System.EventHandler(this.PokemonVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label nombre;
    }
}
