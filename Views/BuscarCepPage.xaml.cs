using ConsultarCepApp.ViewModels;

namespace ConsultarCepApp.Views;

public partial class BuscarCepPage : ContentPage
{
	public BuscarCepPage(BuscarCepViewModel  viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}