using Microsoft.AspNetCore.Mvc;
using IZUMU.Clientes.UI.Models;

namespace IZUMU.Clientes.UI.Controllers
{
    public class DatosPersonalesController : Controller
    {
        private readonly Servicios.DatosPersonalesService _service;

        public DatosPersonalesController(Servicios.DatosPersonalesService service)
        {
            _service = service;
        }

        // Método privado para cargar combos
        private void CargarCombos()
        {
            ViewBag.TiposDeDocumento = TipoDeDocumento.ObtenerTiposPredefinidos()
                .Select(t => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = t.Id,
                    Text = t.Descripcion
                }).ToList();

            ViewBag.PlanesContratados = PlanContratado.ObtenerPlanesPredefinidos()
                .Select(p => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Descripcion
                }).ToList();
        }

        public IActionResult Index()
        {
            var lista = _service.GetAll();
            return View(lista);
        }

        public IActionResult Create()
        {
            CargarCombos();
            try
            {
                return View();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Error interno del servidor " + e.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DatosPersonales datos)
        {
            CargarCombos();
            try
            {
                if (ModelState.IsValid)
                {
                    var existentes = _service.GetAll();
                    bool existe = existentes.Any(x => x.IdTipoDeDocumento == datos.IdTipoDeDocumento && x.NumeroDeDocumento == datos.NumeroDeDocumento);
                    if (existe)
                    {
                        ModelState.AddModelError("NumeroDeDocumento", "Ya existe un cliente con ese tipo y número de documento.");
                        return View(datos);
                    }
                    _service.Add(datos);
                    TempData["SuccessMessage"] = "Cliente guardado correctamente.";
                    return RedirectToAction(nameof(Index));
                }
                return View(datos);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Error interno del servidor " + e.Message);
            }
        }

        public IActionResult Edit(int id)
        {
            CargarCombos();
            try
            {
                var datos = _service.GetById(id);
                if (datos == null)
                {
                    TempData["ErrorMessage"] = "StatusCode(404). No se encontró el cliente solicitado";
                    return RedirectToAction("Index");
                }
                return View(datos);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Error interno del servidor " + e.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, DatosPersonales datos)
        {
            CargarCombos();
            try
            {
                if (ModelState.IsValid)
                {
                    var existentes = _service.GetAll().Where(x => x.IdInformacionPersonal != datos.IdInformacionPersonal);
                    bool existe = existentes.Any(x => x.IdTipoDeDocumento == datos.IdTipoDeDocumento && x.NumeroDeDocumento == datos.NumeroDeDocumento);
                    if (existe)
                    {
                        ModelState.AddModelError("NumeroDeDocumento", "Ya existe otro cliente con ese tipo y número de documento.");
                        return View(datos);
                    }
                    _service.Update(datos);
                    TempData["SuccessMessage"] = "La información del cliente se guardó correctamente.";
                    return RedirectToAction(nameof(Index));
                }
                return View(datos);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Error interno del servidor " + e.Message);
            }
        }

        // DELETE: DatosPersonales/Delete/5
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return Json(new { success = true, message = "La información del cliente se eliminó correctamente." });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = "Error interno del servidor: " + e.Message });
            }
        }
    }
}
