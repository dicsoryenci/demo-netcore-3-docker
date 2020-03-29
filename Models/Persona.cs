using System.ComponentModel.DataAnnotations;

namespace webmvc
{
    public class Persona
    {
        public int cod_persona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}