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
    /// Descripción breve de WebServiceMantenedorMedico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorMedico : System.Web.Services.WebService
    {

        [WebMethod]
        public Medico webBuscarMedico(String rut)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            return auxNegocioMedico.buscarMedico(rut);
        }



        [WebMethod]
        public Medico webBuscarNombresMedico(String rut)
        {
            NegocioMedico auxNegocioMedico = new NegocioMedico();
            return auxNegocioMedico.buscarNombresMedico(rut);
        }
    }
}
