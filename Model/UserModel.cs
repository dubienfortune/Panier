using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Le_Panier.Model
{
    [FirestoreData]
    public class UserModel
    {
        [FirestoreProperty]
        public string id { get; set; }
        [FirestoreProperty]
        public string reference_marchand { get; set; }
        [FirestoreProperty]
        public string nom { get; set; }
        [FirestoreProperty]
        public string prenom { get; set; }
        [FirestoreProperty]
        public string pseudo { get; set; }
        [FirestoreProperty]
        public string genre { get; set; }
        [FirestoreProperty]
        public string ville { get; set; }
        [FirestoreProperty]
        public string? addresse { get; set; }
        [FirestoreProperty]
        public string compte_type { get; set; }
        [FirestoreProperty]
        public string? profileUrl { get; set; }
    }
}
