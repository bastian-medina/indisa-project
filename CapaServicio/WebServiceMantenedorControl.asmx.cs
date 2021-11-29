using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceMantenedorControl
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorControl : System.Web.Services.WebService
    {

        [WebMethod]
        public void webGuardarControl(Control control, String rutP, String rutM)
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

        [WebMethod]
        public Control webListarActivosPantalla(int fila)
        {
            NegocioControl auxNegocioControl = new NegocioControl();
            return auxNegocioControl.listarActivosPantalla(fila);
        }


        [WebMethod]
        public Control webListarActivosPantallaReceta(int fila)
        {
            NegocioControl auxNegocioControl = new NegocioControl();
            return auxNegocioControl.listarActivosPantallaReceta(fila);
        }


        [WebMethod]
        public DataSet webListarActivos()
        {
            NegocioControl auxNegocioControl = new NegocioControl();
            return auxNegocioControl.listarActivos();
        }



        [WebMethod]
        public DataSet webListarActivosReceta()
        {
            NegocioControl auxNegocioControl = new NegocioControl();
            return auxNegocioControl.listarActivosReceta();
        }
    }
}
