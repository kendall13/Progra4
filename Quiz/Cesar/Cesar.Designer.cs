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
            this.cifrar = new System.Windows.Forms.Button();
            this.Descifrar = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtListas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cifrar
            // 
            this.cifrar.Location = new System.Drawing.Point(57, 127);
            this.cifrar.Name = "cifrar";
            this.cifrar.Size = new System.Drawing.Size(75, 23);
            this.cifrar.TabIndex = 0;
            this.cifrar.Text = "Cifrar";
            this.cifrar.UseVisualStyleBackColor = true;
            this.cifrar.Click += new System.EventHandler(this.Cifrar_Click);
            // 
            // Descifrar
            // 
            this.Descifrar.Location = new System.Drawing.Point(222, 127);
            this.Descifrar.Name = "Descifrar";
            this.Descifrar.Size = new System.Drawing.Size(75, 23);
            this.Descifrar.TabIndex = 1;
            this.Descifrar.Text = "Descifrar";
            this.Descifrar.UseVisualStyleBackColor = true;
            this.Descifrar.Click += new System.EventHandler(this.Descifrar_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(89, 61);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(173, 52);
            this.txtCadena.TabIndex = 2;
            // 
            // txtListas
            // 
            this.txtListas.FormattingEnabled = true;
            this.txtListas.Location = new System.Drawing.Point(119, 220);
            this.txtListas.Name = "txtListas";
            this.txtListas.Size = new System.Drawing.Size(120, 95);
            this.txtListas.TabIndex = 3;
            this.txtListas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cesar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR BLANCA", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cesar
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
            this.Name = "Cesar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cifrar;
        private System.Windows.Forms.Button Descifrar;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.ListBox txtListas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

