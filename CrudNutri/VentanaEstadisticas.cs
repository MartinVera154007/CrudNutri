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
    public partial class VentanaEstadisticas : Form {

        private EstadisticaBd estadisticaHombres = new EstadisticaBd("estadisticaHombres");
        private EstadisticaBd estadisticaMujeres = new EstadisticaBd("estadisticaMujeres");
        private EstadisticaBd estadisticaNinos = new EstadisticaBd("estadisticaNinos");
        private EstadisticaBd estadisticaJovenes = new EstadisticaBd("estadisticaJovenes");
        private EstadisticaBd estadisticaAdultos = new EstadisticaBd("estadisticaAdultos");

        public VentanaEstadisticas() {
            InitializeComponent();
        }

        private void btnActualizarGrafico_Click(object sender, EventArgs e) {
            this.estadisticaMujeres.getDatos();
            this.estadisticaHombres.getDatos();

            chartSexo.Series[0].Points.DataBindXY(this.estadisticaMujeres.getListaCategorias(), this.estadisticaMujeres.getListaCantidad());
            chartSexo.Series[1].Points.DataBindXY(this.estadisticaHombres.getListaCategorias(), this.estadisticaHombres.getListaCantidad());

        }

        private void btnActualizarGrafico1_Click(object sender, EventArgs e) {
            this.estadisticaNinos.getDatos();
            this.estadisticaJovenes.getDatos();
            this.estadisticaAdultos.getDatos();

            chartEdad.Series[0].Points.DataBindXY(this.estadisticaNinos.getListaCategorias(), this.estadisticaNinos.getListaCantidad());
            chartEdad.Series[1].Points.DataBindXY(this.estadisticaJovenes.getListaCategorias(), this.estadisticaJovenes.getListaCantidad());
            chartEdad.Series[2].Points.DataBindXY(this.estadisticaAdultos.getListaCategorias(), this.estadisticaAdultos.getListaCantidad());

        }
    }
}
