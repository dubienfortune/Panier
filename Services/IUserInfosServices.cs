using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Le_Panier.Model;

namespace Le_Panier.Services
{
    public interface IIUserInfosServices
    {
        public Task<WriteResult> saveUserInfo(UserModel model,string userUid);
    }
}
