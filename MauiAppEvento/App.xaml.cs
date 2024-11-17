using MauiAppEvento.model;

namespace MauiAppEvento
{
    public partial class App : Application
    {
        public List<Locais> Lista_Locais = new List<Locais>
        {
            new Locais()
            {
                Descricao = "Buffet e CIA",
                Vdiaria = 400.0,
            },
            new Locais()
            {
                Descricao = "Agora é festa",
                Vdiaria = 500.0,            
            },
            new Locais()
            {
                Descricao = "Kiara e Eventos",
                Vdiaria = 600.0,
            },
            new Locais()
            {
                Descricao = "Festejo",
                Vdiaria = 700.0,
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
       protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
