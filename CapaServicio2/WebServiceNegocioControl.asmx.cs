using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio2
{
    /// <summary>
    /// Descripción breve de WebServiceNegocioControl
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceNegocioControl : System.Web.Services.WebService
    {

        [WebMethod]
        public void webGuardarControl(Control control, String rutP, string rutM)
        {
            NegocioControl auxNegocioControl = new NegocioControl();
            auxNegocioControl.guardarControl(control, rutP, rutM);
        }

        [WebMethod]
        public DataSet webListarHistorial(String rut)
        {
            NegocioControl auxNegocioControl = new NegocioControl();
            return auxNegocioControl.listarHistorial(rut);
        }

    }
}
