using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudNutri {

    class EstadisticaBd : ConexionBd {

        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader;
        private ArrayList listaCategoria = new ArrayList();
        private ArrayList listaCantidad = new ArrayList();

        public EstadisticaBd(string procedimiento) {
            this.conectar();

            this.command.Connection = this.con;
            this.command.CommandText = procedimiento;
            this.command.CommandType = CommandType.StoredProcedure;
        }

        public void getDatos() {
            this.reader = command.ExecuteReader();
            this.listaCategoria.Clear();
            this.listaCantidad.Clear();

            while(this.reader.Read()) {
                listaCategoria.Add(this.reader.GetString(0));
                listaCantidad.Add(this.reader.GetInt32(1));
            }
            this.reader.Close();
        }

        public ArrayList getListaCategorias() {
            return this.listaCategoria;
        }

        public ArrayList getListaCantidad() {
            return this.listaCantidad;
        }

    }
}
