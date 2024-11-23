using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Firebase.Database;
using Le_Panier.Model;
using Le_Panier.Services;
using Le_Panier.Vues.Register;

namespace Le_Panier.VueModel
{
    public partial class Etape1VueModel: BaseVueModel
    {
        public readonly IInscriptionServices _InscriptionServices;
        public Etape1VueModel(IInscriptionServices iloginServices)
        {
            _InscriptionServices = iloginServices;
        }

        [ObservableProperty]
        InscriptionModel inscriptionModel = new ();

        [RelayCommand]
        public async Task inscription()
        {
            if (!IsBusy)
            {
              
                if (inscriptionModel.confirme_password == inscriptionModel.password)
                {
                    IsBusy = true;
                    try
                    {
                        var reponse = await _InscriptionServices.Inscription(inscriptionModel.email, inscriptionModel.password);
                        var uid = new Dictionary<string, Object>();
                        uid.Add("id", reponse);
                        await Shell.Current.GoToAsync(nameof(Etape2),true,uid);
                    }
                    catch (FirebaseAuthHttpException ex)
                    {
                        if (ex.Reason.ToString()=="EmailExists")
                        {
                            await Shell.Current.DisplayAlert("Info","Email déjà utilisé", "Ok");
                        }
                    }




                }
                else
                {
                    await Shell.Current.DisplayAlert("Info", "Les mots de passe ne correspondent pas !", "Ok");
                }
                IsBusy = false;
            }
           
            
        }
       
    }
}
