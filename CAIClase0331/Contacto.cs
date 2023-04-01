using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIClase0331
{
    public class Contacto
    {
        private string nombre;
        private string apellido;
        private int codigo;
        private string telefono;
        private string direccion;
        private DateTime fechaDeNacimiento;
        private int llamadas;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Llamadas { get => llamadas; set => llamadas = value; }

        public Contacto()
        {

        }

        public int Edad()
        {
            // calcular edad
        }

        public void Llamar()
        {
            // LLamar contacto
        }

    }
}
