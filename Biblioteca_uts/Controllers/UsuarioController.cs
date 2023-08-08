using Biblioteca_uts.Models;
using Biblioteca_uts.Datos;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_uts.Controllers
{
    public class UsuarioController : Controller
    {

        //Datos/ContactoDatos
        UsuarioDatos _Usuario = new UsuarioDatos();
        public IActionResult Listar()
        {
            var lista = _Usuario.Listar();

            return View(lista);
        }
        //##############################
        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]//a
        public IActionResult Guardar(UsariosModels model)
        {
            var UsuarioCreado = _Usuario.GuardarUsuario(model);
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
        public IActionResult Editar(int Identificador)
        {
            UsariosModels _contacto = _Usuario.ObtenerUsuario(Identificador);
            return View();
        }

        [HttpPost]
        public IActionResult Editar(UsariosModels model)
        {
            //para obtener los datos que se editadoen del formulario y enviarlos  en la base de datos 
            if (!ModelState.IsValid)
            {
                return View();
            }
            var respuesta = _Usuario.EditarUsuario(model);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }
        //@model Biblioteca_uts.Models.LibrosModel
        public IActionResult Eliminar(int No_Adquisicion)
        {
            var _contacto = _Usuario.ObtenerUsuario(No_Adquisicion);
            return View(_contacto);
        }

        [HttpPost]
        public IActionResult Eliminar(LibrosModel model)
        {
            /*  var respuesta = _LibrosDatos.EliminarLibro(model.IdContacto);
              if (respuesta)
              {
                  return RedirectToAction("Listar");
              }
              else
              {

              }*/
            return View();//ya que aregle el problemas borrarlo
        }


    }
}