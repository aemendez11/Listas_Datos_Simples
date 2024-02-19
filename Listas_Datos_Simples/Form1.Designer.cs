
namespace Listas_Datos_Simples
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnumero = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonordenar = new System.Windows.Forms.Button();
            this.buttonDescendente = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero";
            // 
            // textBoxnumero
            // 
            this.textBoxnumero.Location = new System.Drawing.Point(199, 87);
            this.textBoxnumero.Name = "textBoxnumero";
            this.textBoxnumero.Size = new System.Drawing.Size(334, 22);
            this.textBoxnumero.TabIndex = 1;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(274, 125);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 33);
            this.buttonIngresar.TabIndex = 2;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(579, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 132);
            this.listBox1.TabIndex = 3;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(480, 196);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(117, 46);
            this.buttonMostrar.TabIndex = 4;
            this.buttonMostrar.Text = "Mostrar Datos ";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonordenar
            // 
            this.buttonordenar.Location = new System.Drawing.Point(603, 196);
            this.buttonordenar.Name = "buttonordenar";
            this.buttonordenar.Size = new System.Drawing.Size(117, 46);
            this.buttonordenar.TabIndex = 5;
            this.buttonordenar.Text = "Ordenar Ascedente";
            this.buttonordenar.UseVisualStyleBackColor = true;
            this.buttonordenar.Click += new System.EventHandler(this.buttonordenar_Click);
            // 
            // buttonDescendente
            // 
            this.buttonDescendente.Location = new System.Drawing.Point(726, 196);
            this.buttonDescendente.Name = "buttonDescendente";
            this.buttonDescendente.Size = new System.Drawing.Size(117, 46);
            this.buttonDescendente.TabIndex = 6;
            this.buttonDescendente.Text = "Ordenar descendente";
            this.buttonDescendente.UseVisualStyleBackColor = true;
            this.buttonDescendente.Click += new System.EventHandler(this.buttonDescendente_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(379, 125);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 33);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonDescendente);
            this.Controls.Add(this.buttonordenar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnumero;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonordenar;
        private System.Windows.Forms.Button buttonDescendente;
        private System.Windows.Forms.Button buttonEliminar;
    }
}

