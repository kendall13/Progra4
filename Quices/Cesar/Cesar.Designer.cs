namespace Cesar
{
    partial class Cesar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListas = new System.Windows.Forms.ListBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.Descifrar = new System.Windows.Forms.Button();
            this.cifrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR BLANCA", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 58);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cesar";
            // 
            // txtListas
            // 
            this.txtListas.FormattingEnabled = true;
            this.txtListas.Location = new System.Drawing.Point(121, 231);
            this.txtListas.Name = "txtListas";
            this.txtListas.Size = new System.Drawing.Size(120, 95);
            this.txtListas.TabIndex = 9;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(91, 72);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(173, 52);
            this.txtCadena.TabIndex = 8;
            // 
            // Descifrar
            // 
            this.Descifrar.Location = new System.Drawing.Point(224, 138);
            this.Descifrar.Name = "Descifrar";
            this.Descifrar.Size = new System.Drawing.Size(75, 23);
            this.Descifrar.TabIndex = 7;
            this.Descifrar.Text = "Descifrar";
            this.Descifrar.UseVisualStyleBackColor = true;
            this.Descifrar.Click += new System.EventHandler(this.Descifrar_Click);
            // 
            // cifrar
            // 
            this.cifrar.Location = new System.Drawing.Point(59, 138);
            this.cifrar.Name = "cifrar";
            this.cifrar.Size = new System.Drawing.Size(75, 23);
            this.cifrar.TabIndex = 6;
            this.cifrar.Text = "Cifrar";
            this.cifrar.UseVisualStyleBackColor = true;
            this.cifrar.Click += new System.EventHandler(this.cifrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(359, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListas);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.Descifrar);
            this.Controls.Add(this.cifrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox txtListas;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button Descifrar;
        private System.Windows.Forms.Button cifrar;
    }
}

