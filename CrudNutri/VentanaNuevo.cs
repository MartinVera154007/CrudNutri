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

        private InsertBd insert;
        private Alumno alumno;

        public VentanaNuevo() {
            InitializeComponent();

            this.insert = new InsertBd();
            this.alumno = new Alumno();
        }

        private bool crearAlumno() {

            try {
                alumno.setMatricula(Convert.ToInt32(txtMatricula.Text));
                alumno.setNombre(txtNombre.Text);
                alumno.setEdad(Convert.ToInt32(txtEdad.Text));
                if (rbHombre.Checked)
                    alumno.setSexo('H');
                else if 
                    (rbMujer.Checked) alumno.setSexo('M');
                alumno.setPeso(Convert.ToSingle(txtPeso.Text));
                alumno.setAltura(Convert.ToSingle(txtAltura.Text));
                alumno.setActividadFisica(comboActividadFisica.Text);
                alumno.calcularImc();
                alumno.calcularCalorias();
                alumno.calcularEstatus();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private bool comprobarCampos() {
            if (String.IsNullOrEmpty(txtMatricula.Text)) {
                MessageBox.Show("Ingrese la matrícula.");
                return false;
            }
            if (String.IsNullOrEmpty(txtNombre.Text)) {
                MessageBox.Show("Ingrese el nombre.");
                return false;
            }
            if (String.IsNullOrEmpty(txtEdad.Text)) {
                MessageBox.Show("Ingrese la edad.");
                return false;
            }
            if (String.IsNullOrEmpty(txtPeso.Text)) {
                MessageBox.Show("Ingrese el peso.");
                return false;
            }
            if (String.IsNullOrEmpty(txtAltura.Text)) {
                MessageBox.Show("Ingrese la altura.");
                return false;
            }
            if (String.IsNullOrEmpty(comboActividadFisica.Text)) {
                MessageBox.Show("Seleccione un nivel de actividad fisica.");
                return false;
            }
            if (!rbHombre.Checked && !rbMujer.Checked) {
                MessageBox.Show("Seleccione el sexo");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if(this.comprobarCampos() && this.crearAlumno()) 
                MessageBox.Show(this.insert.insertarAlumno(this.alumno));
        }
    }
}
