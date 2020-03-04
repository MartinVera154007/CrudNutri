using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudNutri {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            AbrirFormulario<VentanaNuevo>();
        }

        // Abre un formulario del tipo dado
        private void AbrirFormulario<T>() where T : Form, new() {
            Form formulario = contenido.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null) {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized) {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            contenido.Controls.Add(formulario);
            contenido.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            AbrirFormulario<VentanaNuevo>();
        }

        private void btnConsultas_Click(object sender, EventArgs e) {
            AbrirFormulario<VentanaConsultas>();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e) {
            AbrirFormulario<VentanaEstadisticas>();
        }
    }
}
