using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Le_Panier.Model
{
    [FirestoreData]
    public class RoleModel
    {
        [FirestoreProperty]
        public string id { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }

    }
}
