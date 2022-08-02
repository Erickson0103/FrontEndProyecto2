using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class HabitacionController : Controller
    {

        //--------LISTAR HABITACION--------
        public async Task<IActionResult> Index()
        {
            GestorConexiones objconexion = new GestorConexiones();
            List<HabitacionModel> lstresultados = await objconexion.ListarHabitacion(new HabitacionModel { CodHabitacion = short.MinValue });
            return View(lstresultados);
        }

        //--------CREAR--------
        public IActionResult CrearHabitacion()
        {
            return View();
        }

        //--------MODIFICAR--------
        public async Task<IActionResult> EditaHabitacion(HabitacionModel Hab)
        {
            string id = ModelState.Values.Last().RawValue.ToString();
            GestorConexiones objconexion = new GestorConexiones();
            List<HabitacionModel> lstresultados = await objconexion.ListarHabitacion(new HabitacionModel { CodHabitacion = short.MinValue });
            HabitacionModel habitacion = lstresultados.Find(x => x.CodHabitacion.Equals(Hab.CodHabitacion));

            return View(habitacion);
        }

        //--------ELIMINAR--------
        public async Task<IActionResult> Eliminar(HabitacionModel hab)
        {
            

            GestorConexiones objconexion = new GestorConexiones();
            List<HabitacionModel> lstresultados = await objconexion.ListarHabitacion(new HabitacionModel { CodHabitacion = short.MinValue });
            HabitacionModel habitacion = lstresultados.Find(x => x.CodHabitacion.Equals(hab.CodHabitacion));

            return View(habitacion);
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(HabitacionModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.AgregarHabitacion(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(HabitacionModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.ModificarHabitacion(P_Modelo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar_Habitacion(HabitacionModel P_Modelo)
        {
            GestorConexiones objconexion = new GestorConexiones();
            await objconexion.EliminarHabitacion(P_Modelo);
            return RedirectToAction("Index");
        }


    }
}
