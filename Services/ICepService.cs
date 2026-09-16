using ConsultarCepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCepApp.Services
{
    public interface ICepService
    {
        Task<CepInfo> BuscarCep(string cep);
    }

    public class CepService : ICepService
    {
        private readonly HttpClient _httpClient;

        public CepService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CepInfo> BuscarCep(string cep)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/json/{cep}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CepInfo>();
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
