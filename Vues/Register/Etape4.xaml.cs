using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Le_Panier.Model;
using Le_Panier.VueModel;

namespace Le_Panier.Vues.Register;

public partial class Etape4 : ContentPage
{
    private readonly Etape4VuieModel _etape4VuieModel;

    public Etape4(Etape4VuieModel etape4VuieModel)
	{
		InitializeComponent();
        this._etape4VuieModel = etape4VuieModel;
        BindingContext = _etape4VuieModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

    }
    protected override bool OnBackButtonPressed()
    {
        return false;
    }

  

}