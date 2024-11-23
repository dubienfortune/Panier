using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;

namespace Le_Panier.Services
{
    class InscriptionService : IInscriptionServices
    {
        public FirebaseAuthClient _firebaseAuthClient { get; }
        public InscriptionService(FirebaseAuthClient firebaseAuthClient)
        {
            _firebaseAuthClient = firebaseAuthClient;
        }

     

        public async Task<string> Inscription(string email, string password)
        {
            var user= await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(email, password);

            return user.User.Uid;
        }
    }
}
