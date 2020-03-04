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
    public partial class VentanaConsultas : Form {

        private ConsultaBd consulta = new ConsultaBd();

        public VentanaConsultas() {
            InitializeComponent();

            //Asignacion de la tabla al GridView
            dataGridAlumnos.DataSource = this.consulta.getDataTable();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            this.consulta.consultar(txtConsultar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            this.consulta.guardarCambios();
            MessageBox.Show("Sus cambios han sido guardados en la base de datos");
        }
    }
}
