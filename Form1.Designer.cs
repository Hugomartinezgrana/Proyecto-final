namespace Projecto_Final
{
    partial class Form1
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
            this.btnordenadores = new System.Windows.Forms.Button();
            this.btnmoviles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnordenadores
            // 
            this.btnordenadores.Location = new System.Drawing.Point(40, 124);
            this.btnordenadores.Name = "btnordenadores";
            this.btnordenadores.Size = new System.Drawing.Size(130, 86);
            this.btnordenadores.TabIndex = 0;
            this.btnordenadores.Text = "Seccion ordenadores";
            this.btnordenadores.UseVisualStyleBackColor = true;
            this.btnordenadores.Click += new System.EventHandler(this.btnordenadores_Click);
            // 
            // btnmoviles
            // 
            this.btnmoviles.Location = new System.Drawing.Point(211, 124);
            this.btnmoviles.Name = "btnmoviles";
            this.btnmoviles.Size = new System.Drawing.Size(130, 86);
            this.btnmoviles.TabIndex = 1;
            this.btnmoviles.Text = "Seccion moviles";
            this.btnmoviles.UseVisualStyleBackColor = true;
            this.btnmoviles.Click += new System.EventHandler(this.btnmoviles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 241);
            this.Controls.Add(this.btnmoviles);
            this.Controls.Add(this.btnordenadores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnordenadores;
        private System.Windows.Forms.Button btnmoviles;
    }
}

