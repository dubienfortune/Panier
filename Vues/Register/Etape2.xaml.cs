using CommunityToolkit.Mvvm.ComponentModel;
using Le_Panier.VueModel;

namespace Le_Panier.Vues.Register;

public partial class Etape2 : ContentPage
{
    private readonly Etape2VueModel _inscriptionEtape2ViewModel1;
    public Etape2(Etape2VueModel inscriptionEtape2ViewModel)
	{
		InitializeComponent();

        this._inscriptionEtape2ViewModel1 = inscriptionEtape2ViewModel;
        this.BindingContext = _inscriptionEtape2ViewModel1;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _inscriptionEtape2ViewModel1.loadVille();
    }
}