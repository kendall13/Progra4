namespace WindowsFormsApp1
{
    partial class Murcielago
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
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cifrar = new System.Windows.Forms.Button();
            this.descifrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(89, 61);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(173, 52);
            this.txtCadena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Murciélago";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cifrar
            // 
            this.cifrar.ForeColor = System.Drawing.Color.Black;
            this.cifrar.Location = new System.Drawing.Point(64, 141);
            this.cifrar.Name = "cifrar";
            this.cifrar.Size = new System.Drawing.Size(75, 23);
            this.cifrar.TabIndex = 6;
            this.cifrar.Text = "Cifrar";
            this.cifrar.UseVisualStyleBackColor = true;
            this.cifrar.Click += new System.EventHandler(this.cifrar_Click);
            // 
            // descifrar
            // 
            this.descifrar.ForeColor = System.Drawing.Color.Black;
            this.descifrar.Location = new System.Drawing.Point(216, 141);
            this.descifrar.Name = "descifrar";
            this.descifrar.Size = new System.Drawing.Size(75, 23);
            this.descifrar.TabIndex = 7;
            this.descifrar.Text = "Descifrar";
            this.descifrar.UseVisualStyleBackColor = true;
            this.descifrar.Click += new System.EventHandler(this.descifrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR BLANCA", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(110, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado";
            // 
            // txtLista
            // 
            this.txtLista.FormattingEnabled = true;
            this.txtLista.Location = new System.Drawing.Point(116, 220);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(120, 95);
            this.txtLista.TabIndex = 9;
            // 
            // Murcielago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(214)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(359, 336);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descifrar);
            this.Controls.Add(this.cifrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadena);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Murcielago";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cifrar;
        private System.Windows.Forms.Button descifrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox txtLista;
    }
}

