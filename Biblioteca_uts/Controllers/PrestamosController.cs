using Biblioteca_uts.Datos;
using Biblioteca_uts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_uts.Controllers
{
    public class PrestamosController : Controller
    {

        //Datos/ContactoDatos
        PrestamosDatos _prestamos = new PrestamosDatos();
        public IActionResult Listar()
        {
            var lista = _prestamos.Listar();

            return View(lista);
        }
        //##############################
        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(PrestamosModels model)
        {
            var UsuarioCreado = _prestamos.GuardarPrestamo(model);
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
        public IActionResult Editar(int IdPrestamo)
        {
            PrestamosModels _contacto = _prestamos.ObtenerPrestamo(IdPrestamo);
            return View(_contacto);
        }

        [HttpPost]
        public IActionResult Editar(PrestamosModels model)
        {
            //para obtener los datos que se editadoen del formulario y enviarlos  en la base de datos 
           
            var respuesta = _prestamos.EditarPrestamo(model);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar(int IdPrestamo)
        {
            var _contacto = _prestamos.ObtenerPrestamo(IdPrestamo);
            return View(_contacto);
        }

        [HttpPost]
        public IActionResult Eliminar(PrestamosModels model)
        {
            
            var respuesta = _prestamos.EliminarPrestamo(model.IdPrestamo);
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