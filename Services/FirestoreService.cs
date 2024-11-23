using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Le_Panier.Model;

namespace Le_Panier.Services
{
    public class FirestoreService
    {
        public FirestoreService()
        {
            Initialise();
        }
        FirestoreDb _firestoreDb { get; set; }
        public async Task<FirestoreDb> Initialise()
        {
            var stream = await FileSystem.OpenAppPackageFileAsync("adminsdk.json");
            var content = new StreamReader(stream).ReadToEnd();

            _firestoreDb = new FirestoreDbBuilder
            {
                ProjectId = "lepanier-fd9d3",
                ConverterRegistry = new ConverterRegistry 
                {
                },
                JsonCredentials = content

            }.Build();
            return _firestoreDb;

        }

    }
}
