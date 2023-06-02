using Proyecto_Metodos_Numericos.Datos;
using Proyecto_Metodos_Numericos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Metodos_Numericos.Controllers
{
    public class HomeController : Controller
    {
        //Para el menu de metodos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewtonRaphson()
        {
            return View();
        }
        public ActionResult Secante()
        {
            return View();
        }
        public ActionResult Muller()
        {
            return View();
        }
        public ActionResult GaussMenu()
        {
            return View();
        }
        public ActionResult Gauss2x2()
        {
            return View();
        }
        public ActionResult Gauss3x3()
        {
            return View();
        }
        public ActionResult Gauss4x4()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidarLogin(Usuario usuario)
        {
            //Para guardar el id del usuario
            decimal idUsuario = 0;

            using (Entities_Metodos conexion = new Entities_Metodos())
            {
                var login = (from c in conexion.USUARIO
                             where c.CORREO == usuario.Correo && c.PASSWORDC == usuario.Clave
                             select c).FirstOrDefault();

                //Validamos si no encontramos el usuario
                if (login == null)
                {
                    //Retornamos un Json con una respuesta no exitosa
                    return Json(new { result = false }, JsonRequestBehavior.AllowGet);
                }

                //Recuperamos el id del usuario
                idUsuario = login.IDUSUARIO;
            }

            //Retornamos un Json con una respuesta exitosa
            return Json(new { result = true, usuarioID = idUsuario }, JsonRequestBehavior.AllowGet);
        }

        //Para insertar un cliente nuevo
        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            //Validamos si recibimos un objeto vacío
            if (usuario == null)
            {
                //Retornamos un Json con una respuesta no exitosa
                return Json(new { result = false }, JsonRequestBehavior.AllowGet);
            }

            using (Entities_Metodos conexion = new Entities_Metodos())
            {
                USUARIO nuevoUsuario = new USUARIO();

                decimal idUsuario = conexion.Database.SqlQuery<decimal>("SELECT SW_S_USUARIO.nextval FROM DUAL").SingleOrDefault();

                var validacion = (from c in conexion.USUARIO
                             where c.CORREO == usuario.Correo
                             select c).FirstOrDefault();

                //Validamos si ya hay un usuario con ese correo
                if (validacion != null)
                {
                    //Retornamos un Json con una respuesta no exitosa
                    return Json(new { result = "Existe" }, JsonRequestBehavior.AllowGet);
                }

                //Asignamos los datos a los atributos de la BD
                nuevoUsuario.IDUSUARIO = idUsuario;
                nuevoUsuario.CORREO = usuario.Correo;
                nuevoUsuario.PASSWORDC = usuario.Clave;

                //Agregamos el nuevo usuario
                conexion.USUARIO.Add(nuevoUsuario);

                //Guardamos cambios
                conexion.SaveChanges();
            }

            //Retornamos un Json con una respuesta exitosa
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

        //Para insertar el metodo de newton raphson
        [HttpPost]
        public ActionResult MetodoNewtonRaphson(Newton newton)
        {
            //Validamos si recibimos un objeto vacío
            if (newton == null)
            {
                //Retornamos un Json con una respuesta no exitosa
                return Json(new { result = false }, JsonRequestBehavior.AllowGet);
            }

            using (Entities_Metodos conexion = new Entities_Metodos())
            {
                NEWTON nuevoNewton = new NEWTON();

                decimal idNewton = conexion.Database.SqlQuery<decimal>("SELECT SW_S_NEWTON.nextval FROM DUAL").SingleOrDefault();

                //Asignamos los datos a los atributos de la BD
                nuevoNewton.IDNEWTON = idNewton;
                nuevoNewton.IDUSUARIO = newton.IdUsuario;
                nuevoNewton.ECUACION = newton.Ecuacion;
                nuevoNewton.X0 = newton.X0;
                nuevoNewton.XI = newton.Xi;
                nuevoNewton.EAA = newton.Ea;

                //Agregamos el nuevo dato para el metodo de newton raphson
                conexion.NEWTON.Add(nuevoNewton);

                //Guardamos cambios
                conexion.SaveChanges();
            }

            //Retornamos un Json con una respuesta exitosa
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

        //Para insertar el metodo de la secante
        [HttpPost]
        public ActionResult MetodoSecante(Secante secante)
        {
            //Validamos si recibimos un objeto vacío
            if (secante == null)
            {
                //Retornamos un Json con una respuesta no exitosa
                return Json(new { result = false }, JsonRequestBehavior.AllowGet);
            }

            using (Entities_Metodos conexion = new Entities_Metodos())
            {
                SECANTE nuevaSecante = new SECANTE();

                decimal idSecante = conexion.Database.SqlQuery<decimal>("SELECT SW_S_SECANTE.nextval FROM DUAL").SingleOrDefault();

                //Asignamos los datos a los atributos de la BD
                nuevaSecante.IDSECANTE = idSecante;
                nuevaSecante.IDUSUARIO = secante.IdUsuario;
                nuevaSecante.ECUACION = secante.Ecuacion;
                nuevaSecante.X0 = secante.X0;
                nuevaSecante.X1 = secante.X1;
                nuevaSecante.XI = secante.Xi;
                nuevaSecante.EAA = secante.Ea;

                //Agregamos el nuevo dato para el metodo de la secante
                conexion.SECANTE.Add(nuevaSecante);

                //Guardamos cambios
                conexion.SaveChanges();
            }

            //Retornamos un Json con una respuesta exitosa
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

        //Para insertar el metodo de Muller
        [HttpPost]
        public ActionResult MetodoMuller(Muller muller)
        {
            //Validamos si recibimos un objeto vacío
            if (muller == null)
            {
                //Retornamos un Json con una respuesta no exitosa
                return Json(new { result = false }, JsonRequestBehavior.AllowGet);
            }

            using (Entities_Metodos conexion = new Entities_Metodos())
            {
                MULLER nuevoMuller = new MULLER();

                decimal idMuller = conexion.Database.SqlQuery<decimal>("SELECT SW_S_MULLER.nextval FROM DUAL").SingleOrDefault();

                //Asignamos los datos a los atributos de la BD
                nuevoMuller.IDMULLER = idMuller;
                nuevoMuller.IDUSUARIO = muller.IdUsuario;
                nuevoMuller.ECUACION = muller.Ecuacion;
                nuevoMuller.X0 = muller.X0;
                nuevoMuller.X1 = muller.X1;
                nuevoMuller.X2 = muller.X2;
                nuevoMuller.XI = muller.Xi;
                nuevoMuller.EAA = muller.Ea;

                //Agregamos el nuevo dato para el metodo de la secante
                conexion.MULLER.Add(nuevoMuller);

                //Guardamos cambios
                conexion.SaveChanges();
            }

            //Retornamos un Json con una respuesta exitosa
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

        //Para insertar el metodo de Gauss de matriz 3x3
        [HttpPost]
        public ActionResult MetodoGauss3x3(Gauss3 gauss)
        {
            //Validamos si recibimos un objeto vacío
            if (gauss == null)
            {
                //Retornamos un Json con una respuesta no exitosa
                return Json(new { result = false }, JsonRequestBehavior.AllowGet);
            }

            using (Entities_Metodos conexion = new Entities_Metodos())
            {
                GAUSS3X3 nuevoGauss = new GAUSS3X3();

                decimal idGauss = conexion.Database.SqlQuery<decimal>("SELECT SW_S_GAUSS3X3.nextval FROM DUAL").SingleOrDefault();

                //Asignamos los datos a los atributos de la BD
                nuevoGauss.IDGAUSS = idGauss;
                nuevoGauss.IDUSUARIO = gauss.IdUsuario;
                //nuevoGauss.TIPOMATRIZ = gauss.TipoMatriz;
                //nuevoGauss.DATOSMATRIZ = gauss.DatosMatriz;
                nuevoGauss.X = gauss.X;
                nuevoGauss.Y = gauss.Y;
                nuevoGauss.Z = gauss.Z;

                //Agregamos el nuevo dato para el metodo de gauss 3x3
                conexion.GAUSS3X3.Add(nuevoGauss);

                //Guardamos cambios
                conexion.SaveChanges();
            }

            //Retornamos un Json con una respuesta exitosa
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }
    }
}