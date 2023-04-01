using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CAIClase0331.Program;

namespace CAIClase0331
{
    public class Agenda
    {
        private string nombre;
        private string tipo;
        private List<Contacto> contactos;
        private int cantidadMaximaContactos;

        public Agenda()
        {
            contactos = new List<Contacto>();
        }

        public void AgregarContacto(Contacto contacto)
        {
            contactos.Add(contacto);
        }

        public void EliminarContacto(int codigo)
        {
            Contacto contactoAEliminar = null;
            foreach (Contacto contacto in contactos)
            {
                if (contacto.Codigo == codigo)
                {
                    contactoAEliminar = contacto;
                    break;
                }
            }
            if (contactoAEliminar != null)
            {
                contactos.Remove(contactoAEliminar);
                Console.WriteLine("eliminado");
            }
        }

        public void TraerContactoFrecuente(Contacto contacto)
        {
            contactos.Add(contacto);
        }
    }
}
