using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Negocio;
using Entidades;

namespace Presentacion.Controllers
{
    public class EmpleadosController : Controller
    {

        // GET: Empleados
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult TablaEmpleados()
        {
            List<empleados> list = new NEmpleados().Consultar();
            return PartialView(list);
        }
        public ActionResult Delete(int id)
        {
            NEmpleados _nempleado = new NEmpleados();
            empleados empleados = _nempleado.Consultar(id);
            return View(empleados);
        }
        [HttpPost]
        public ActionResult Delete(int id, empleados collection)
        {
            NEmpleados _nempleado = new NEmpleados();
            try
            {
                // TODO: Add delete logic here
                _nempleado.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                empleados emp = _nempleado.Consultar(id);
                return View(emp);
            }
        }
        public ActionResult Edit(int id)
        {
            NEmpleados _nempleado = new NEmpleados();
            empleados emp = _nempleado.Consultar(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(int id,Models.ViewModels.ViewEmpleados view)
        {
            NEmpleados _nempleado = new NEmpleados();
            try
            {
                empleados _empl = new empleados();
                if (ModelState.IsValid)
                {
                    _empl.numEmp = view.NumEmp;
                    _empl.nombre = view.Nombre;
                    _empl.correo = view.Correo;
                    _empl.estatus = view.Estatus;
                    _empl.fechaCreacion = view.FechaCreacion;
                    _nempleado.Actualizar(_empl);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.ViewModels.ViewEmpleados view)
        {
            NEmpleados _nempleado = new NEmpleados();
            try
            {
                empleados _empl = new empleados();
                if (ModelState.IsValid)
                {
                    _empl.numEmp = view.NumEmp;
                    _empl.nombre = view.Nombre;
                    _empl.correo = view.Correo;
                    _empl.estatus = view.Estatus;
                    _empl.fechaCreacion = view.FechaCreacion;
                    _nempleado.Agregar(_empl);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public JsonResult ObtenerListaEmpleados()
        {
            List<empleados> list = new NEmpleados().Consultar();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult _eliminarEmpleado(int id)
        {
            NEmpleados _nEmpleado = new NEmpleados();
            _nEmpleado.Eliminar(id);
            return ObtenerListaEmpleados();
        }

        public ActionResult _DatosEmpleado(int id)
        {
            NEmpleados _nEmpleado = new NEmpleados();
            empleados emp = _nEmpleado.Consultar(id);
            return PartialView(emp);
        }

        public ActionResult eliminarEmpleado(int id)
        {
            NEmpleados _nEmpleado = new NEmpleados();
            empleados emp = _nEmpleado.Consultar(id);
            return PartialView(emp);
        }

        public ActionResult _ActualzarEmpleado(int id)
        {
            NEmpleados _nEmpleado = new NEmpleados();
            empleados emp = _nEmpleado.Consultar(id);
            return PartialView(emp);
        }
    }
}