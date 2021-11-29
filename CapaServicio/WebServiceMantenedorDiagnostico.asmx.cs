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
    /// Descripción breve de WebServiceMantenedorDiagnostico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorDiagnostico : System.Web.Services.WebService
    {


        [WebMethod]
        public void webGuardarDiagnostico(Diagnostico diagnostico, String idControl, String tipoDiagnostico)
        {
            NegocioDiagnostico auxNegocio = new NegocioDiagnostico();
            auxNegocio.guardarDiagnostico(diagnostico, idControl, tipoDiagnostico);
        }

        [WebMethod]
        public void webCambiarEstadoConsulta(String idControl, String rut)
        {
            NegocioDiagnostico auxNegocio = new NegocioDiagnostico();
            auxNegocio.cambiarEstadoConsulta(idControl, rut);
        }
    }
}
