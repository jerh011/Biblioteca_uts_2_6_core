using Biblioteca_uts.Models;
using Biblioteca_uts.Datos;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_uts.Controllers
{
    public class LibrosController : Controller
    {

        //Datos/ContactoDatos
        LibrosDatos _LibrosDatos = new LibrosDatos();
        public IActionResult Listar()
        {
            var lista = _LibrosDatos.Listar();

            return View(lista);
        }
        //##############################
        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(LibrosModel model)
        {
            var UsuarioCreado = _LibrosDatos.GuardarLibro(model);
            if (UsuarioCreado)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }

        }
        //##############################
        public IActionResult Editar(int No_Adquisicion)
        {
            LibrosModel _contacto = _LibrosDatos.ObtenerLibro(No_Adquisicion);
            return View(_contacto);
        }

        [HttpPost]
        public IActionResult Editar(LibrosModel model)
        {
            //para obtener los datos que se editadoen del formulario y enviarlos  en la base de datos 
            if (!ModelState.IsValid)
            {
                return View();
            }
            var respuesta = _LibrosDatos.EditarLibro(model);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar(int No_Adquisicion)
        {
            var _contacto = _LibrosDatos.ObtenerLibro(No_Adquisicion);
            return View(_contacto);
        }

        [HttpPost]
        public IActionResult Eliminar(LibrosModel model)
        {

            var respuesta = _LibrosDatos.EliminarLibro(model.No_Adquisicion);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();//ya que aregle el problemas borrarlo
            }

        }


    }
}