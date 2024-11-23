using System.Text.Json;
using Google.Apis.Json;
using Google.Cloud.Firestore;
using Le_Panier.Model;
using Le_Panier.Services;
using Le_Panier.VueModel;

namespace Le_Panier.Vues.Register;

public partial class Etape1 : ContentPage
{
    private readonly Etape1VueModel _inscriptionVueModel;

    public Etape1(Etape1VueModel inscriptionVueModel)
	{
		InitializeComponent();
        this._inscriptionVueModel = inscriptionVueModel;
        this.BindingContext = _inscriptionVueModel;
    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
    
    }
}