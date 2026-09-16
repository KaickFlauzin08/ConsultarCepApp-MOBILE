using ConsultarCepApp.ViewModels;

namespace ConsultarCepApp.Views;

public partial class BuscarCnpjPage : ContentPage
{
	public BuscarCnpjPage(BuscarCnpjViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}