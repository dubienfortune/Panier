using System.Text.Json;
using CommunityToolkit.Maui;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;
using Firebase.Database.Query;
using Le_Panier.Model;
using Le_Panier.Services;
using Le_Panier.VueModel;
using Le_Panier.Vues.Register;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Le_Panier
{
    public static class MauiProgram
    {
        public static  MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
                builder.Services.AddSingleton(new FirebaseClient("https://lepanier-fd9d3-default-rtdb.europe-west1.firebasedatabase.app/"));
                builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
                {
                    ApiKey = "AIzaSyAHx6QdoHZ_ZQ68yRl7UuG6PwQqHwubQpk",
                    AuthDomain = "lepanier-fd9d3.firebaseapp.com",
                    Providers = new[]
                    {
                        new EmailProvider()
                    }

                }));
            builder.Services.AddSingleton<FirestoreService>();

            builder.Services.AddScoped<IIUserInfosServices, UserInfoService>();
            builder.Services.AddScoped<IInscriptionServices, InscriptionService>();

            builder.Services.AddSingleton<Etape1VueModel>();
            builder.Services.AddSingleton<Etape2VueModel>();
            builder.Services.AddSingleton<Etape3VueModel>();
            builder.Services.AddSingleton<Etape4VuieModel>();

            builder.Services.AddSingleton<Etape1>();
            builder.Services.AddSingleton<Etape2>();
            builder.Services.AddSingleton<Etape3>();
            builder.Services.AddSingleton<Etape4>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
        public static void registerRole()
        {

        }
    }
}
