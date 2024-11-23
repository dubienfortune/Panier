using Le_Panier.Vues.Register;

namespace Le_Panier
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage),typeof(MainPage));
            Routing.RegisterRoute(nameof(Etape1), typeof(Etape1));
            Routing.RegisterRoute(nameof(Etape2), typeof(Etape2));
            Routing.RegisterRoute(nameof(Etape3), typeof(Etape3));
            Routing.RegisterRoute(nameof(Etape4), typeof(Etape4));
        }
    }
}
