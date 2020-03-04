namespace CrudNutri {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.contenido = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnEstadisticas);
            this.panel1.Controls.Add(this.btnConsultas);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(30, 170);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(117, 34);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(30, 117);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(117, 34);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(30, 66);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(117, 34);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // contenido
            // 
            this.contenido.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contenido.Location = new System.Drawing.Point(201, 1);
            this.contenido.Name = "contenido";
            this.contenido.Size = new System.Drawing.Size(600, 450);
            this.contenido.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Nutri CRUD";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel contenido;
    }
}

