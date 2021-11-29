using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceMantenedorReceta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorReceta : System.Web.Services.WebService
    {

        [WebMethod]
        public void webGuardarReceta(Receta receta, String idControl)
        {
            NegocioReceta auxNegocioReceta = new NegocioReceta();
            auxNegocioReceta.guardarReceta(receta, idControl);
        }

        [WebMethod]
        public void webCambiarEstadoConsulta(String idControl, String rut)
        {
            NegocioReceta auxNegocioReceta = new NegocioReceta();
            auxNegocioReceta.cambiarEstadoConsulta(idControl, rut);
        }
    }
}
