using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Google.Cloud.Firestore;
using Le_Panier.Model;
using Le_Panier.Services;
using Le_Panier.Vues.Register;

namespace Le_Panier.VueModel
{
    [QueryProperty("User_uid", "id")]
    public partial class Etape3VueModel:BaseVueModel
    {
        private FirestoreDb firestore;
        
        public Etape3VueModel()
        {
             firestore = new FirestoreService().Initialise().Result;

        }

        [ObservableProperty]
        ObservableCollection<RoleModel> listeRoles=new ObservableCollection<RoleModel>();

        [ObservableProperty]
        RoleModel role_id =new();

        [ObservableProperty]
        string[] user_uid= new string[2];

        public async Task loadRole()
        {
            IsBusy = true;
            
            try
            {   
                var content=await firestore.Collection("Roles").GetSnapshotAsync();
                var lsRole = content.Documents.Select(doc =>
                {
                  return doc.ConvertTo<RoleModel>();
                }).ToList();

                foreach (var item in lsRole)
                {
                    ListeRoles.Add(item);
                }
                IsBusy = false;
            }
            catch(Exception ex)
            {

            }
            
        }

        [RelayCommand]
        public async Task saveUserInfos()
        {
            var userSaveRole = await firestore.Collection("Users").Document(User_uid[0]).UpdateAsync("compte_type", Role_id.id);

            var marchand_ref = new Dictionary<string, object>();
            marchand_ref.Add("ref_id", User_uid[1]);
            await Shell.Current.GoToAsync(nameof(Etape4),true,marchand_ref);
        }
    }
}
