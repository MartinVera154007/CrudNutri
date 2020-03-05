using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudNutri {

    class ConsultaBd : ConexionBd {

        private string consultaSelect = "Select TOP 5 * from Alumnos";
        private SqlDataAdapter adapterAlumnos = new SqlDataAdapter();
        private SqlCommandBuilder builderAlumnos = new SqlCommandBuilder();
        private DataTable tablaAlumnos = new DataTable();
        private SqlCommand commandAlumnos = new SqlCommand();

        public ConsultaBd() {
            this.conectar();

            //Configuracion del command
            this.commandAlumnos.Connection = this.con;
            this.commandAlumnos.CommandType = CommandType.Text;
            this.commandAlumnos.CommandText = this.consultaSelect;

            //Configuracion del adapter            
            this.adapterAlumnos.SelectCommand = commandAlumnos;
            this.builderAlumnos.DataAdapter = this.adapterAlumnos;
            tablaAlumnos.Clear();
            adapterAlumnos.Fill(tablaAlumnos);
        }

        public void consultar(string busqueda) {
            tablaAlumnos.Clear();

            this.consultaSelect = "SELECT * FROM Alumnos WHERE nombre = '{0}'";
            this.consultaSelect = String.Format(this.consultaSelect, busqueda);
            this.commandAlumnos.CommandText = this.consultaSelect;
            
            adapterAlumnos.Fill(tablaAlumnos);

            try {
                Convert.ToInt32(busqueda);
                this.consultaSelect = "SELECT * FROM Alumnos WHERE matricula = {0}";
                this.consultaSelect = String.Format(this.consultaSelect, busqueda);
                this.commandAlumnos.CommandText = this.consultaSelect;
                adapterAlumnos.Fill(tablaAlumnos);

            }
            catch (Exception) { }
        }

        public void guardarCambios() {
            this.adapterAlumnos.Update(this.tablaAlumnos);
        }
        
        public DataTable getDataTable() {
            return this.tablaAlumnos;
        }
    }
}
