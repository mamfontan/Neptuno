
namespace Neptuno.Views.controls
{
    partial class ucUser
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
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.Transparent;
            this.gbUser.Controls.Add(this.label1);
            this.gbUser.Location = new System.Drawing.Point(6, 1);
            this.gbUser.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.gbUser.Size = new System.Drawing.Size(250, 45);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "  User  ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name, Last name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbUser);
            this.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(261, 49);
            this.gbUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Label label1;
    }
}
