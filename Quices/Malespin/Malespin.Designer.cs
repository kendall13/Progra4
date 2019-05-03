namespace Malespin
{
    partial class Malespin
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
            this.txtLista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.Descifrar = new System.Windows.Forms.Button();
            this.Cifrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLista
            // 
            this.txtLista.FormattingEnabled = true;
            this.txtLista.Location = new System.Drawing.Point(106, 220);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(156, 95);
            this.txtLista.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR DARLING", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 46);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR DARLING", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Malespin";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(91, 70);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(173, 52);
            this.txtCadena.TabIndex = 9;
            // 
            // Descifrar
            // 
            this.Descifrar.Location = new System.Drawing.Point(217, 140);
            this.Descifrar.Name = "Descifrar";
            this.Descifrar.Size = new System.Drawing.Size(75, 23);
            this.Descifrar.TabIndex = 8;
            this.Descifrar.Text = "Descifrar";
            this.Descifrar.UseVisualStyleBackColor = true;
            this.Descifrar.Click += new System.EventHandler(this.Descifrar_Click);
            // 
            // Cifrar
            // 
            this.Cifrar.Location = new System.Drawing.Point(66, 140);
            this.Cifrar.Name = "Cifrar";
            this.Cifrar.Size = new System.Drawing.Size(75, 23);
            this.Cifrar.TabIndex = 7;
            this.Cifrar.Text = "Cifrar";
            this.Cifrar.UseVisualStyleBackColor = true;
            this.Cifrar.Click += new System.EventHandler(this.Cifrar_Click);
            // 
            // Malespin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(180)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(359, 336);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.Descifrar);
            this.Controls.Add(this.Cifrar);
            this.Name = "Malespin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox txtLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button Descifrar;
        private System.Windows.Forms.Button Cifrar;
    }
}

