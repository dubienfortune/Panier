using Firebase.Database;
using Le_Panier.VueModel;
using Le_Panier.Vues.Register;

namespace Le_Panier
{
    public partial class App : Application
    {

        public App()
        {

            InitializeComponent();
            MainPage = new AppShell();
        }
        private async void chekcLogin()
        {
            bool auth = Preferences.Default.Get<bool>("authState", true);
            if (auth == false)
            {
                //await Shell.Current.GoToAsync();
            }
            else
            {

            }

        }
    }
}
