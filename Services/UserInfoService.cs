using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Google.Cloud.Firestore;
using Le_Panier.Model;


namespace Le_Panier.Services
{
    public class UserInfoService : IIUserInfosServices
    {
        private WriteResult result = null;
        private readonly FirestoreService _firestoreService;
        public UserInfoService(FirestoreService firestoreService)
        {
            this._firestoreService = firestoreService;
        }
        public async Task<WriteResult> saveUserInfo(UserModel model, string userUid)
        {
           var _firestore = await _firestoreService.Initialise();


            try
            { 
               result= await _firestore.Collection("Users").Document(userUid).SetAsync(model);
            }
            catch (Exception ex)
            {
                
            }
            return result;
        }
    }
}
