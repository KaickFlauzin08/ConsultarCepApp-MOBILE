using ConsultarCepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCepApp.Services
{
    public interface ICnpjService
    {
        Task<CnpjInfo> BuscarCnpj(string cnpj);
    }

    public class CnpjService : ICnpjService
    {
        private readonly HttpClient _httpClient;

        public CnpjService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CnpjInfo> BuscarCnpj(string cnpj)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/{cnpj}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CnpjInfo>();
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
