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
    /// Descripción breve de WebServiceMantenedorPaciente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorPaciente : System.Web.Services.WebService
    {
        [WebMethod]
        public void webGuardarPaciente(Paciente paciente)
        {
            NegocioPaciente auxPaciente = new NegocioPaciente();
            auxPaciente.guardarPaciente(paciente);
        }


        [WebMethod]
        public Paciente webBuscarPaciente(String rut)
        {
            NegocioPaciente auxPaciente = new NegocioPaciente();
            return auxPaciente.buscarPaciente(rut);
        }
    }
}
