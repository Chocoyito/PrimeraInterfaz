namespace CapturarDatosNumericos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.marcaValor = new System.Windows.Forms.Label();
            this.listaNumeros = new System.Windows.Forms.NumericUpDown();
            this.grabarNumero = new System.Windows.Forms.Button();
            this.imprimirResultados = new System.Windows.Forms.Label();
            this.limpiarNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            //  marcaValor
            //
            this.marcaValor.AutoSize = true;
            this.marcaValor.Location = new System.Drawing.Point(30, 40);
            this.marcaValor.Name = "marcaValor";
            this.marcaValor.Size = new System.Drawing.Size(33, 15);
            this.marcaValor.Text = "Valor";
            this.marcaValor.TabIndex = 0;
            //
            //  listaNumeros 
            //                                                     x   y
            this.listaNumeros.AutoSize = true;
            this.listaNumeros.Location = new System.Drawing.Point(80, 35);
            this.listaNumeros.Name = "listaNumeros";
            this.listaNumeros.Maximum = 1000000;
            this.listaNumeros.Minimum = -1000000;
            this.listaNumeros.Size = new System.Drawing.Size(100, 1);   // El segundo valor es intercambeable y es 25.
            this.listaNumeros.TabIndex = 1;
            //
            //  grabarNumero
            //
            this.grabarNumero.AutoSize = true;
            this.grabarNumero.Location = new System.Drawing.Point(250, 35);
            this.grabarNumero.Name = "grabarNumeros";
            this.grabarNumero.Size = new System.Drawing.Size(100, 25);
            this.grabarNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grabarNumero.Text = "Obtener número";
            this.grabarNumero.TabIndex = 2;
            this.grabarNumero.Click += new System.EventHandler(this.grabarNumero_Click);
            //
            //  imprimirResultados
            //
            this.imprimirResultados.AutoSize = true;
            this.imprimirResultados.Location = new System.Drawing.Point(30, 80);
            this.imprimirResultados.Name = "imprimirResultados";
            this.imprimirResultados.Size = new System.Drawing.Size(33, 15);
            //this.imprimirResultados.Text = "Resultado";
            this.imprimirResultados.TabIndex = 3;
            //
            //  limpiarNumeros
            //
            this.limpiarNumeros.AutoSize = true;
            this.limpiarNumeros.Location = new System.Drawing.Point(250, 75);
            this.limpiarNumeros.Name = "limpiarNumeros";
            this.limpiarNumeros.Size = new System.Drawing.Size(100, 25);
            this.limpiarNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.limpiarNumeros.Text = "Limpiar";
            this.limpiarNumeros.TabIndex = 4;
            this.limpiarNumeros.Click += new System.EventHandler(this.limpiarNumeros_Click);
            //
            //  Formas
            //
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MaximizeBox = false;
            this.Controls.Add(this.marcaValor);
            this.Controls.Add(this.listaNumeros);
            this.Controls.Add(this.grabarNumero);
            this.Controls.Add(this.imprimirResultados);
            this.Controls.Add(this.limpiarNumeros);
            this.Text = "Ruedita de números";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label marcaValor;
        private System.Windows.Forms.NumericUpDown listaNumeros;
        private System.Windows.Forms.Button grabarNumero;
        private System.Windows.Forms.Label imprimirResultados;
        private System.Windows.Forms.Button limpiarNumeros;
    }
}

