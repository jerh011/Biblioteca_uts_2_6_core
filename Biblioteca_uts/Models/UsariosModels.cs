using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Biblioteca_uts.Models
{
    public class UsariosModels
    {
        public int Identificador { get; set; }
	    public string Nombres { get; set; }
        public string ApePa { get; set; }
        public string ApeMa { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string NroCasa { get; set; }
        public string tipo { get; set; }
        public string Contraseña { get; set; }
        public string Usuario { get; set; }

    }
}
