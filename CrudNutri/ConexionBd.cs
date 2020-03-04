using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudNutri {

    public class ConexionBd {

        protected string cadena;
        protected SqlConnection con = new SqlConnection();

        public bool conectar() {
            this.cadena = "Data Source = LAPTOP-TGJ8N1S4; Initial Catalog = Nutri;" +
                          "Integrated Security = True";

            this.con.ConnectionString = this.cadena;
            try {
                this.con.Open();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

    }
}
