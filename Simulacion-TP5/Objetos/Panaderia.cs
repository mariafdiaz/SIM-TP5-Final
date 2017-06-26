using System.Collections.Generic;

namespace Simulacion_TP5.Objetos
{
    public class Panaderia 
    {


        public string Estado { get; set; }
        public Queue<Cliente> cola;
        public Queue<Cliente> Cola { get => cola; set => cola = value; }
        public double finAtencion { get; set; }
        public Cliente clienteSirviendose;//Cliente actual que esta siendo atendido
       

        public Panaderia()
        {
            
            Estado = "L";
            cola = new Queue<Cliente>();
            clienteSirviendose = null;
        }

     
    }
}
