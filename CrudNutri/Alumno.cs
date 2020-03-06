using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudNutri {
    public class Alumno {

        private int matricula;
        private string nombre;
        private int edad;
        private char sexo;
        private float peso;
        private float altura;
        private float imc;
        private string actividadFisica;
        private string estatus;
        private float calorias;

        public void setMatricula(int matricula) {
            this.matricula = matricula;
        }
        public int getMatricula() {
            return this.matricula;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }
        public string getNombre() {
            return this.nombre;
        }

        public void setEdad(int edad) {
            this.edad = edad;
        }
        public int getEdad() {
            return this.edad;
        }

        public void setSexo(char sexo) {
            this.sexo = sexo;
        }
        public char getSexo() {
            return this.sexo;
        }

        public void setPeso(float peso) {
            this.peso = peso;
        }
        public float getPeso() {
            return this.peso;
        }

        public void setAltura(float altura) {
            this.altura = altura;
        }
        public float getAltura() {
            return this.altura;
        }

        public void setImc(float imc) {
            this.imc = imc;
        }
        public float getImc() {
            return this.imc;
        }

        public void setActividadFisica(string actividadFisica) {
            this.actividadFisica = actividadFisica;
        }
        public string getActividadFisica() {
            return this.actividadFisica;
        }

        public void setEstatus(string estatus) {
            this.estatus = estatus;
        }
        public string getEstatus() {
            return this.estatus;
        }

        public void setCalorias(float calorias) {
            this.calorias = calorias;
        }
        public float getCalorias() {
            return this.calorias;
        }

        public void calcularImc() {
            this.imc = this.peso / (this.altura * this.altura);
        }

        public void calcularEstatus() {
            if(this.imc < 16) {
                this.estatus = "Delgadez severa";
            }
            else if (this.imc >= 16 && this.imc < 17) {
                this.estatus = "Delgadez moderada";
            }
            else if (this.imc > 17 && this.imc < 18.50) {
                this.estatus = "Delgadez aceptable";
            }
            else if (this.imc >= 18.5 && this.imc < 25) {
                this.estatus = "Peso normal";
            }
            else if (this.imc >= 25 && this.imc < 30) {
                this.estatus = "Sobrepeso";
            }
            else if (this.imc >= 30 && this.imc < 35) {
                this.estatus = "Obesidad 1";
            }
            else if (this.imc >= 35 && this.imc < 40) {
                this.estatus = "Obesidad 2";
            }
            else if (this.imc >= 40 && this.imc < 50) {
                this.estatus = "Obesidad 3";
            }
            else if (this.imc >= 50) {
                this.estatus = "Obesidad 4";
            }
        }

        public void calcularCalorias() {
            
            //Numero de calorias en reposo
            this.calorias = 0;
            
            if (this.getSexo() == 'H') {
                this.calorias = (float)(66 + (13.7 * this.peso) + (5 * this.altura * 100) - (6.75 * this.edad));
            }
            else if (this.getSexo() == 'M') {
                this.calorias = (float)(655 + (9.6 * this.peso) +(1.8 * this.altura * 100) - (4.7 * this.edad));
            }

            if (this.getActividadFisica().Equals("Poco")) {
                this.calorias = (float)(this.calorias * 1.2);
            }
            else if (this.getActividadFisica().Equals("Ligero")) {
                this.calorias = (float)(this.calorias * 1.375);
            }
            else if (this.getActividadFisica().Equals("Moderado")) {
                this.calorias = (float)(this.calorias * 1.55);
            }
            else if (this.getActividadFisica().Equals("Deportista")) {
                this.calorias = (float)(this.calorias * 1.72);
            }
            else if (this.getActividadFisica().Equals("Atleta")) {
                this.calorias = (float)(this.calorias * 1.9);
            }
        }
    }
}
