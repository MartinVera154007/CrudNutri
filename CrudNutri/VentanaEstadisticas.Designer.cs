namespace CrudNutri {
    partial class VentanaEstadisticas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartSexo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizarGrafico = new System.Windows.Forms.Button();
            this.chartEdad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizarGrafico1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadísticas";
            // 
            // chartSexo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSexo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSexo.Legends.Add(legend1);
            this.chartSexo.Location = new System.Drawing.Point(21, 34);
            this.chartSexo.Name = "chartSexo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Mujeres";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Hombres";
            this.chartSexo.Series.Add(series1);
            this.chartSexo.Series.Add(series2);
            this.chartSexo.Size = new System.Drawing.Size(342, 257);
            this.chartSexo.TabIndex = 1;
            this.chartSexo.Text = "chart1";
            // 
            // btnActualizarGrafico
            // 
            this.btnActualizarGrafico.Location = new System.Drawing.Point(262, 87);
            this.btnActualizarGrafico.Name = "btnActualizarGrafico";
            this.btnActualizarGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarGrafico.TabIndex = 2;
            this.btnActualizarGrafico.Text = "Actualizar";
            this.btnActualizarGrafico.UseVisualStyleBackColor = true;
            this.btnActualizarGrafico.Click += new System.EventHandler(this.btnActualizarGrafico_Click);
            // 
            // chartEdad
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEdad.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEdad.Legends.Add(legend2);
            this.chartEdad.Location = new System.Drawing.Point(246, 181);
            this.chartEdad.Name = "chartEdad";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Menores de 18";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Entre 18 y 29";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Mayores de 30";
            this.chartEdad.Series.Add(series3);
            this.chartEdad.Series.Add(series4);
            this.chartEdad.Series.Add(series5);
            this.chartEdad.Size = new System.Drawing.Size(342, 257);
            this.chartEdad.TabIndex = 3;
            this.chartEdad.Text = "chart1";
            // 
            // btnActualizarGrafico1
            // 
            this.btnActualizarGrafico1.Location = new System.Drawing.Point(479, 252);
            this.btnActualizarGrafico1.Name = "btnActualizarGrafico1";
            this.btnActualizarGrafico1.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarGrafico1.TabIndex = 4;
            this.btnActualizarGrafico1.Text = "Actualizar";
            this.btnActualizarGrafico1.UseVisualStyleBackColor = true;
            this.btnActualizarGrafico1.Click += new System.EventHandler(this.btnActualizarGrafico1_Click);
            // 
            // VentanaEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnActualizarGrafico1);
            this.Controls.Add(this.chartEdad);
            this.Controls.Add(this.btnActualizarGrafico);
            this.Controls.Add(this.chartSexo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaEstadisticas";
            this.Text = "VentanaEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.chartSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSexo;
        private System.Windows.Forms.Button btnActualizarGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEdad;
        private System.Windows.Forms.Button btnActualizarGrafico1;
    }
}