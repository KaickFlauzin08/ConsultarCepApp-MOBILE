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
    public partial class BuscarCnpjViewModel : ObservableObject
    {
        [ObservableProperty]
        private CnpjInfo _resultado;

        [ObservableProperty]
        private string _cnpjInput;

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private bool _isNotBusy = true;

        [ObservableProperty]
        private bool _temResultado;

        private readonly ICnpjService _cnpjService;
        
        public BuscarCnpjViewModel(ICnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }
        [RelayCommand]
        private async Task BuscarCnpj(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(CnpjInput) || CnpjInput.Length ==0) 
            {
                await Shell.Current.DisplayAlert("Aviso", "Digite um CNPJ válido", "Voltar");
            }
            IsBusy = true;
            IsNotBusy = false;
            TemResultado = false;
            Resultado = null;

            var dadosCnpj = await _cnpjService.BuscarCnpj(CnpjInput);
            if (dadosCnpj != null)
            {
                Resultado = dadosCnpj;
                TemResultado = true;
            }
            else
            {
                await Shell.Current.DisplayAlert("Ops!", "CNPJ não encontrado", "0k");
            }
            IsNotBusy = true;
            IsBusy = false;
        }
    }
}
