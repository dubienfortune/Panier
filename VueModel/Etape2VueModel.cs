using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Database;
using Google.Cloud.Firestore;
using Le_Panier.Model;
using Le_Panier.Services;
using Le_Panier.Vues.Register;
using static Google.Rpc.Context.AttributeContext.Types;

namespace Le_Panier.VueModel
{
    [QueryProperty("Uid","id")]
    public partial class Etape2VueModel:BaseVueModel
    {
        
        private readonly FirebaseClient _firebaseClient;
        private readonly IIUserInfosServices _iUserInfosServices;
        [ObservableProperty]
        public string uid;

        [ObservableProperty]
        public WriteResult erreur;

        [ObservableProperty]
        public ObservableCollection<Ville> lsville = new ObservableCollection<Ville>();

        [ObservableProperty]
        public UserModel user=new();

        [ObservableProperty]
        public Ville city= new Ville();

        public Etape2VueModel(IIUserInfosServices iUserInfosServices)
        {
            this._iUserInfosServices = iUserInfosServices;
        }

        [RelayCommand]
        public async Task saveUserInfos()
        {
            user.id = Uid;
            user.ville = City.name;
            string randomNumber = null;
            for (int i = 0; i < 10; i++)
            {
                randomNumber+=new Random().Next(0, 9);
            }
            user.reference_marchand = $"ref{randomNumber}";

            if (!IsBusy)
            {
                IsBusy = true;
              Erreur=await _iUserInfosServices.saveUserInfo(user, Uid);
                var uid_=new Dictionary<string,object>();

                string[] datapass = new string[2]
                {
                    Uid,
                    user.reference_marchand
                };

                uid_.Add("id", datapass);
                await Shell.Current.GoToAsync(nameof(Etape3), true,uid_);
                IsBusy = false;

            }
           
        }

        public async Task  loadVille()
        {
            var v = new Ville()
            {
                id = "1",
                name = "Dolisie"
            };
            var fr = new FirebaseClient("https://lepanier-fd9d3-default-rtdb.europe-west1.firebasedatabase.app");
            var ville=fr.Child("Ville").OnceAsync<Ville>();

            var result = ville.Result.Select(x => x.Object).ToList();

            foreach (var item in result)
            {
                Lsville.Add(item);
            }
        }
    }
}
