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
    public partial class VentanaNuevo : Form {

        private ConexionBd conexion;
        private Alumno alumno;

        public VentanaNuevo() {
            InitializeComponent();

            this.alumno = new Alumno();
            this.conexion = new ConexionBd();

            if (conexion.conectar()) {
                MessageBox.Show("Estas conectado");
            }
            else {
                MessageBox.Show("No estas conectado");
            }
        }

        private void crearAlumno() {
            alumno.setMatricula(Convert.ToInt32(txtMatricula.Text));
            alumno.setNombre(txtNombre.Text);
            alumno.setEdad(Convert.ToInt32(txtEdad.Text));
            if (rbHombre.Checked) alumno.setSexo('H');
            else if (rbMujer.Checked) alumno.setSexo('M');
            alumno.setPeso(Convert.ToSingle(txtPeso.Text));
            alumno.setAltura(Convert.ToSingle(txtAltura.Text));
            alumno.setActividadFisica(comboActividadFisica.Text);
            alumno.calcularImc();
            alumno.calcularCalorias();
            alumno.calcularEstatus();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            this.crearAlumno();
            MessageBox.Show(this.conexion.insertarAlumno(this.alumno));
        }
    }
}
