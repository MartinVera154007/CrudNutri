using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudNutri {
    public class InsertBd : ConexionBd {

        private SqlCommand command = new SqlCommand();

        public InsertBd() {
            this.conectar();
            this.command.Connection = this.con;
            this.command.CommandType = CommandType.Text;
        }

        //Ejecutar el insert en SQL
        private string ejecConsultaNonQuery(string consulta) {
            this.command.CommandText = consulta;
            try {
                this.command.ExecuteNonQuery();
                return "Registro insertado con éxito";
            }
            catch (Exception ex) {
                return ex.Message;
            }
        }

        //Insertar nuevo alumno
        public string insertarAlumno(Alumno alumno) {

            string consulta = "INSERT INTO Alumnos values ( {0} , '{1}' , {2} , '{3}' , {4} , {5} , {6} , '{7}' , '{8}' , {9} )";
            consulta = String.Format(consulta, alumno.getMatricula().ToString(), alumno.getNombre(), alumno.getEdad().ToString(),
                                    alumno.getSexo(), alumno.getPeso().ToString(), alumno.getAltura().ToString(), 
                                    alumno.getImc().ToString(), alumno.getActividadFisica(), alumno.getEstatus(), 
                                    alumno.getCalorias().ToString());

            return this.ejecConsultaNonQuery(consulta);
        }
    }
}
