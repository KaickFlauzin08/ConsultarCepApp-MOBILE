namespace ConsultarCepApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("BuscarCnpjPage", typeof(Views.BuscarCnpjPage));
        }
    }
}
