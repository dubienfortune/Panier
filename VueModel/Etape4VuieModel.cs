using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Le_Panier.VueModel
{
    [QueryProperty("Ref_", "ref_id")]

    public partial class Etape4VuieModel:BaseVueModel
    {
        [ObservableProperty]
        string ref_="";


        [RelayCommand]
        public async Task Terminer()
        {
            await Shell.Current.GoToAsync(nameof(MainPage), true);
        }
    }


}
