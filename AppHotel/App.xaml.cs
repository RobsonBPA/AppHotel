using AppHotel.Models;

namespace AppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>() // Cria uma lista de quartos
        {
            // Suíte Super Luxo
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCrianca = 65.0
            },

            // Suíte Luxo
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 95.0,
                ValorDiariaCrianca = 47.5
            },

            // Suíte Básica Premium
            new Quarto()
            {
                Descricao = "Suíte Básica Premium",
                ValorDiariaAdulto = 75.0,
                ValorDiariaCrianca = 40.0
            },

            // Suíte Básica
            new Quarto()
            {
                Descricao = "Suíte Básica",
                ValorDiariaAdulto = 40.0,
                ValorDiariaCrianca = 25.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
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