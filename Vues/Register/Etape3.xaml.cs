using CommunityToolkit.Mvvm.ComponentModel;
using Le_Panier.Model;
using Le_Panier.VueModel;

namespace Le_Panier.Vues.Register;

public partial class Etape3 : ContentPage
{
    private readonly Etape3VueModel _roleVuesModel;
    public Etape3(Etape3VueModel roleVuesModel)
	{
		InitializeComponent();

        this._roleVuesModel = roleVuesModel;
        this.BindingContext = _roleVuesModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _roleVuesModel.loadRole();
    }

    private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}