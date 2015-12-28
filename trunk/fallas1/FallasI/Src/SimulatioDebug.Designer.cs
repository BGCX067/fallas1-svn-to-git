namespace FallasI
{
    partial class SimulationDebug
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.debugTxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // debugTxtBox
            // 
            this.debugTxtBox.Location = new System.Drawing.Point(5, 5);
            this.debugTxtBox.Name = "debugTxtBox";
            this.debugTxtBox.Size = new System.Drawing.Size(649, 417);
            this.debugTxtBox.TabIndex = 1;
            this.debugTxtBox.Text = "";
            // 
            // SimulationDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 434);
            this.Controls.Add(this.debugTxtBox);
            this.Name = "SimulationDebug";
            this.Text = "SimulatioDebug";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox debugTxtBox;

    }
}