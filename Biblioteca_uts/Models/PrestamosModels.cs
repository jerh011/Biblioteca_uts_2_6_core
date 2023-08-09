namespace Biblioteca_uts.Models
{
    public class PrestamosModels
    {
        public int Id_Prestamo { get; set; }
       public int Identificador { get; set; }
       public DateTime Fecha_prestamo { get; set; }
        public DateTime Fecha_devolucion { get; set; }
        public int No_Adquisicion { get; set; }
    }
}
