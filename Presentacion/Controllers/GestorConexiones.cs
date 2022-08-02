using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Presentacion.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Presentacion.Controllers
{
    public class GestorConexiones : Controller
    {
        #region Propiedad

        public HttpClient Cliente { get; set; }

        #endregion

        #region Constructor 

        private void GestorDeConexiones()
        {
            Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("http://localhost:13985/");
            Cliente.DefaultRequestHeaders.Accept.Clear();
            Cliente.DefaultRequestHeaders.Accept.Add
                (
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
        }

        //Métodos
        #region BUS
        public async Task<List<BusModel>> ListarBus(BusModel P_Modelo)
        {
            List<BusModel> lstresultados = new List<BusModel>();
            GestorDeConexiones();
            string url = "api/Proyecto2/ConsultarBus";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<BusModel>>(convertirAstring);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarBus(BusModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/AgregarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarBus(BusModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/EliminarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarBus(BusModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/ModificarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion

        #region CHOFER

        //MÉTODO PARA LISTAR CHOFER EN DB
        public async Task<List<ChoferModel>> ListarChofer(ChoferModel P_Entidad)
        {
            List<ChoferModel> lstresultados = new List<ChoferModel>();
            GestorDeConexiones();
            string url = "api/Proyecto2/ConsultarChofer";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if(resultado.IsSuccessStatusCode)
            {
              var convertirAstring = await resultado.Content.ReadAsStringAsync();
              lstresultados = JsonConvert.DeserializeObject<List<ChoferModel>>(convertirAstring);
            }

            return lstresultados;
        }

        //MÉTODO PARA AGREGAR CHOFER EN DB
        public async Task<bool> AgregarChofer(ChoferModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/AgregarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        //MÉTODO PARA ELIMINAR CHOFER EN DB
        public async Task<bool> EliminarChofer(ChoferModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/EliminarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        //MÉTODO PARA MODIFICAR CHOFER EN DB
        public async Task<bool> ModificarChofer(ChoferModel P_Modelo)
        {
            GestorDeConexiones();
            string url = "api/Proyecto2/ModificarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion

        #region Reserva
        public async Task<List<ReservaModel>> ListarReserva()
        {
            List<ReservaModel> lstresultados = new List<ReservaModel>();
            GestorDeConexiones();
            string url = "api/Reserva/Consultar";
            HttpResponseMessage resultado = await Cliente.GetAsync(url);

            if (resultado.IsSuccessStatusCode)
            {
                var jsonSTRING = await resultado.Content.ReadAsStringAsync();
                lstresultados = JsonConvert.DeserializeObject<List<ReservaModel>>(jsonSTRING);
            }

            return lstresultados;
        }

        public async Task<bool> AgregarReserva(ReservaModel P_Modelo)
        {
            string url = "api/Reserva/Agregar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarReserva(ReservaModel P_Modelo)
        {
            string url = "api/Reserva/Eliminar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }

        public async Task<bool> ModificarReserva(ReservaModel P_Modelo)
        {
            string url = "api/Reserva/Modificar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(url, P_Modelo);
            return resultado.IsSuccessStatusCode;
        }
        #endregion
        #endregion
    }
}
