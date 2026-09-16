using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ConsultarCepApp.Models;
using ConsultarCepApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCepApp.ViewModels
{
    public partial class BuscarCepViewModel : ObservableObject
    {
        [ObservableProperty]
        private CepInfo _resultado;

        [ObservableProperty]
        private string _cepInput;

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private bool _isNotBusy = true;

        [ObservableProperty]
        private bool _temResultado;

        private readonly ICepService _cepService;

        public BuscarCepViewModel(ICepService cepService)
        {
            _cepService = cepService;
        }
        [RelayCommand]
        private async Task BuscarCep(string cep)
        {
           if (string.IsNullOrWhiteSpace(CepInput) || CepInput.Length != 8)  
            {
                await Shell.Current.DisplayAlert("Aviso", "Digite um CEP válido", "Voltar");
            }
           IsBusy = true;
           IsNotBusy = false;
           TemResultado = false;
           Resultado = null;

            var dadosCep = await _cepService.BuscarCep(CepInput);

            if(dadosCep != null)
            {
                Resultado = dadosCep;
                TemResultado = true;
            }
            else
            {
                await Shell.Current.DisplayAlert("Ops!", "CEP não encontrado", "0k");
            }
            IsBusy = false;
            IsNotBusy = true;
        }

        [RelayCommand]
        public async Task NavegarCnpj()
        {
            await Shell.Current.GoToAsync("BuscarCnpjPage");
        }
    }
}
