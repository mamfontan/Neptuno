
namespace Neptuno.Views.controls
{
    partial class ucUnit
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
            this.gbUnit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUnit
            // 
            this.gbUnit.BackColor = System.Drawing.Color.Transparent;
            this.gbUnit.Controls.Add(this.label1);
            this.gbUnit.Location = new System.Drawing.Point(6, 1);
            this.gbUnit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbUnit.Name = "gbUnit";
            this.gbUnit.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbUnit.Size = new System.Drawing.Size(250, 45);
            this.gbUnit.TabIndex = 0;
            this.gbUnit.TabStop = false;
            this.gbUnit.Text = " Unit  ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbUnit);
            this.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ucUnit";
            this.Size = new System.Drawing.Size(261, 49);
            this.gbUnit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUnit;
        private System.Windows.Forms.Label label1;
    }
}
